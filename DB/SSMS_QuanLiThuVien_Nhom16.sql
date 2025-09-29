USE QLThuVien;
GO
-- TẠO BẢNG
-- Bảng Tài khoản
DROP TABLE IF EXISTS TaiKhoan;
CREATE TABLE TaiKhoan (
    TenTK NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(100) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL CHECK (VaiTro IN ('admin', 'user', 'manager'))
);

-- Bảng Phòng
DROP TABLE IF EXISTS Phong;
CREATE TABLE Phong (
    MaPhong CHAR(10) CONSTRAINT PK_MaPhong PRIMARY KEY,
    TenPhong NVARCHAR(30) NOT NULL,
    LoaiPhong NVARCHAR(10) NOT NULL,
    SucChua INT CONSTRAINT CHECK_SucChua CHECK(SucChua > 0),
    TinhTrang NCHAR(20) DEFAULT N'Hoạt động'
);

-- Bảng Thiết Bị
DROP TABLE IF EXISTS ThietBi;
CREATE TABLE ThietBi (    
    MaTB CHAR(10) CONSTRAINT PK_MaTB PRIMARY KEY,
    TenTB NVARCHAR(30) NOT NULL,
    LoaiTB NVARCHAR(10) NOT NULL,
    NgayMua DATE,
    TinhTrang NCHAR(20) DEFAULT N'Đang dùng'
);

-- Liên kết Phòng - Thiết bị
DROP TABLE IF EXISTS Phong_ThietBi;
CREATE TABLE Phong_ThietBi (
    MaPhong CHAR(10),
    MaTB CHAR(10),
    SoLuong INT CONSTRAINT CHECK_SoLuong CHECK(SoLuong > 0),
    CONSTRAINT PK_MaPhong_MaTB PRIMARY KEY (MaPhong, MaTB),
    CONSTRAINT FK_MaPhong_PTB FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_MaTB_PTB FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Bảng Yêu cầu bảo trì
DROP TABLE IF EXISTS YeuCauBaoTri;
CREATE TABLE YeuCauBaoTri (
    MaYC CHAR(10) CONSTRAINT PK_MaYC PRIMARY KEY,
    TenTK NVARCHAR(50),
    NgayYC DATE NULL,
    NoiDung NVARCHAR(255) NULL,
    TrangThai NVARCHAR(30) DEFAULT N'Đang xử lý',
    CONSTRAINT FK_TenTK FOREIGN KEY (TenTK) REFERENCES TaiKhoan(TenTK) ON DELETE CASCADE ON UPDATE CASCADE,
);

DROP TABLE IF EXISTS YeuCauBaoTriPhong
CREATE TABLE YeuCauBaoTriPhong (
    MaYC CHAR(10) CONSTRAINT PK_MaYC_Phong PRIMARY KEY,
	MaPhong CHAR(10) NOT NULL,
	CONSTRAINT FK_MaYC_Phong FOREIGN KEY (MaYC) REFERENCES YeuCauBaoTri(MaYC) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_YC_Phong FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON UPDATE CASCADE
);

DROP TABLE IF EXISTS YeuCauBaoTriThietBi
CREATE TABLE YeuCauBaoTriThietBi (
    MaYC CHAR(10) CONSTRAINT PK_MaYC_ThietBi PRIMARY KEY,
	MaTB CHAR(10) NOT NULL,
	CONSTRAINT FK_MaYC_ThietBi FOREIGN KEY (MaYC) REFERENCES YeuCauBaoTri(MaYC) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_YC_ThietBi FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB) ON UPDATE CASCADE
);

-- Bảng Bảo trì
DROP TABLE IF EXISTS BaoTri;
CREATE TABLE BaoTri (
    MaBT CHAR(10) CONSTRAINT PK_MaBT PRIMARY KEY,
    NgayBT DATE NULL,
    ChiPhi INT NULL CONSTRAINT CHECK_ChiPhi CHECK(ChiPhi > 0),
    DonViThucHien NVARCHAR(50) NULL,
    MaYC CHAR(10) NOT NULL,
    TrangThai NVARCHAR(30) DEFAULT N'Chưa bắt đầu',
    CONSTRAINT FK_BaoTri_YeuCau FOREIGN KEY (MaYC) 
        REFERENCES YeuCauBaoTri(MaYC) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);

-- Bảo trì - Phòng
DROP TABLE IF EXISTS BaoTri_Phong;
CREATE TABLE BaoTri_Phong (
    MaBT CHAR(10),
    MaPhong CHAR(10),
    CONSTRAINT PK_MaBT_MaPhong PRIMARY KEY (MaBT, MaPhong),
    CONSTRAINT FK_MaPhong_BTP FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    CONSTRAINT FK_MaBT_BTP FOREIGN KEY (MaBT) REFERENCES BaoTri(MaBT) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Bảo trì - Thiết bị
DROP TABLE IF EXISTS BaoTri_ThietBi;
CREATE TABLE BaoTri_ThietBi (
    MaBT CHAR(10),
    MaTB CHAR(10),
    CONSTRAINT PK_MaBT_MaTB PRIMARY KEY (MaBT, MaTB),
    CONSTRAINT FK_MaTB_BTTB FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB),
    CONSTRAINT FK_MaBT_BTTB FOREIGN KEY (MaBT) REFERENCES BaoTri(MaBT) ON DELETE CASCADE ON UPDATE CASCADE
);

--THÊM DỮ LIỆU MẪU
INSERT INTO TaiKhoan (TenTK, MatKhau, VaiTro)
VALUES 
('admin1', 'Admin@123', 'admin'),
('manager1', 'Manager@123', 'manager'),
('user1', 'User@123', 'user');

DROP PROC IF EXISTS sp_LayDanhSachYeuCauTheoRole
GO
CREATE PROC sp_LayDanhSachYeuCauTheoRole
	@TenTK NVARCHAR(20)
