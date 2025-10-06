USE QLThuVien;
GO
-- TẠO BẢNG
-- Bảng Tài khoản
DROP TABLE IF EXISTS TaiKhoan;
CREATE TABLE TaiKhoan (
    TenTK NVARCHAR(20) PRIMARY KEY,
    MatKhau NVARCHAR(30) NOT NULL,
    VaiTro NVARCHAR(20) NOT NULL 
	CONSTRAINT CHECK_Role CHECK(VaiTro IN ('AdminRole', 'UserRole'))
);

-- Bảng Phòng
DROP TABLE IF EXISTS Phong;
CREATE TABLE Phong (
    MaPhong CHAR(10) PRIMARY KEY,
    TenPhong NVARCHAR(30) NOT NULL,
    LoaiPhong NVARCHAR(10) NOT NULL,
    SucChua INT NOT NULL CONSTRAINT CHECK_SucChua CHECK(SucChua > 0),
    TinhTrang NCHAR(20) DEFAULT N'Đang dùng' CONSTRAINT CHECK_TinhTrangPhong CHECK(TinhTrang IN (N'Đang dùng', N'Bảo trì', N'Cũ')) 
);

-- Bảng Thiết Bị
DROP TABLE IF EXISTS ThietBi;
CREATE TABLE ThietBi (    
    MaTB CHAR(10) PRIMARY KEY,
    TenTB NVARCHAR(30) NOT NULL,
    LoaiTB NVARCHAR(10) NOT NULL,
    NgayMua DATE NOT NULL,
    TinhTrang NVARCHAR(20) DEFAULT N'Đang dùng' CONSTRAINT CHECK_TinhTrangThietBi CHECK(TinhTrang IN (N'Đang dùng', N'Bảo trì', N'Cũ'))
);

-- Liên kết Phòng - Thiết bị
DROP TABLE IF EXISTS Phong_ThietBi;
CREATE TABLE Phong_ThietBi (
    MaPhong CHAR(10),
    MaTB CHAR(10),
    SoLuong INT CONSTRAINT CHECK_SoLuong CHECK(SoLuong > 0),
	PRIMARY KEY (MaPhong, MaTB),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB) ON DELETE CASCADE ON UPDATE CASCADE,
);

-- Bảng Yêu cầu bảo trì
DROP TABLE IF EXISTS YeuCauBaoTri;
CREATE TABLE YeuCauBaoTri (
    MaYC CHAR(10) PRIMARY KEY,
    TenTK NVARCHAR(20) NOT NULL,
    NgayYC DATE NOT NULL,
    NoiDung NVARCHAR(255) NOT NULL,
    TrangThai NCHAR(20) DEFAULT N'Đang xử lý' CONSTRAINT CHECK_TrangThaiYeuCau CHECK (TrangThai IN (N'Đang xử lý', N'Đã duyệt'))
    FOREIGN KEY (TenTK) REFERENCES TaiKhoan(TenTK) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Bảng Yêu cầu bảo trì cho phòng
DROP TABLE IF EXISTS YeuCauBaoTriPhong
CREATE TABLE YeuCauBaoTriPhong (
    MaYC CHAR(10) PRIMARY KEY,
	MaPhong CHAR(10) NOT NULL,
	FOREIGN KEY (MaYC) REFERENCES YeuCauBaoTri(MaYC) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON DELETE CASCADE ON UPDATE CASCADE 
);

-- Bảng Yêu cầu bảo trì cho thiết bị
DROP TABLE IF EXISTS YeuCauBaoTriThietBi
CREATE TABLE YeuCauBaoTriThietBi (
    MaYC CHAR(10) PRIMARY KEY,
	MaTB CHAR(10) NOT NULL,
	MaPhong CHAR(10)
	FOREIGN KEY (MaYC) REFERENCES YeuCauBaoTri(MaYC) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB) ON UPDATE CASCADE,
	FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON DELETE SET NULL ON UPDATE CASCADE
);

-- Bảng Bảo trì
DROP TABLE IF EXISTS BaoTri;
CREATE TABLE BaoTri (
    MaBT CHAR(10) PRIMARY KEY,
    NgayBT DATE,
    ChiPhi INT CONSTRAINT CHECK_ChiPhi CHECK(ChiPhi > 0),
    DonViThucHien NVARCHAR(30),
    MaYC CHAR(10) NOT NULL,
    TrangThai NVARCHAR(30) DEFAULT N'Chưa bắt đầu' 
	CONSTRAINT CHECK_TrangThaiBaoTri CHECK (TrangThai IN (N'Chưa bắt đầu', N'Đang thực hiện', N'Đã hoàn thành'))
    FOREIGN KEY (MaYC) REFERENCES YeuCauBaoTri(MaYC) ON DELETE CASCADE ON UPDATE CASCADE,
);

