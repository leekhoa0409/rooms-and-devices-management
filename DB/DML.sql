USE QLThuVien;
GO

-- CÁC TRIGGER --
--- TRIGGER CẬP NHẬT TRẠNG THÁI BẢO TRÌ ---
DROP TRIGGER IF EXISTS trg_UpdateBaoTri_NgayBT
GO
CREATE TRIGGER trg_UpdateBaoTri_NgayBT
ON BaoTri
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF UPDATE(NgayBT)
    BEGIN
        -- Ngày bảo trì lớn hơn hiện tại → Đang thực hiện
        UPDATE b
        SET b.TrangThai = N'Đang thực hiện'
        FROM BaoTri b
        INNER JOIN inserted i ON b.MaBT = i.MaBT
        WHERE i.NgayBT IS NOT NULL AND i.NgayBT > GETDATE();

        -- Ngày bảo trì nhỏ hơn hoặc bằng hiện tại → Đã hoàn thành
        UPDATE b
        SET b.TrangThai = N'Đã hoàn thành'
        FROM BaoTri b
        INNER JOIN inserted i ON b.MaBT = i.MaBT
        WHERE i.NgayBT IS NOT NULL AND i.NgayBT <= GETDATE();
    END
END;
GO

-- TRIGGER TỰ ĐỘNG THÊM BẢO TRÌ SAU KHI PHÊ DUYỆT YÊU CẦU --
DROP TRIGGER IF EXISTS trg_TuDongThemBaoTriSauKhiPheDuyetYeuCau
GO
CREATE TRIGGER trg_TuDongThemBaoTriSauKhiPheDuyetYeuCau
ON YeuCauBaoTri
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Chỉ xử lý khi trạng thái đổi sang "Đã duyệt"
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN deleted d ON i.MaYC = d.MaYC
        WHERE i.TrangThai = N'Đã duyệt'
          AND d.TrangThai <> N'Đã duyệt'
    )
    BEGIN
        BEGIN TRANSACTION;
        BEGIN TRY
            DECLARE @MaYC CHAR(10), @NewMaBT CHAR(10), @MaxNum INT;

            -- Lấy MaYC vừa được phê duyệt
            SELECT TOP 1 @MaYC = i.MaYC
            FROM inserted i
            JOIN deleted d ON i.MaYC = d.MaYC
            WHERE i.TrangThai = N'Đã duyệt'
              AND d.TrangThai <> N'Đã duyệt';

            SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

            -- Sinh mã BT mới
            SELECT @MaxNum = MAX(CAST(SUBSTRING(MaBT, 3, 3) AS INT))
            FROM BaoTri WITH (TABLOCKX);

            SET @NewMaBT = 'BT' + RIGHT('000' + CAST(ISNULL(@MaxNum, 0) + 1 AS VARCHAR), 3);

            -- Thêm vào bảng Bảo trì
            INSERT INTO BaoTri(MaBT, MaYC, TrangThai, NgayBT)
            VALUES(@NewMaBT, @MaYC, N'Chưa bắt đầu', NULL);

            -- Nếu là yêu cầu bảo trì Phòng
            IF EXISTS (SELECT 1 FROM YeuCauBaoTriPhong WHERE MaYC = @MaYC)
            BEGIN
                INSERT INTO BaoTriPhong(MaBT, MaPhong)
                SELECT @NewMaBT, MaPhong
                FROM YeuCauBaoTriPhong
                WHERE MaYC = @MaYC;
            END

            -- Nếu là yêu cầu bảo trì Thiết bị
            IF EXISTS (SELECT 1 FROM YeuCauBaoTriThietBi WHERE MaYC = @MaYC)
            BEGIN
                INSERT INTO BaoTriThietBi(MaBT, MaTB, MaPhong)
                SELECT @NewMaBT, MaTB, MaPhong
                FROM YeuCauBaoTriThietBi
                WHERE MaYC = @MaYC;
            END

            COMMIT TRANSACTION;
        END TRY
        BEGIN CATCH
            IF @@TRANCOUNT > 0
                ROLLBACK TRANSACTION;
            THROW;
        END CATCH
    END
END;
GO