AS
BEGIN
	SELECT ycbt.MaYC, ycbt.TenTK, ycbt.NgayYC, ycbt.NoiDung, ycbt.TrangThai
	FROM YeuCauBaoTri ycbt
	JOIN TaiKhoan tk ON ycbt.TenTK = tk.TenTK
	WHERE tk.TenTK = @TenTK
END;

EXEC sp_LayDanhSachYeuCauTheoRole 'admin'

INSERT INTO Phong (MaPhong, TenPhong, LoaiPhong, SucChua, TinhTrang) VALUES
('P001', N'Phòng Máy 1', N'Máy tính', 40, N'Đang dùng'),
('P002', N'Phòng Máy 2', N'Máy tính', 35, N'Bảo trì'),
('P003', N'Phòng Máy 3', N'Máy tính', 50, N'Cũ'),
('P004', N'Phòng Đọc 1', N'Đọc sách', 80, N'Đang dùng'),
('P005', N'Phòng Đọc 2', N'Đọc sách', 90, N'Đang dùng'),
('P006', N'Phòng Đọc 3', N'Đọc sách', 70, N'Bảo trì'),
('P007', N'Quầy Mượn trả 1', N'Mượn trả', 15, N'Đang dùng'),
('P008', N'Quầy Mượn trả 2', N'Mượn trả', 20, N'Cũ'),
('P009', N'Kho Sách 1', N'Kho', 200, N'Đang dùng'),
('P010', N'Kho Sách 2', N'Kho', 250, N'Bảo trì'),
('P011', N'Kho Sách 3', N'Kho', 300, N'Cũ'),
('P012', N'Phòng Làm việc 1', N'Làm việc', 25, N'Đang dùng'),
('P013', N'Phòng Làm việc 2', N'Làm việc', 30, N'Đang dùng'),
('P014', N'Phòng Làm việc 3', N'Làm việc', 18, N'Cũ'),
('P015', N'Phòng In ấn 1', N'In ấn', 10, N'Đang dùng'),
('P016', N'Phòng In ấn 2', N'In ấn', 8, N'Bảo trì'),
('P017', N'Phòng In ấn 3', N'In ấn', 12, N'Đang dùng'),
('P018', N'Phòng Đọc 4', N'Đọc sách', 85, N'Cũ'),
('P019', N'Phòng Máy 4', N'Máy tính', 45, N'Đang dùng'),
('P020', N'Kho Sách 4', N'Kho', 280, N'Đang dùng');

INSERT INTO ThietBi (MaTB, TenTB, LoaiTB, NgayMua, TinhTrang) VALUES
('TB001', N'Router A', N'Mạng', '2019-05-10', N'Đang dùng'),
('TB002', N'Switch B', N'Mạng', '2020-08-15', N'Cũ'),
('TB003', N'Access Point C', N'Mạng', '2021-03-20', N'Bảo trì'),
('TB004', N'Máy tính Dell', N'Công nghệ', '2020-01-11', N'Đang dùng'),
('TB005', N'Máy tính HP', N'Công nghệ', '2018-06-22', N'Cũ'),
('TB006', N'Máy chủ IBM', N'Công nghệ', '2021-09-30', N'Đang dùng'),
('TB007', N'Loa Hội trường 1', N'Âm thanh', '2020-04-10', N'Đang dùng'),
('TB008', N'Loa Hội trường 2', N'Âm thanh', '2017-07-18', N'Cũ'),
('TB009', N'Micro Không dây', N'Âm thanh', '2019-11-25', N'Bảo trì'),
('TB010', N'Hệ thống Mixer', N'Âm thanh', '2022-02-02', N'Đang dùng'),
('TB011', N'Máy in HP1', N'In', '2020-05-20', N'Đang dùng'),
('TB012', N'Máy in Canon', N'In', '2018-10-14', N'Cũ'),
('TB013', N'Máy photocopy Ricoh', N'In', '2019-12-12', N'Bảo trì'),
('TB014', N'Máy scan Epson', N'In', '2021-06-06', N'Đang dùng'),
('TB015', N'Máy tính Acer', N'Công nghệ', '2019-01-01', N'Đang dùng'),
('TB016', N'Máy chủ Dell', N'Công nghệ', '2018-11-11', N'Cũ'),
('TB017', N'Router D', N'Mạng', '2020-03-03', N'Đang dùng'),
('TB018', N'Micro Hội thảo', N'Âm thanh', '2022-09-09', N'Đang dùng'),
('TB019', N'Máy in Brother', N'In', '2021-12-12', N'Bảo trì'),
('TB020', N'Switch Cisco', N'Mạng', '2019-08-08', N'Cũ');