-- Bảo trì - Phòng
DROP TABLE IF EXISTS BaoTriPhong;
CREATE TABLE BaoTriPhong (
    MaBT CHAR(10) PRIMARY KEY,
    MaPhong CHAR(10) NOT NULL,
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (MaBT) REFERENCES BaoTri(MaBT) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Bảo trì - Thiết bị
DROP TABLE IF EXISTS BaoTriThietBi;
CREATE TABLE BaoTriThietBi (
    MaBT CHAR(10) PRIMARY KEY,
    MaTB CHAR(10) NOT NULL,
	MaPhong CHAR(10),
	FOREIGN KEY (MaTB) REFERENCES ThietBi(MaTB) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY (MaBT) REFERENCES BaoTri(MaBT) ON DELETE CASCADE ON UPDATE CASCADE
);

USE QLThuVien
GO

------------------------------------------------------------
-- BẢNG PHÒNG
------------------------------------------------------------
DELETE FROM Phong
INSERT INTO Phong (MaPhong, TenPhong, LoaiPhong, SucChua, TinhTrang)
VALUES
('P001', N'Phòng Máy 1', N'Máy tính', 40, N'Đang dùng'),
('P002', N'Phòng Máy 2', N'Máy tính', 35, N'Đang dùng'),
('P003', N'Phòng Đọc 1', N'Đọc sách', 20, N'Cũ'),
('P004', N'Phòng Kho 1', N'Kho', 10, N'Cũ'),
('P005', N'Phòng Làm việc 1', N'Làm việc', 8, N'Đang dùng'),
('P006', N'Phòng In ấn 1', N'In ấn', 5, N'Đang dùng'),
('P007', N'Phòng In ấn 2', N'In ấn', 3, N'Cũ');

------------------------------------------------------------
-- BẢNG THIẾT BỊ
------------------------------------------------------------
DELETE FROM ThietBi;
INSERT INTO ThietBi (MaTB, TenTB, LoaiTB, NgayMua, TinhTrang)
VALUES
('TB001', N'Máy chiếu Epson X1', N'Máy chiếu', '2023-02-15', N'Đang dùng'),
('TB002', N'Router Cisco A5', N'Mạng', '2021-09-10', N'Cũ'),
('TB003', N'Máy in Canon 2900', N'In', '2024-05-20', N'Đang dùng'),
('TB004', N'Dàn âm thanh Sony', N'Âm thanh', '2023-12-01', N'Đang dùng'),
('TB005', N'Máy tính Dell Optiplex', N'Công nghệ', '2024-03-10', N'Đang dùng'),
('TB006', N'Switch TP-Link 24 Port', N'Mạng', '2023-07-15', N'Đang dùng');

------------------------------------------------------------
-- BẢNG PHÒNG_THIẾT BỊ (QUAN HỆ NHIỀU-NHIỀU)
------------------------------------------------------------
DELETE FROM Phong_ThietBi
INSERT INTO Phong_ThietBi (MaPhong, MaTB, SoLuong)
VALUES
('P001', 'TB001', 1),
('P001', 'TB005', 20),
('P002', 'TB005', 25),
('P002', 'TB002', 1),
('P006', 'TB003', 2),
('P006', 'TB006', 1),
('P004', 'TB004', 1),
('P005', 'TB002', 1),
('P005', 'TB001', 1),
('P003', 'TB004', 1);

------------------------------------------------------------
-- BẢNG YÊU CẦU BẢO TRÌ
------------------------------------------------------------
DELETE FROM YeuCauBaoTri
INSERT INTO YeuCauBaoTri (MaYC, TenTK, NgayYC, NoiDung, TrangThai)
VALUES
('YC001', N'user1', '2025-01-25', N'Máy chiếu bị mờ hình ảnh', N'Đã duyệt'),
('YC002', N'user2', '2025-04-26', N'Mạng phòng làm việc chập chờn', N'Đã duyệt'),
('YC003', N'user2', '2025-04-07', N'Máy in không nhận lệnh in', N'Đã duyệt'),
('YC004', N'user1', '2025-06-28', N'Âm thanh bị rè', N'Đã duyệt'),
('YC005', N'user2', '2025-09-29', N'Phòng đọc cần sơn lại', N'Đã duyệt');

------------------------------------------------------------
-- YÊU CẦU BẢO TRÌ PHÒNG
------------------------------------------------------------
INSERT INTO YeuCauBaoTriPhong (MaYC, MaPhong)
VALUES
('YC005', 'P003');

------------------------------------------------------------
-- YÊU CẦU BẢO TRÌ THIẾT BỊ
------------------------------------------------------------
INSERT INTO YeuCauBaoTriThietBi (MaYC, MaTB, MaPhong)
VALUES
('YC001', 'TB001', 'P001'),
('YC002', 'TB002', 'P005'),
('YC003', 'TB003', 'P006'),
('YC004', 'TB004', 'P004');

------------------------------------------------------------
-- BẢNG BẢO TRÌ
------------------------------------------------------------
INSERT INTO BaoTri (MaBT, NgayBT, ChiPhi, DonViThucHien, MaYC, TrangThai)
VALUES
('BT001', '2025-01-30', 800000, N'Công ty Thiết bị Việt', 'YC001', N'Đã hoàn thành'),
('BT002', '2025-04-27', 500000, N'Truyền thông FPT', 'YC002', N'Đã hoàn thành'),
('BT003', '2025-04-08', 300000, N'Canon Việt Nam', 'YC003', N'Đã hoàn thành'),
('BT004', '2025-06-30', 450000, N'Sony Center', 'YC004', N'Đã hoàn thành'),
('BT005', '2025-10-03', 700000, N'Nhà thầu Sơn Minh Phú', 'YC005', N'Đã hoàn thành');

------------------------------------------------------------
-- BẢO TRÌ - PHÒNG
------------------------------------------------------------
INSERT INTO BaoTriPhong (MaBT, MaPhong)
VALUES
('BT005', 'P003');

------------------------------------------------------------
-- BẢO TRÌ - THIẾT BỊ
------------------------------------------------------------
INSERT INTO BaoTriThietBi (MaBT, MaTB, MaPhong)
VALUES
('BT001', 'TB001', 'P001'),
('BT002', 'TB002', 'P005'),
('BT003', 'TB003', 'P006'),
('BT004', 'TB004', 'P004');