DROP TRIGGER IF EXISTS trg_AfterInsert_TaiKhoan
GO
CREATE TRIGGER trg_AfterInsert_TaiKhoan
ON TaiKhoan
AFTER INSERT
AS
BEGIN
    DECLARE @TenTK NVARCHAR(20), @MatKhau NVARCHAR(30), @VaiTro NVARCHAR(20);
    SELECT @TenTK = TenTK, @MatKhau = MatKhau, @VaiTro = VaiTro FROM inserted;

    -- Tạo LOGIN
    DECLARE @sql NVARCHAR(MAX) = 
        'CREATE LOGIN [' + @TenTK + '] WITH PASSWORD = ''' + @MatKhau + ''';';
    EXEC (@sql);

    -- Tạo USER trong DB hiện tại
    SET @sql = 'CREATE USER [' + @TenTK + '] FOR LOGIN [' + @TenTK + '];';
    EXEC (@sql);

    -- Gán quyền theo VaiTro (role có sẵn trong DB)
    SET @sql = 'EXEC sp_addrolemember ''' + @VaiTro + ''', [' + @TenTK + '];';
    EXEC (@sql);
END;
GO

DROP TRIGGER IF EXISTS trg_AfterDelete_TaiKhoan
GO
CREATE TRIGGER trg_AfterDelete_TaiKhoan
ON TaiKhoan
AFTER DELETE
AS
BEGIN
    DECLARE @TenTK NVARCHAR(20);
    SELECT @TenTK = TenTK FROM deleted;

    DECLARE @sql NVARCHAR(MAX);

    -- Xóa USER trước
    SET @sql = 'DROP USER IF EXISTS [' + @TenTK + '];';
    EXEC (@sql);

    -- Xóa LOGIN
    SET @sql = 'DROP LOGIN [' + @TenTK + '];';
    EXEC (@sql);
END;
GO

DROP TRIGGER IF EXISTS trg_SuaVaiTroTaiKhoan
GO
CREATE TRIGGER trg_SuaVaiTroTaiKhoan
ON TaiKhoan
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Chỉ chạy khi cột VaiTro thay đổi
    IF UPDATE(VaiTro)
    BEGIN
        DECLARE @TenTK NVARCHAR(20);
        DECLARE @VaiTroMoi NVARCHAR(20);
        DECLARE @VaiTroCu NVARCHAR(20);
        DECLARE @sql NVARCHAR(MAX);

        SELECT 
            @TenTK = i.TenTK,
            @VaiTroMoi = i.VaiTro,
            @VaiTroCu = d.VaiTro
        FROM inserted i
        JOIN deleted d ON i.TenTK = d.TenTK;

        -- Nếu VaiTro thay đổi thật sự
        IF @VaiTroMoi <> @VaiTroCu
        BEGIN
            BEGIN TRY
                -- Gỡ bỏ role cũ (nếu tồn tại)
                SET @sql = N'ALTER ROLE [' + @VaiTroCu + '] DROP MEMBER [' + @TenTK + '];';
                EXEC sp_executesql @sql;

                -- Thêm vào role mới
                SET @sql = N'ALTER ROLE [' + @VaiTroMoi + '] ADD MEMBER [' + @TenTK + '];';
                EXEC sp_executesql @sql;
            END TRY
            BEGIN CATCH
                PRINT N'Lỗi khi cập nhật role cho Login ' + @TenTK;
            END CATCH
        END
    END
END;
GO
-- CHỨC NĂNG CHO PHẦN ĐĂNG NHẬP --
DROP PROC IF EXISTS sp_KiemTraDangNhap 
GO
CREATE PROC sp_KiemTraDangNhap 
	@TenTK NVARCHAR(20),
	@MatKhau NVARCHAR(100)
AS 
BEGIN
	SELECT *
	FROM TaiKhoan
	WHERE TenTK = @TenTK AND MatKhau = @MatKhau
END;
GO

-- CÁC CHỨC NĂNG DÀNH CHO TÀI KHOẢN --
-- DÀNH CHO USER --
DROP FUNCTION IF EXISTS fn_ThongTinTaiKhoan
GO
CREATE FUNCTION fn_ThongTinTaiKhoan(@TenTK NVARCHAR(20))
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM TaiKhoan
	WHERE TenTK = @TenTK
);
GO

DROP PROC IF EXISTS sp_LayDanhSachYeuCauTheoTenTK
GO
CREATE PROC sp_LayDanhSachYeuCauTheoTenTK
	@TenTK NVARCHAR(20)
AS
BEGIN
	SELECT ycbt.MaYC, ycbt.TenTK, ycbt.NgayYC, ycbt.NoiDung, ycbt.TrangThai
	FROM YeuCauBaoTri ycbt
	JOIN TaiKhoan tk ON ycbt.TenTK = tk.TenTK
	WHERE tk.TenTK = @TenTK
END;
GO

DROP PROC IF EXISTS sp_ThemTaiKhoan
GO
CREATE PROCEDURE sp_ThemTaiKhoan
    @TenTK NVARCHAR(20),
    @MatKhau NVARCHAR(30),
    @VaiTro NVARCHAR(20) = 'UserRole'
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		BEGIN TRANSACTION;

		INSERT INTO TaiKhoan(TenTK, MatKhau, VaiTro)
		VALUES(@TenTK, @MatKhau, @VaiTro);
		
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW
	END CATCH
END;

GO
DROP PROC IF EXISTS sp_XoaTaiKhoan;
GO
CREATE PROCEDURE sp_XoaTaiKhoan
    @TenTK NVARCHAR(20)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION;

		DELETE FROM TaiKhoan 
		WHERE TenTK = @TenTK;

		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO

DROP PROC IF EXISTS sp_SuaVaiTroTaiKhoan
GO
CREATE PROCEDURE sp_SuaVaiTroTaiKhoan
    @TenTK NVARCHAR(20),
    @VaiTro NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra đầu vào
    IF @TenTK IS NULL OR @VaiTro IS NULL
    BEGIN
        RAISERROR(N'Tên tài khoản và vai trò không được để trống!', 16, 1);
        RETURN;
    END

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Kiểm tra tài khoản tồn tại
        IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTK)
        BEGIN
            RAISERROR(N'Tài khoản không tồn tại!', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Cập nhật vai trò
        UPDATE TaiKhoan
        SET VaiTro = @VaiTro
        WHERE TenTK = @TenTK;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
		THROW;
    END CATCH
END;
GO

DROP PROC IF EXISTS sp_LayTatCaTaiKhoan
GO
CREATE PROC sp_LayTatCaTaiKhoan
AS
BEGIN
	SELECT TenTK, VaiTro
	FROM TaiKhoan;
END;
GO

-- CÁC CHỨC NĂNG CHO THỐNG KÊ
DROP VIEW IF EXISTS v_LayTatCaCacNamBaoTri
GO
CREATE VIEW v_LayTatCaCacNamBaoTri
AS
SELECT DISTINCT YEAR(NgayBT) AS NamBT FROM BaoTri
GO

DROP FUNCTION IF EXISTS fn_SoLuongPhongTheoLoai
GO
CREATE FUNCTION fn_SoLuongPhongTheoLoai()
RETURNS TABLE
AS
RETURN
(
	SELECT LoaiPhong, COUNT(*) AS SoLuong
	FROM Phong
	GROUP BY LoaiPhong
);
GO

DROP FUNCTION IF EXISTS fn_SoLuongThietBiTheoTinhTrang
GO
CREATE FUNCTION fn_SoLuongThietBiTheoTinhTrang()
RETURNS TABLE
AS
RETURN
(
    SELECT tb.TinhTrang, SUM(ptb.SoLuong) AS SoLuong
    FROM ThietBi tb
    INNER JOIN Phong_ThietBi ptb ON tb.MaTB = ptb.MaTB
    GROUP BY tb.TinhTrang
);
GO

DROP PROC IF EXISTS sp_BaoTriTheoNam
GO
CREATE PROC sp_BaoTriTheoNam
    @Nam INT
AS
BEGIN
    SELECT 
        MONTH(NgayBT) AS Thang, 
        COUNT(*) AS SoLuong
    FROM BaoTri		
    WHERE YEAR(NgayBT) = @Nam
    GROUP BY MONTH(NgayBT)
    ORDER BY Thang;
END;
GO

DROP PROC IF EXISTS sp_ChiPhiBaoTriPhongTheoThangNam
GO
CREATE PROC sp_ChiPhiBaoTriPhongTheoThangNam 
    @Nam INT
AS
BEGIN
    SELECT 
        p.MaPhong,
        p.TenPhong,
        MONTH(bt.NgayBT) AS Thang,
        SUM(bt.ChiPhi) AS TongChiPhi
    FROM BaoTri bt
    JOIN BaoTriPhong btp ON bt.MaBT = btp.MaBT
    JOIN Phong p ON btp.MaPhong = p.MaPhong
    WHERE YEAR(bt.NgayBT) = @Nam
    GROUP BY p.MaPhong, p.TenPhong, MONTH(bt.NgayBT)
    ORDER BY p.MaPhong, Thang;
END;
GO

-- CÁC CHỨC NĂNG CHO PHÒNG --
DROP VIEW IF EXISTS v_LayTatCaPhong
GO
CREATE VIEW v_LayTatCaPhong
AS
SELECT * FROM Phong;
GO

DROP PROC IF EXISTS sp_ThemPhong;
GO
CREATE PROCEDURE sp_ThemPhong
    @TenPhong NVARCHAR(30),
    @LoaiPhong NVARCHAR(10),
    @SucChua INT,
    @TinhTrang NCHAR(20)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        DECLARE @NextMaPhong CHAR(10);

        SELECT @NextMaPhong = 'P' + RIGHT('000' + 
                            CAST(ISNULL(MAX(CAST(SUBSTRING(MaPhong, 2, LEN(MaPhong)) AS INT)), 0) + 1 AS VARCHAR), 3)
        FROM Phong;

        INSERT INTO Phong(MaPhong, TenPhong, LoaiPhong, SucChua, TinhTrang)
        VALUES (@NextMaPhong, @TenPhong, @LoaiPhong, @SucChua, @TinhTrang);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

DROP PROC IF EXISTS sp_SuaPhong
GO
CREATE PROCEDURE sp_SuaPhong
    @MaPhong CHAR(10),
    @TenPhong NVARCHAR(30),
    @LoaiPhong NVARCHAR(10),
    @SucChua INT,
    @TinhTrang NCHAR(20)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;
        UPDATE Phong
        SET TenPhong = @TenPhong,
            LoaiPhong = @LoaiPhong,
            SucChua = @SucChua,
            TinhTrang = @TinhTrang
        WHERE MaPhong = @MaPhong;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

DROP PROC IF EXISTS sp_XoaPhong
GO 
CREATE PROCEDURE sp_XoaPhong
    @MaPhong CHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM BaoTriPhong WHERE MaPhong = @MaPhong;
        DELETE FROM Phong_ThietBi WHERE MaPhong = @MaPhong;
        DELETE FROM Phong WHERE MaPhong = @MaPhong;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

DROP FUNCTION IF EXISTS fn_TimPhong
GO
CREATE FUNCTION fn_TimPhong(@Keyword NVARCHAR(50))
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Phong
    WHERE MaPhong LIKE '%' + @Keyword + '%'
       OR TenPhong LIKE '%' + @Keyword + '%'
	   OR LoaiPhong LIKE '%' + @Keyword + '%'
	   OR TinhTrang LIKE '%' + @Keyword + '%'
);
GO

DROP FUNCTION IF EXISTS fn_LocPhong
GO
CREATE FUNCTION fn_LocPhong(@LoaiPhong NVARCHAR(10) = NULL, @TinhTrang NCHAR(20) = NULL)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Phong
    WHERE (@LoaiPhong IS NULL OR LoaiPhong = @LoaiPhong)
      AND (@TinhTrang IS NULL OR TinhTrang = @TinhTrang)
);
GO

DROP FUNCTION IF EXISTS fn_DemSoPhong
GO
CREATE FUNCTION fn_DemSoPhong()
RETURNS INT
AS
BEGIN
    DECLARE @SoPhong INT;
    SELECT @SoPhong = COUNT(*) FROM Phong;
    RETURN @SoPhong;
END;
GO

-- CHỨC NĂNG PHỤ
DROP FUNCTION IF EXISTS fn_LayPhongQuaMaPhong
GO
CREATE FUNCTION fn_LayPhongQuaMaPhong(@MaPhong CHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Phong
    WHERE MaPhong = @MaPhong
);
GO

-- CÁC CHỨC NĂNG CHO THIẾT BỊ --
DROP VIEW IF EXISTS v_LayTatCaThietBi
GO
CREATE VIEW v_LayTatCaThietBi
AS
SELECT * FROM ThietBi;
GO

DROP PROC IF EXISTS sp_ThemThietBi
GO
CREATE PROCEDURE sp_ThemThietBi
    @TenTB NVARCHAR(30),
    @LoaiTB NVARCHAR(10),
    @NgayMua DATE,
    @TinhTrang NCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @NextMaTB CHAR(10);

        SELECT @NextMaTB = 'TB' + RIGHT('000' +
                            CAST(ISNULL(MAX(CAST(SUBSTRING(MaTB, 3, LEN(MaTB)) AS INT)), 0) + 1 AS VARCHAR), 3)
        FROM ThietBi;

        INSERT INTO ThietBi (MaTB, TenTB, LoaiTB, NgayMua, TinhTrang)
        VALUES (@NextMaTB, @TenTB, @LoaiTB, @NgayMua, @TinhTrang);
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
	    IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

DROP PROC IF EXISTS sp_SuaThietBi
GO
CREATE PROCEDURE sp_SuaThietBi
    @MaTB CHAR(10),
    @TenTB NVARCHAR(30),
    @LoaiTB NVARCHAR(10),
    @NgayMua DATE,
    @TinhTrang NCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        UPDATE ThietBi
        SET TenTB = @TenTB,
            LoaiTB = @LoaiTB,
            NgayMua = @NgayMua,
            TinhTrang = @TinhTrang
        WHERE MaTB = @MaTB;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

DROP PROC IF EXISTS sp_XoaThietBi
GO
CREATE PROCEDURE sp_XoaThietBi
    @MaTB CHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM BaoTriThietBi WHERE MaTB = @MaTB;
        DELETE FROM Phong_ThietBi WHERE MaTB = @MaTB;
        DELETE FROM ThietBi WHERE MaTB = @MaTB;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
    END CATCH
END;
GO

DROP FUNCTION IF EXISTS fn_TimThietBi
GO
CREATE FUNCTION fn_TimThietBi(@Keyword NVARCHAR(50))
RETURNS TABLE
AS
RETURN
(
    SELECT * FROM ThietBi
    WHERE MaTB LIKE '%' + @Keyword + '%'
       OR TenTB LIKE '%' + @Keyword + '%'
       OR LoaiTB LIKE '%' + @Keyword + '%'
       OR TinhTrang LIKE '%' + @Keyword + '%'
);
GO

DROP FUNCTION IF EXISTS fn_LocThietBi
GO
CREATE FUNCTION fn_LocThietBi(@FromDate DATE, @ToDate DATE, @TinhTrang NCHAR(20) = NULL)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM ThietBi
    WHERE NgayMua BETWEEN @FromDate AND @ToDate
      AND (@TinhTrang IS NULL OR TinhTrang = @TinhTrang)
);
GO

DROP FUNCTION IF EXISTS fn_DemSoThietBi
GO
CREATE FUNCTION fn_DemSoThietBi()
RETURNS INT
AS
BEGIN
    DECLARE @SoTB INT;
    SELECT @SoTB = COUNT(*) FROM ThietBi;
    RETURN @SoTB;
END;
GO

-- CHỨC NĂNG PHỤ --
DROP FUNCTION IF EXISTS fn_LayThietBiQuaMaThietBi
GO
CREATE FUNCTION fn_LayThietBiQuaMaThietBi(@MaTB CHAR(10))
RETURNS TABLE
AS
RETURN
(
	SELECT *
	FROM ThietBi
	WHERE MaTB = @MaTB
);
GO

DROP FUNCTION IF EXISTS fn_LocThietBiTheoTinhTrang
GO
CREATE FUNCTION fn_LocThietBiTheoTinhTrang(@TinhTrang NVARCHAR(20))
RETURNS TABLE
AS
RETURN
(
	SELECT *
	FROM ThietBi tb
	WHERE TinhTrang = @TinhTrang
);
GO

-- CÁC CHỨC NĂNG CHO PHÒNG VÀ THIẾT BỊ
-- DÀNH CHO BÊN ADMIN
DROP VIEW IF EXISTS v_Phong_ThietBi
GO
CREATE VIEW v_Phong_ThietBi AS
SELECT 
    p.MaPhong,
    p.TenPhong,
    p.LoaiPhong,
    tb.MaTB,
    tb.TenTB,
    ptb.SoLuong
FROM Phong p
JOIN Phong_ThietBi ptb ON p.MaPhong = ptb.MaPhong
JOIN ThietBi tb ON ptb.MaTB = tb.MaTB;
GO

DROP PROC IF EXISTS sp_ThemThietBiVaoPhong
GO
CREATE PROC sp_ThemThietBiVaoPhong
    @MaPhong CHAR(10),
    @MaTB NVARCHAR(10),
    @SoLuong INT
AS
BEGIN
	BEGIN TRANSACTION;
	BEGIN TRY
		-- Kiểm tra nếu đã tồn tại thì chỉ cập nhật số lượng
		IF EXISTS (SELECT 1 FROM Phong_ThietBi WHERE MaPhong = @MaPhong AND MaTB = @MaTB)
		BEGIN
			UPDATE Phong_ThietBi
			SET SoLuong = SoLuong + @SoLuong
			WHERE MaPhong = @MaPhong AND MaTB = @MaTB;
		END
		ELSE
		BEGIN
			INSERT INTO Phong_ThietBi (MaPhong, MaTB, SoLuong)
			VALUES (@MaPhong, @MaTB, @SoLuong);
		END
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO

DROP PROC IF EXISTS sp_SuaSoLuongThietBiTrongPhong
GO
CREATE PROC sp_SuaSoLuongThietBiTrongPhong
    @MaPhong CHAR(10),
    @MaTB CHAR(10),
    @SoLuong INT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Kiểm tra có bản ghi chưa
        IF NOT EXISTS (
            SELECT 1 
            FROM Phong_ThietBi 
            WHERE MaPhong = @MaPhong AND MaTB = @MaTB
        )
        BEGIN
            RAISERROR(N'Bản ghi không tồn tại. Vui lòng tạo mới trước khi cập nhật.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        -- Nếu có thì update
        UPDATE Phong_ThietBi
        SET SoLuong = @SoLuong
        WHERE MaPhong = @MaPhong AND MaTB = @MaTB;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

DROP PROC IF EXISTS sp_XoaThietBiKhoiPhong
GO
CREATE PROC sp_XoaThietBiKhoiPhong
    @MaPhong CHAR(10),
    @MaTB CHAR(10)
AS
BEGIN
	BEGIN TRANSACTION;
	BEGIN TRY
		DELETE FROM Phong_ThietBi
		WHERE MaPhong = @MaPhong AND MaTB = @MaTB;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO

-- DÀNH CHO BÊN USER
DROP VIEW IF EXISTS v_ThongTinChiTietPhongThietBi
GO
CREATE VIEW v_ThongTinChiTietPhongThietBi
AS
SELECT ptb.MaPhong, 
	p.TenPhong, 
	p.TinhTrang AS TinhTrangPhong, 
	ptb.MaTB, 
	tb.TenTB, 
	tb.TinhTrang AS TinhTrangTB, 
	SoLuong AS SoLuongThietBi
FROM Phong_ThietBi ptb
JOIN Phong p ON ptb.MaPhong = p.MaPhong
JOIN ThietBi tb ON ptb.MaTB = tb.MaTB
GO

-- CHỨC NĂNG PHỤ --
DROP FUNCTION IF EXISTS fn_LayPhongQuaThietBi
GO
CREATE FUNCTION fn_LayPhongQuaThietBi(@MaTB CHAR(10))
RETURNS TABLE
AS
RETURN
(
	SELECT ptb.MaPhong, p.TenPhong
	FROM Phong_ThietBi ptb
	JOIN Phong p ON ptb.MaPhong = p.MaPhong
	WHERE ptb.MaTB = @MaTB
);
GO

--- CÁC CHỨC NĂNG CHO YÊU CẦU BẢO TRÌ ---
DROP VIEW IF EXISTS v_YeuCauBaoTri
GO
CREATE VIEW v_YeuCauBaoTri
AS
SELECT 
    ycbt.MaYC, 
    ycbt.TenTK, 
    ycbt.NgayYC, 
    ycbt.NoiDung, 
    ycbt.TrangThai, 
    ycbtp.MaPhong, 
    ycbttb.MaTB,
	ycbttb.MaPhong AS MaPhongThietBi
FROM YeuCauBaoTri ycbt
LEFT JOIN YeuCauBaoTriPhong ycbtp ON ycbt.MaYC = ycbtp.MaYC
LEFT JOIN YeuCauBaoTriThietBi ycbttb ON ycbt.MaYC = ycbttb.MaYC;
GO

DROP PROC IF EXISTS sp_TaoYeuCauBaoTri;
GO
CREATE PROCEDURE sp_TaoYeuCauBaoTri
    @TenTK NVARCHAR(20),
    @NgayYC DATE,
    @NoiDung NVARCHAR(255),
    @MaPhong CHAR(10),
    @MaTB CHAR(10)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Nếu NgayYC không nhập thì gán ngày hiện tại
        IF @NgayYC IS NULL
            SET @NgayYC = GETDATE();
		IF @NoiDung IS NULL
		BEGIN
			RAISERROR(N'Nội dung của yêu cầu bảo trì không được để trống!', 16, 1);
		END
        -- Kiểm tra dữ liệu đầu vào
        IF (@MaPhong IS NULL AND @MaTB IS NULL)
        BEGIN
            RAISERROR (N'Phải nhập ít nhất Mã Phòng hoặc Mã Thiết Bị.', 16, 1);
        END;

		IF (@MaTB IS NOT NULL AND @MaPhong IS NULL)
		BEGIN
			RAISERROR (N'Phải nhập chính xác phòng mà thiết bị thuộc về!', 16, 1);
		END;

        IF (@MaPhong IS NOT NULL AND @MaTB IS NOT NULL)
        BEGIN
            -- Nếu nhập cả 2 thì phải tồn tại trong bảng Phong_ThietBi
            IF NOT EXISTS (
                SELECT 1 FROM Phong_ThietBi 
                WHERE MaPhong = @MaPhong AND MaTB = @MaTB
            )
            BEGIN
                RAISERROR (N'Thiết bị này không tồn tại trong phòng đã chọn.', 16, 1);
            END
        END;

        -- Sinh mã mới YCxxx
        DECLARE @NewID CHAR(10);
        SELECT @NewID = 'YC' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaYC, 3, 10) AS INT)), 0) + 1 AS VARCHAR(10)), 3)
        FROM YeuCauBaoTri;

        -- Insert vào bảng cha
        INSERT INTO YeuCauBaoTri (MaYC, TenTK, NgayYC, NoiDung, TrangThai)
        VALUES (@NewID, @TenTK, @NgayYC, @NoiDung, N'Đang xử lý');

        -- Insert vào bảng con
        IF (@MaPhong IS NOT NULL AND @MaTB IS NULL)
        BEGIN
            INSERT INTO YeuCauBaoTriPhong (MaYC, MaPhong)
            VALUES (@NewID, @MaPhong);
        END
        ELSE IF (@MaPhong IS NOT NULL AND @MaTB IS NOT NULL)
        BEGIN
            INSERT INTO YeuCauBaoTriThietBi (MaYC, MaTB, MaPhong)
            VALUES (@NewID, @MaTB, @MaPhong);
        END
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

DROP PROC IF EXISTS sp_PheDuyetYeuCau
GO
CREATE PROC sp_PheDuyetYeuCau
    @MaYC CHAR(10)
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRANSACTION;
	BEGIN TRY
		UPDATE YeuCauBaoTri
		SET TrangThai = N'Đã duyệt'
		WHERE MaYC = @MaYC;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO

DROP PROC sp_TuChoiYeuCau
GO
CREATE PROC sp_TuChoiYeuCau
    @MaYC CHAR(10)
AS
BEGIN
	BEGIN TRANSACTION;
	BEGIN TRY
		DELETE FROM YeuCauBaoTri
		WHERE MaYC = @MaYC;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO

DROP PROC IF EXISTS sp_SuaThongTinYeuCauBaoTri;
GO
CREATE PROC sp_SuaThongTinYeuCauBaoTri
    @MaYC CHAR(10),
    @NgayYC DATE,
    @NoiDung NVARCHAR(255),
    @TrangThai NCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;
    BEGIN TRY
        -- Cập nhật thông tin chính trong bảng YeuCauBaoTri
        UPDATE YeuCauBaoTri
        SET 
            NoiDung = @NoiDung,
            TrangThai = @TrangThai,
            NgayYC = @NgayYC
        WHERE MaYC = @MaYC;

        -- Kiểm tra có cập nhật được bản ghi không
        IF @@ROWCOUNT = 0
            THROW 50003, N'Mã yêu cầu không tồn tại.', 1;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Ném lại lỗi gốc để hiển thị ra ngoài
        THROW;
    END CATCH
END;
GO

-- DÀNH CHO USER
DROP PROC IF EXISTS sp_XemYeuCauBaoTriTheoUser 
GO
CREATE PROC sp_XemYeuCauBaoTriTheoUser 
	@TenTK NVARCHAR(20)
AS
BEGIN
	SELECT 
		ycbt.MaYC, 
		ycbt.TenTK, 
		ycbt.NgayYC, 
		ycbt.NoiDung, 
		ycbt.TrangThai, 
		ycbtp.MaPhong,	
		ycbttb.MaTB,
		ycbttb.MaPhong AS MaPhongThietBi
	FROM YeuCauBaoTri ycbt
	LEFT JOIN YeuCauBaoTriPhong ycbtp ON ycbt.MaYC = ycbtp.MaYC
	LEFT JOIN YeuCauBaoTriThietBi ycbttb ON ycbt.MaYC = ycbttb.MaYC
	WHERE ycbt.TenTK = @TenTK
END;
GO

DROP FUNCTION IF EXISTS fn_LocYeuCauBaoTriTheoTrangThai
GO
CREATE FUNCTION fn_LocYeuCauBaoTriTheoTrangThai(@TrangThai NCHAR(20))
RETURNS TABLE
AS
RETURN
(
	SELECT 
		ycbt.MaYC, 
		ycbt.TenTK, 
		ycbt.NgayYC, 
		ycbt.NoiDung, 
		ycbt.TrangThai, 
		ycbtp.MaPhong, 
		ycbttb.MaTB
	FROM YeuCauBaoTri ycbt
	LEFT JOIN YeuCauBaoTriPhong ycbtp ON ycbt.MaYC = ycbtp.MaYC
	LEFT JOIN YeuCauBaoTriThietBi ycbttb ON ycbt.MaYC = ycbttb.MaYC
	WHERE ycbt.TrangThai = @TrangThai
);
GO

DROP FUNCTION IF EXISTS fn_LocPhongTheoTinhTrang
GO
CREATE FUNCTION fn_LocPhongTheoTinhTrang(@TinhTrang NVARCHAR(20))
RETURNS TABLE
AS
RETURN
(
	SELECT p.MaPhong, p.TenPhong, p.TinhTrang
	FROM Phong p
	WHERE p.TinhTrang = @TinhTrang
);
GO

-- CÁC CHỨC NĂNG CHO BẢO TRÌ --
DROP VIEW IF EXISTS v_BaoTriPhong;
GO
CREATE VIEW v_BaoTriPhong
AS
SELECT 
    bt.MaBT,
	btp.MaPhong,
	p.TenPhong,
	bt.ChiPhi,
	bt.DonViThucHien,
	bt.NgayBT,
	bt.TrangThai
FROM BaoTri bt
JOIN BaoTriPhong btp ON bt.MaBT = btp.MaBT
JOIN Phong p ON btp.MaPhong = p.MaPhong
GO

DROP VIEW IF EXISTS v_BaoTriThietBi;
GO
CREATE VIEW v_BaoTriThietBi
AS
SELECT 
    bt.MaBT,
	bttb.MaTB,
	tb.TenTB,
	p.MaPhong,
	p.TenPhong,
	bt.ChiPhi,
	bt.DonViThucHien,
	bt.NgayBT,
	bt.TrangThai
FROM BaoTri bt
JOIN BaoTriThietBi bttb ON bt.MaBT = bttb.MaBT
JOIN ThietBi tb ON tb.MaTB = bttb.MaTB
JOIN Phong p ON bttb.MaPhong = p.MaPhong
GO

DROP PROC IF EXISTS sp_XoaBaoTriThietBiQuaSoNam
GO
CREATE PROCEDURE sp_XoaBaoTriThietBiQuaSoNam
    @SoNam INT
AS
BEGIN
    SET NOCOUNT ON;
	BEGIN TRANSACTION;
	BEGIN TRY
		DELETE FROM BaoTri
		WHERE NgayBT IS NOT NULL
		  AND NgayBT < DATEADD(YEAR, -@SoNam, GETDATE())
		  AND EXISTS (
			  SELECT 1 
			  FROM BaoTriThietBi bttb
			  WHERE bttb.MaBT = BaoTri.MaBT
		  );

		SELECT @@ROWCOUNT AS SoBanGhiDaXoa;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO

DROP PROC IF EXISTS sp_XoaBaoTriPhongQuaSoNam
GO
CREATE PROCEDURE sp_XoaBaoTriPhongQuaSoNam
    @SoNam INT
AS
BEGIN
    SET NOCOUNT ON;
	BEGIN TRANSACTION;
	BEGIN TRY
		DELETE FROM BaoTri
		WHERE NgayBT IS NOT NULL
		  AND NgayBT < DATEADD(YEAR, -@SoNam, GETDATE())
		  AND EXISTS (
			  SELECT 1 
			  FROM BaoTriPhong btp
			  WHERE btp.MaBT = BaoTri.MaBT
		  );

		SELECT @@ROWCOUNT AS SoBanGhiDaXoa;
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO

DROP PROC IF EXISTS sp_SuaThongTinBaoTri
GO
CREATE PROC sp_SuaThongTinBaoTri
	@MaBT CHAR(10),
	@NgayBT DATE NULL,
	@ChiPhi INT NULL,
	@DonViThucHien NVARCHAR(30) NULL,
	@TrangThai NCHAR(20)
AS
BEGIN
	BEGIN TRANSACTION;
	BEGIN TRY
		UPDATE BaoTri
		SET NgayBT = @NgayBT, ChiPhi = @ChiPhi, DonViThucHien = @DonViThucHien, TrangThai = @TrangThai
		WHERE MaBT = @MaBT
		COMMIT TRANSACTION;
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0
			ROLLBACK TRANSACTION;
		THROW;
	END CATCH
END;
GO