-- Bảng Phong_ThietBi
INSERT INTO Phong_ThietBi (MaPhong, MaTB, SoLuong) VALUES
('P001', 'TB001', 20), -- Phòng máy tính có 20 máy tính
('P001', 'TB002', 2),  -- Switch mạng
('P001', 'TB003', 1),  -- UPS
('P001', 'TB004', 1),  -- Router
('P002', 'TB005', 30), -- Phòng đọc sách có 30 bàn đọc
('P002', 'TB010', 2),  -- Loa
('P002', 'TB011', 1),  -- Máy chiếu
('P003', 'TB016', 3),  -- Máy in
('P003', 'TB017', 2),  -- Máy scan
('P003', 'TB018', 2),  -- Camera
('P004', 'TB001', 10), -- Máy tính phòng làm việc
('P004', 'TB002', 1),  -- Switch
('P004', 'TB010', 1),  -- Loa
('P005', 'TB005', 15), -- Phòng mượn trả có bàn giao dịch
('P005', 'TB019', 2),  -- Máy quét mã vạch
('P005', 'TB018', 1),  -- Camera
('P006', 'TB010', 4),  -- Phòng hội trường có loa
('P006', 'TB011', 1),  -- Máy chiếu
('P006', 'TB012', 2),  -- Micro không dây
('P007', 'TB001', 5),
('P007', 'TB002', 1),
('P008', 'TB016', 2),
('P008', 'TB017', 1),
('P009', 'TB005', 20),
('P009', 'TB010', 2),
('P010', 'TB018', 3),
('P010', 'TB019', 2),
('P011', 'TB001', 10),
('P011', 'TB002', 2),
('P012', 'TB016', 1),
('P012', 'TB017', 1),
('P013', 'TB005', 12),
('P013', 'TB010', 2),
('P014', 'TB018', 3),
('P014', 'TB019', 1),
('P015', 'TB001', 8),
('P015', 'TB003', 1),
('P016', 'TB016', 2),
('P016', 'TB017', 1),
('P017', 'TB005', 25),
('P017', 'TB010', 2),
('P018', 'TB018', 2),
('P018', 'TB019', 1),
('P019', 'TB001', 12),
('P019', 'TB002', 2),
('P020', 'TB016', 1),
('P020', 'TB017', 1);

DELETE FROM YeuCauBaoTri
-- Bảng YeuCauBaoTri
INSERT INTO YeuCauBaoTri (MaYC, TenTK, NgayYC, NoiDung, TrangThai)
VALUES
('YC001', 'admin', '2023-01-15', N'Sửa điều hòa phòng máy tính', N'Đã hoàn thành'),
('YC002', 'user1', '2023-02-10', N'Thay bóng đèn phòng đọc sách', N'Đã hoàn thành'),
('YC003', 'admin', '2023-03-05', N'Sửa máy in HP', N'Đã hoàn thành'),
('YC004', 'user1', '2023-04-20', N'Bảo trì hệ thống mạng', N'Đã hoàn thành'),
('YC005', 'admin', '2023-05-12', N'Sửa ghế phòng làm việc', N'Đã hoàn thành'),
('YC006', 'user1', '2023-06-18', N'Kiểm tra thiết bị âm thanh hội trường', N'Đã hoàn thành'),
('YC007', 'admin', '2023-07-22', N'Thay RAM máy tính phòng lab', N'Đã hoàn thành'),
('YC008', 'user1', '2023-08-10', N'Bảo trì camera an ninh', N'Đã hoàn thành'),
('YC009', 'admin', '2023-09-03', N'Thay pin UPS hệ thống mạng', N'Đã hoàn thành'),
('YC010', 'user1', '2023-10-15', N'Bảo trì máy photocopy', N'Đã hoàn thành'),
('YC011', 'admin', '2024-01-08', N'Sửa bàn học phòng đọc sách', N'Đã hoàn thành'),
('YC012', 'user1', '2024-02-14', N'Kiểm tra máy chiếu hội trường', N'Đã hoàn thành'),
('YC013', 'admin', '2024-03-11', N'Thay dây mạng switch tầng 3', N'Đã hoàn thành'),
('YC014', 'user1', '2024-04-21', N'Sửa máy tính bị lỗi mainboard', N'Đã hoàn thành'),
('YC015', 'admin', '2024-05-19', N'Thay pin laptop thư viện', N'Đã hoàn thành'),
('YC016', 'user1', '2024-06-25', N'Bảo trì máy quét mã vạch', N'Đã hoàn thành'),
('YC017', 'admin', '2025-01-12', N'Bảo trì loa hội trường', N'Đã hoàn thành'),
('YC018', 'user1', '2025-02-05', N'Kiểm tra máy in Canon', N'Đã hoàn thành'),
('YC019', 'admin', '2025-03-15', N'Bảo trì switch mạng core', N'Đã hoàn thành'),
('YC020', 'user1', '2025-04-01', N'Sửa máy tính phòng nhân viên', N'Đã hoàn thành');

-- Bảng YeuCauBaoTriPhong
INSERT INTO YeuCauBaoTriPhong (MaYC, MaPhong)
VALUES
('YC001', 'P001'),
('YC002', 'P002'),
('YC005', 'P005'),
('YC007', 'P001'),
('YC011', 'P002'),
('YC014', 'P001'),
('YC015', 'P004'),
('YC017', 'P006'),
('YC020', 'P004'),
('YC012', 'P006');

-- Bảng YeuCauBaoTriThietBi
INSERT INTO YeuCauBaoTriThietBi (MaYC, MaTB)
VALUES
('YC003', 'TB015'),
('YC004', 'TB001'),
('YC006', 'TB010'),
('YC008', 'TB018'),
('YC009', 'TB003'),
('YC010', 'TB016'),
('YC013', 'TB002'),
('YC016', 'TB019'),
('YC018', 'TB017'),
('YC019', 'TB003');

-- Dữ liệu mẫu Bảo trì
INSERT INTO BaoTri (MaBT, NgayBT, ChiPhi, DonViThucHien, MaYC, TrangThai) VALUES
('BT001', '2021-03-15', 1500000, N'Công ty IT HN', 'YC001', N'Hoàn thành'),
('BT002', '2021-06-20', 2500000, N'Công ty Mạng VN', 'YC002', N'Hoàn thành'),
('BT003', '2021-09-05', 1200000, N'FPT Service', 'YC003', N'Hoàn thành'),
('BT004', '2022-01-18', 3000000, N'Công ty Điện máy A', 'YC004', N'Hoàn thành'),
('BT005', '2022-04-10', 800000, N'Công ty Điện tử B', 'YC005', N'Hoàn thành'),
('BT006', '2022-07-12', 2200000, N'Công ty In ấn HN', 'YC006', N'Hoàn thành'),
('BT007', '2022-10-25', 1500000, N'Công ty Thiết bị TL', 'YC007', N'Đang thực hiện'),
('BT008', '2023-02-14', 2700000, N'Công ty IT SG', 'YC008', N'Hoàn thành'),
('BT009', '2023-05-22', 3200000, N'Công ty Âm thanh Việt', 'YC009', N'Hoàn thành'),
('BT010', '2023-08-30', 1400000, N'Công ty Mạng HN', 'YC010', N'Chưa bắt đầu'),
('BT011', '2023-11-10', 900000, N'Công ty Điện máy C', 'YC011', N'Hoàn thành'),
('BT012', '2024-01-05', 2000000, N'Công ty IT SG', 'YC012', N'Hoàn thành'),
('BT013', '2024-03-18', 2800000, N'Công ty Thiết bị TL', 'YC013', N'Đang thực hiện'),
('BT014', '2024-06-25', 3500000, N'Công ty Mạng VN', 'YC014', N'Hoàn thành'),
('BT015', '2024-09-12', 1800000, N'Công ty In ấn HN', 'YC015', N'Hoàn thành'),
('BT016', '2024-12-20', 2400000, N'Công ty Âm thanh Việt', 'YC016', N'Hoàn thành'),
('BT017', '2025-02-11', 4100000, N'Công ty IT HN', 'YC017', N'Đang thực hiện'),
('BT018', '2025-04-15', 2900000, N'Công ty Điện tử B', 'YC018', N'Hoàn thành'),
('BT019', '2025-06-21', 1600000, N'Công ty Mạng HN', 'YC019', N'Hoàn thành'),
('BT020', '2025-09-05', 5000000, N'Công ty Thiết bị TL', 'YC020', N'Chưa bắt đầu');

-- Bảo trì Phòng
INSERT INTO BaoTri_Phong (MaBT, MaPhong) VALUES
('BT001', 'P001'),
('BT004', 'P002'),
('BT006', 'P003'),
('BT008', 'P005'),
('BT010', 'P006'),
('BT012', 'P009'),
('BT014', 'P013'),
('BT015', 'P017'),
('BT018', 'P019'),
('BT020', 'P020');

-- Bảo trì Thiết bị
INSERT INTO BaoTri_ThietBi (MaBT, MaTB) VALUES
('BT002', 'TB001'),
('BT003', 'TB002'),
('BT005', 'TB010'),
('BT007', 'TB016'),
('BT009', 'TB011'),
('BT011', 'TB018'),
('BT013', 'TB017'),
('BT016', 'TB019'),
('BT017', 'TB004'),
('BT019', 'TB003');


GO
USE QLThuVien;
GO

-- Xóa user trong DB trước
DROP USER IF EXISTS admin1;
DROP USER IF EXISTS manager1;
DROP USER IF EXISTS user1;
GO

-- Xóa login ở server
GO
DROP LOGIN admin1;
DROP LOGIN manager1;
DROP LOGIN user1;
GO

-- Xóa các role cũ trong DB
GO
DROP ROLE IF EXISTS AdminRole;
DROP ROLE IF EXISTS ManagerRole;
DROP ROLE IF EXISTS UserRole;
GO

GO
CREATE ROLE AdminRole;
CREATE ROLE ManagerRole;
CREATE ROLE UserRole;
GO

EXEC sp_addrolemember 'db_owner', 'AdminRole';

-- Cho phép CRUD tất cả bảng trong schema dbo
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO ManagerRole;

-- Cho phép thực thi tất cả stored procedure và function
GRANT EXECUTE ON SCHEMA::dbo TO ManagerRole;

-- Cho phép xem view
GRANT SELECT ON SCHEMA::dbo TO ManagerRole;

-- Hạn chế: không cho phép thay đổi cấu trúc schema
DENY ALTER, CONTROL, REFERENCES ON SCHEMA::dbo TO ManagerRole;


-- Quyền CRUD chỉ trên các bảng yêu cầu
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.YeuCauBaoTri TO UserRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.YeuCauBaoTriPhong TO UserRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.YeuCauBaoTriThietBi TO UserRole;

-- Cho phép thực thi tất cả stored procedure & function trong schema dbo
GRANT SELECT ON OBJECT::dbo.v_LayTatCaPhong TO UserRole;
GRANT SELECT ON OBJECT::dbo.v_LayTatCaThietBi TO UserRole;
GRANT SELECT ON OBJECT::dbo.v_ThongTinChiTietPhongThietBi TO UserRole;	

GRANT EXECUTE ON OBJECT::dbo.sp_XemRole TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_KiemTraDangNhap TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_XemYeuCauBaoTriTheoUser TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_SuaThongTinYeuCauBaoTri TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_LocPhongTheoTinhTrang TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_LocThietBiTheoTinhTrang TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_TuChoiYeuCau TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_TaoYeuCauBaoTri TO UserRole;

-- Chặn quyền trên các bảng khác
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.TaiKhoan TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.Phong TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.ThietBi TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.Phong_ThietBi TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.BaoTri TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.BaoTri_Phong TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.BaoTri_ThietBi TO UserRole;

-- Admin
CREATE LOGIN admin1 WITH PASSWORD = 'Admin@123';
CREATE USER admin1 FOR LOGIN admin1;
EXEC sp_addrolemember 'AdminRole', 'admin1';

-- Manager
CREATE LOGIN manager1 WITH PASSWORD = 'Manager@123';
CREATE USER manager1 FOR LOGIN manager1;
EXEC sp_addrolemember 'ManagerRole', 'manager1';

-- User
CREATE LOGIN user1 WITH PASSWORD = 'User@123';
CREATE USER user1 FOR LOGIN user1;
EXEC sp_addrolemember 'UserRole', 'user1';

-- Đang login bằng ai
SELECT SUSER_NAME() AS LoginName, USER_NAME() AS DbUser;

-- Xem danh sách user và role trong DB
EXEC sp_helpuser;

SELECT name, schema_name(schema_id) as SchemaName, type_desc
FROM sys.objects
WHERE type IN ('P','FN','IF','TF','V');

GO
CREATE PROC sp_XemRole
AS
BEGIN
	SELECT dp.name AS DbUser,
		   dp.type_desc AS UserType,
		   drp.role_principal_id,
		   dr.name AS DbRole
	FROM sys.database_principals dp
	LEFT JOIN sys.database_role_members drp ON dp.principal_id = drp.member_principal_id
	LEFT JOIN sys.database_principals dr ON dr.principal_id = drp.role_principal_id
	WHERE dp.name = USER_NAME();
END;
GO

-- TRIGGER --
DROP TRIGGER IF EXISTS trg_CheckSoLuongThietBi
GO
CREATE TRIGGER trg_CheckSoLuongThietBi
ON Phong_ThietBi
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM Phong_ThietBi
        WHERE SoLuong <= 0
    )
    BEGIN
        RAISERROR(N'Số lượng thiết bị phải > 0', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

-- PROC Tài khoản --
GO
CREATE PROC sp_KiemTraDangNhap 
	@TenTK NVARCHAR(50),
	@MatKhau NVARCHAR(100)
AS 
BEGIN
	SELECT *
	FROM TaiKhoan
	WHERE TenTK = @TenTK AND MatKhau = @MatKhau
END;

-- VIEW PHÒNG --
GO
CREATE VIEW v_LayTatCaPhong
AS
SELECT * FROM Phong;


-- PROC PHÒNG --
GO
CREATE PROC sp_SoLuongPhongTheoLoai
AS 
BEGIN
	SELECT LoaiPhong, COUNT(*) AS SoLuong
	FROM Phong
	GROUP BY LoaiPhong
END;

GO
CREATE OR ALTER PROCEDURE sp_SoLuongThietBiTheoTinhTrang
AS
BEGIN
    SELECT tb.TinhTrang, SUM(ptb.SoLuong) AS SoLuong
    FROM ThietBi tb
    INNER JOIN Phong_ThietBi ptb ON tb.MaTB = ptb.MaTB
    GROUP BY tb.TinhTrang;
END;

GO
CREATE PROCEDURE sp_BaoTriTheoNam
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

GO
CREATE PROCEDURE sp_ChiPhiBaoTriTheoThang
AS
BEGIN
    SELECT MONTH(NgayBT) AS Thang, SUM(ChiPhi) AS TongChiPhi
    FROM BaoTri
    GROUP BY MONTH(NgayBT);
END;

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
    JOIN BaoTri_Phong btp ON bt.MaBT = btp.MaBT
    JOIN Phong p ON btp.MaPhong = p.MaPhong
    WHERE YEAR(bt.NgayBT) = @Nam
    GROUP BY p.MaPhong, p.TenPhong, MONTH(bt.NgayBT)
    ORDER BY p.MaPhong, Thang;
END;

GO
CREATE PROCEDURE sp_ThemPhong
    @TenPhong NVARCHAR(30),
    @LoaiPhong NVARCHAR(10),
    @SucChua INT,
    @TinhTrang NCHAR(10)
AS
BEGIN
    DECLARE @NextMaPhong CHAR(10);

    -- Lấy số lớn nhất trong mã phòng hiện có, cộng thêm 1
    SELECT @NextMaPhong = 'P' + RIGHT('000' + 
                        CAST(ISNULL(MAX(CAST(SUBSTRING(MaPhong, 2, LEN(MaPhong)) AS INT)), 0) + 1 AS VARCHAR), 3)
    FROM Phong;

    INSERT INTO Phong(MaPhong, TenPhong, LoaiPhong, SucChua, TinhTrang)
    VALUES (@NextMaPhong, @TenPhong, @LoaiPhong, @SucChua, @TinhTrang);
END;
GO

CREATE PROCEDURE sp_SuaPhong
    @MaPhong CHAR(10),
    @TenPhong NVARCHAR(30),
    @LoaiPhong NVARCHAR(10),
    @SucChua INT,
    @TinhTrang NCHAR(10)
AS
BEGIN
    FROM Phong;
    UPDATE Phong
    SET TenPhong = @TenPhong,
        LoaiPhong = @LoaiPhong,
        SucChua = @SucChua,
        TinhTrang = @TinhTrang
    WHERE MaPhong = @MaPhong;
END;

DROP PROC IF EXISTS sp_XoaPhong
GO 
CREATE PROCEDURE sp_XoaPhong
    @MaPhong CHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM BaoTri_Phong WHERE MaPhong = @MaPhong;
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
CREATE PROCEDURE sp_TimPhong
    @Keyword NVARCHAR(50)
AS
BEGIN
    SELECT * 
    FROM Phong
    WHERE MaPhong LIKE '%' + @Keyword + '%'
       OR TenPhong LIKE '%' + @Keyword + '%';
END

GO
CREATE PROC sp_LayPhongQuaMaPhong @MaPhong CHAR(10)
AS
BEGIN
	SELECT *
	FROM Phong
	WHERE MaPhong = @MaPhong
END;

GO
CREATE PROCEDURE sp_LocPhong
    @LoaiPhong NVARCHAR(50) = NULL,
    @TinhTrang NVARCHAR(50) = NULL
AS
BEGIN
    SELECT *
    FROM Phong
    WHERE (@LoaiPhong IS NULL OR LoaiPhong = @LoaiPhong)
      AND (@TinhTrang IS NULL OR TinhTrang = @TinhTrang);
END

-- VIEW THIẾT BỊ --
GO
CREATE VIEW v_LayTatCaThietBi
AS
SELECT * FROM ThietBi;

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
-- PROC THIẾT BỊ --
GO
CREATE PROCEDURE sp_ThemThietBi
    @TenTB NVARCHAR(30),
    @LoaiTB NVARCHAR(10),
    @NgayMua DATE,
    @TinhTrang NCHAR(10)
AS
BEGIN
    DECLARE @NextMaTB CHAR(10);

    -- Sinh mã mới dạng TB001, TB002...
    SELECT @NextMaTB = 'TB' + RIGHT('000' +
                        CAST(ISNULL(MAX(CAST(SUBSTRING(MaTB, 3, LEN(MaTB)) AS INT)), 0) + 1 AS VARCHAR), 3)
    FROM ThietBi;

    INSERT INTO ThietBi (MaTB, TenTB, LoaiTB, NgayMua, TinhTrang)
    VALUES (@NextMaTB, @TenTB, @LoaiTB, @NgayMua, @TinhTrang);
END;

CREATE PROCEDURE sp_SuaThietBi
    @MaTB CHAR(10),
    @TenTB NVARCHAR(30),
    @LoaiTB NVARCHAR(10),
    @NgayMua DATE,
    @TinhTrang NCHAR(10)
AS
BEGIN
    UPDATE ThietBi
    SET TenTB = @TenTB,
        LoaiTB = @LoaiTB,
        NgayMua = @NgayMua,
        TinhTrang = @TinhTrang
    WHERE MaTB = @MaTB;
END
GO

CREATE PROCEDURE sp_XoaThietBi
    @MaTB CHAR(10)
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        DELETE FROM BaoTri_ThietBi WHERE MaTB = @MaTB;
        DELETE FROM Phong_ThietBi WHERE MaTB = @MaTB;
        DELETE FROM ThietBi WHERE MaTB = @MaTB;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;

GO
CREATE PROCEDURE sp_TimThietBi
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM ThietBi
    WHERE MaTB LIKE '%' + @Keyword + '%'
       OR TenTB LIKE '%' + @Keyword + '%'
       OR LoaiTB LIKE '%' + @Keyword + '%'
       OR TinhTrang LIKE '%' + @Keyword + '%';
END

GO
CREATE PROC sp_LayThietBiQuaMaThietBi 
@MaTB CHAR(10)
AS
BEGIN
	SELECT *
	FROM ThietBi
	WHERE MaTB = @MaTB
END;

GO
CREATE PROC sp_LayThietBiTheoTinhTrang @TinhTrang NCHAR(10)
AS
BEGIN
	SELECT *
	FROM ThietBi
	WHERE TinhTrang = @TinhTrang
END;

GO
CREATE PROCEDURE sp_LocThietBi
    @FromDate DATE,
    @ToDate DATE,
    @TinhTrang NVARCHAR(20)
AS
BEGIN
    SELECT *
    FROM ThietBi
    WHERE NgayMua BETWEEN @FromDate AND @ToDate
      AND (@TinhTrang = N'Tất cả' OR TinhTrang = @TinhTrang);
END

GO
CREATE PROC sp_ThemThietBiVaoPhong
    @MaPhong NVARCHAR(50),
    @MaTB NVARCHAR(50),
    @SoLuong INT
AS
BEGIN
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
END;

GO
CREATE PROC sp_SuaSoLuongThietBiTrongPhong
    @MaPhong NVARCHAR(50),
    @MaTB NVARCHAR(50),
    @SoLuong INT
AS
BEGIN
    UPDATE Phong_ThietBi
    SET SoLuong = @SoLuong
    WHERE MaPhong = @MaPhong AND MaTB = @MaTB;
END;

GO
CREATE PROC sp_XoaThietBiKhoiPhong
    @MaPhong NVARCHAR(50),
    @MaTB NVARCHAR(50)
AS
BEGIN
    DELETE FROM Phong_ThietBi
    WHERE MaPhong = @MaPhong AND MaTB = @MaTB;
END;

-- VIEW BẢO TRÌ --
DROP VIEW IF EXISTS v_BaoTriPhong;
GO
CREATE VIEW v_BaoTriPhong
AS
SELECT 
    bt.MaBT,
	ycbtp.MaPhong,
	p.TenPhong,
	bt.ChiPhi,
	bt.DonViThucHien,
	bt.NgayBT,
	bt.TrangThai
FROM BaoTri bt
JOIN YeuCauBaoTriPhong ycbtp ON bt.MaYC = ycbtp.MaYC
JOIN Phong p ON ycbtp.MaPhong = p.MaPhong
GO
SELECT * FROM v_BaoTriPhong;

DROP VIEW IF EXISTS v_BaoTriThietBi;
GO
CREATE VIEW v_BaoTriThietBi
AS
SELECT 
    bt.MaBT,
	ycbttb.MaTB,
	tb.TenTB,
	p.MaPhong,
	p.TenPhong,
	bt.ChiPhi,
	bt.DonViThucHien,
	bt.NgayBT,
	bt.TrangThai
FROM BaoTri bt
JOIN YeuCauBaoTriThietBi ycbttb ON bt.MaYC = ycbttb.MaYC
JOIN ThietBi tb ON tb.MaTB = ycbttb.MaTB
JOIN Phong_ThietBi ptb ON tb.MaTB = ptb.MaTB
JOIN Phong p ON ptb.MaPhong = p.MaPhong
GO
SELECT * FROM v_BaoTriThietBi

DROP VIEW IF EXISTS v_LayTatCaCacNamBaoTri
GO
CREATE VIEW v_LayTatCaCacNamBaoTri
AS
SELECT DISTINCT YEAR(NgayBT) AS NamBT FROM BaoTri
GO
SELECT * FROM v_LayTatCaCacNamBaoTri

--- TRIGGER BẢO TRÌ ---
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
CREATE PROCEDURE sp_XoaBaoTriThietBiQuaSoNam
    @SoNam INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM BaoTri
    WHERE NgayBT IS NOT NULL
      AND NgayBT < DATEADD(YEAR, -@SoNam, GETDATE())
      AND EXISTS (
          SELECT 1 
          FROM BaoTri_ThietBi bttb
          WHERE bttb.MaBT = BaoTri.MaBT
      );

    SELECT @@ROWCOUNT AS SoBanGhiDaXoa;
END;
GO

GO
CREATE PROCEDURE sp_XoaBaoTriPhongQuaSoNam
    @SoNam INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM BaoTri
    WHERE NgayBT IS NOT NULL
      AND NgayBT < DATEADD(YEAR, -@SoNam, GETDATE())
      AND EXISTS (
          SELECT 1 
          FROM BaoTri_Phong btp
          WHERE btp.MaBT = BaoTri.MaBT
      );

    SELECT @@ROWCOUNT AS SoBanGhiDaXoa;
END;
GO

--- VIEW YÊU CẦU BẢO TRÌ ---
DROP VIEW IF EXISTS v_YeuCauBaoTri;
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
    ycbttb.MaTB
FROM YeuCauBaoTri ycbt
LEFT JOIN YeuCauBaoTriPhong ycbtp ON ycbt.MaYC = ycbtp.MaYC
LEFT JOIN YeuCauBaoTriThietBi ycbttb ON ycbt.MaYC = ycbttb.MaYC;
GO

-- PROC YÊU CẦU BẢO TRÌ --
DROP PROC IF EXISTS sp_TaoYeuCauBaoTri;
GO
CREATE PROCEDURE sp_TaoYeuCauBaoTri
    @TenTK NVARCHAR(50),
    @NgayYC DATE,
    @NoiDung NVARCHAR(255) NULL,
    @MaPhong CHAR(10) = NULL,
    @MaTB CHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Nếu NgayYC không nhập thì gán ngày hiện tại
    IF @NgayYC IS NULL
        SET @NgayYC = GETDATE();

    -- Kiểm tra chỉ được nhập 1 trong 2: MaPhong hoặc MaTB
    IF (@MaPhong IS NOT NULL AND @MaTB IS NOT NULL)
    BEGIN
        RAISERROR (N'Chỉ được nhập Mã Phòng hoặc Mã Thiết Bị, không được cả hai.', 16, 1);
        RETURN;
    END;

    IF (@MaPhong IS NULL AND @MaTB IS NULL)
    BEGIN
        RAISERROR (N'Phải nhập Mã Phòng hoặc Mã Thiết Bị.', 16, 1);
        RETURN;
    END;

    -- Sinh mã mới YCxxx
    DECLARE @NewID CHAR(10);
    SELECT @NewID = 'YC' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MaYC, 3, 10) AS INT)), 0) + 1 AS VARCHAR(10)), 3)
    FROM YeuCauBaoTri;

    -- Insert vào bảng cha
    INSERT INTO YeuCauBaoTri (MaYC, TenTK, NgayYC, NoiDung, TrangThai)
    VALUES (@NewID, @TenTK, @NgayYC, @NoiDung, N'Đang xử lý');

    -- Insert vào bảng con
    IF @MaPhong IS NOT NULL
    BEGIN
        INSERT INTO YeuCauBaoTriPhong (MaYC, MaPhong)
        VALUES (@NewID, @MaPhong);
    END
    ELSE
    BEGIN
        INSERT INTO YeuCauBaoTriThietBi (MaYC, MaTB)
        VALUES (@NewID, @MaTB);
    END
END;

DROP TRIGGER IF EXISTS trg_TuDongThemBaoTriSauKhiPheDuyetYeuCau
GO
CREATE TRIGGER trg_TuDongThemBaoTriSauKhiPheDuyetYeuCau
ON YeuCauBaoTri
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Chỉ xử lý khi trạng thái đổi sang "Đã phê duyệt"
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN deleted d ON i.MaYC = d.MaYC
        WHERE i.TrangThai = N'Đã phê duyệt'
          AND d.TrangThai <> N'Đã phê duyệt'
    )
    BEGIN
        DECLARE @MaYC CHAR(10), @NewMaBT CHAR(10), @MaxNum INT;

        -- Lấy MaYC vừa được phê duyệt
        SELECT TOP 1 @MaYC = i.MaYC
        FROM inserted i
        JOIN deleted d ON i.MaYC = d.MaYC
        WHERE i.TrangThai = N'Đã phê duyệt'
          AND d.TrangThai <> N'Đã phê duyệt';

        -- Sinh mã BT mới
        SELECT @MaxNum = MAX(CAST(SUBSTRING(MaBT, 3, 3) AS INT))
        FROM BaoTri;

        SET @NewMaBT = 'BT' + RIGHT('000' + CAST(ISNULL(@MaxNum, 0) + 1 AS VARCHAR), 3);

        -- Thêm vào bảng Bảo trì
        INSERT INTO BaoTri(MaBT, MaYC, TrangThai, NgayBT)
        VALUES(@NewMaBT, @MaYC, N'Chưa bắt đầu', NULL);

        -------------------------------------------------
        -- Nếu là yêu cầu bảo trì Phòng
        -------------------------------------------------
        IF EXISTS (SELECT 1 FROM YeuCauBaoTriPhong WHERE MaYC = @MaYC)
        BEGIN
            INSERT INTO BaoTri_Phong(MaBT, MaPhong)
            SELECT @NewMaBT, MaPhong
            FROM YeuCauBaoTriPhong
            WHERE MaYC = @MaYC;
        END

        -------------------------------------------------
        -- Nếu là yêu cầu bảo trì Thiết bị
        -------------------------------------------------
        IF EXISTS (SELECT 1 FROM YeuCauBaoTriThietBi WHERE MaYC = @MaYC)
        BEGIN
            INSERT INTO BaoTri_ThietBi(MaBT, MaTB)
            SELECT @NewMaBT, MaTB
            FROM YeuCauBaoTriThietBi
            WHERE MaYC = @MaYC;
        END
    END
END;
GO

GO
CREATE PROC sp_PheDuyetYeuCau
    @MaYC CHAR(10)
AS
BEGIN
	UPDATE YeuCauBaoTri
    SET TrangThai = N'Đã phê duyệt'
    WHERE MaYC = @MaYC;
END;
GO

GO
CREATE PROC sp_TuChoiYeuCau
    @MaYC CHAR(10)
AS
BEGIN
    DELETE FROM YeuCauBaoTri
    WHERE MaYC = @MaYC;
END;
GO

DROP PROC IF EXISTS sp_LocYeuCauBaoTriTheoTrangThai
GO
CREATE PROC sp_LocYeuCauBaoTriTheoTrangThai
    @TrangThai NVARCHAR(50)
AS
BEGIN
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
END;
GO

DROP PROC IF EXISTS sp_SuaThongTinYeuCauBaoTri
GO
CREATE PROC sp_SuaThongTinYeuCauBaoTri
    @MaYC CHAR(10),
    @NgayYC DATE = NULL,
    @NoiDung NVARCHAR(255) = NULL,
    @TrangThai NVARCHAR(20),
    @MaPhong CHAR(10) = NULL,
    @MaTB CHAR(10) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra chỉ được nhập 1 trong 2
    IF (@MaPhong IS NOT NULL AND @MaTB IS NOT NULL)
    BEGIN
        RAISERROR (N'Chỉ được nhập Mã Phòng hoặc Mã Thiết Bị, không được cả hai.', 16, 1);
        RETURN;
    END;

    IF (@MaPhong IS NULL AND @MaTB IS NULL)
    BEGIN
        RAISERROR (N'Phải nhập Mã Phòng hoặc Mã Thiết Bị.', 16, 1);
        RETURN;
    END;

    -- Update bảng cha
    UPDATE YeuCauBaoTri
    SET NoiDung = @NoiDung,
        TrangThai = @TrangThai,
        NgayYC = @NgayYC
    WHERE MaYC = @MaYC;

    -- Nếu là yêu cầu cho phòng
    IF @MaPhong IS NOT NULL
    BEGIN
        -- Xóa bản ghi thiết bị nếu có
        DELETE FROM YeuCauBaoTriThietBi WHERE MaYC = @MaYC;

        -- Nếu đã có phòng thì update, chưa có thì insert
        IF EXISTS (SELECT 1 FROM YeuCauBaoTriPhong WHERE MaYC = @MaYC)
            UPDATE YeuCauBaoTriPhong SET MaPhong = @MaPhong WHERE MaYC = @MaYC;
        ELSE
            INSERT INTO YeuCauBaoTriPhong (MaYC, MaPhong) VALUES (@MaYC, @MaPhong);
    END;

    -- Nếu là yêu cầu cho thiết bị
    IF @MaTB IS NOT NULL
    BEGIN
        -- Xóa bản ghi phòng nếu có
        DELETE FROM YeuCauBaoTriPhong WHERE MaYC = @MaYC;

        -- Nếu đã có thiết bị thì update, chưa có thì insert
        IF EXISTS (SELECT 1 FROM YeuCauBaoTriThietBi WHERE MaYC = @MaYC)
            UPDATE YeuCauBaoTriThietBi SET MaTB = @MaTB WHERE MaYC = @MaYC;
        ELSE
            INSERT INTO YeuCauBaoTriThietBi (MaYC, MaTB) VALUES (@MaYC, @MaTB);
    END
END;


GO
CREATE PROC sp_SuaThongTinBaoTri
	@MaBT CHAR(10),
	@NgayBT DATE NULL,
	@ChiPhi INT NULL,
	@DonViThucHien NVARCHAR(50) NULL,
	@TrangThai NVARCHAR(50)
AS
BEGIN
	UPDATE BaoTri
	SET NgayBT = @NgayBT, ChiPhi = @ChiPhi, DonViThucHien = @DonViThucHien, TrangThai = @TrangThai
	WHERE MaBT = @MaBT
END;
GO

GO
CREATE PROC sp_LocPhongTheoTinhTrang
	@TinhTrang NVARCHAR(20)
AS
BEGIN
	SELECT p.MaPhong, p.TenPhong, p.TinhTrang
	FROM Phong p
	WHERE p.TinhTrang = @TinhTrang
END;
GO

GO
CREATE PROC sp_LocThietBiTheoTinhTrang 
	@TinhTrang NVARCHAR(20)
AS
BEGIN
	SELECT tb.MaTB, tb.TenTB, tb.TinhTrang
	FROM ThietBi tb
	WHERE TinhTrang = @TinhTrang
END;
GO

DROP VIEW IF EXISTS v_ThongTinChiTietPhongThietBi
GO
CREATE VIEW v_ThongTinChiTietPhongThietBi
AS
	SELECT ptb.MaPhong, p.TenPhong, p.TinhTrang AS TinhTrangPhong, ptb.MaTB, tb.TenTB, tb.TinhTrang AS TinhTrangTB, SoLuong AS SoLuongThietBi
	FROM Phong_ThietBi ptb
	JOIN Phong p ON ptb.MaPhong = p.MaPhong
	JOIN ThietBi tb ON ptb.MaTB = tb.MaTB
GO

SELECT * FROM v_ThongTinChiTietPhongThietBi

DROP PROC IF EXISTS sp_XemYeuCauBaoTriTheoUser 
GO
CREATE PROC sp_XemYeuCauBaoTriTheoUser 
	@TenTK NVARCHAR(50)
AS
BEGIN
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
	WHERE ycbt.TenTK = @TenTK
END;
GO
EXEC sp_XemYeuCauBaoTriTheoUser 'user1'