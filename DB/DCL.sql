USE QLThuVien;
GO
-- Xóa user trong DB trước
DROP USER IF EXISTS admin1;
DROP USER IF EXISTS user1;
DROP USER IF EXISTS user2;
GO

-- Xóa login ở server
GO
DROP LOGIN admin1;
DROP LOGIN user1;
DROP LOGIN user2;
GO

-- Xóa các role cũ trong DB
GO
DROP ROLE IF EXISTS AdminRole;
DROP ROLE IF EXISTS UserRole;
GO

-- TẠO ROLE CHO NGƯỜI QUẢN LÝ --
CREATE ROLE AdminRole;

CREATE LOGIN admin1 WITH PASSWORD = 'Admin@123';
CREATE USER admin1 FOR LOGIN admin1;
EXEC sp_addrolemember 'AdminRole', 'admin1';


-- GÁN QUYỀN CHO NGƯỜI QUẢN LÝ --
EXEC sp_addrolemember 'db_owner', 'AdminRole';

USE master;
GO
-- CẤP QUYỀN SỬA LOGIN ĐỂ CÓ THỂ TẠO MỚI TÀI KHOẢN CHO USER
GRANT ALTER ANY LOGIN TO admin1

-- TẠO ROLE CHO NHÂN VIÊN THƯ VIỆN --
CREATE ROLE UserRole;
GO
-- Quyền CRUD chỉ trên các bảng yêu cầu
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.YeuCauBaoTri TO UserRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.YeuCauBaoTriPhong TO UserRole;
GRANT SELECT, INSERT, UPDATE, DELETE ON dbo.YeuCauBaoTriThietBi TO UserRole;

-- Cho phép thực thi các stored procedure & function nhất định
GRANT SELECT ON OBJECT::dbo.v_LayTatCaPhong TO UserRole;
GRANT SELECT ON OBJECT::dbo.v_LayTatCaThietBi TO UserRole;
GRANT SELECT ON OBJECT::dbo.v_ThongTinChiTietPhongThietBi TO UserRole;	

GRANT EXECUTE ON OBJECT::dbo.sp_KiemTraDangNhap TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_XemYeuCauBaoTriTheoUser TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_SuaThongTinYeuCauBaoTri TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_TuChoiYeuCau TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_TaoYeuCauBaoTri TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_XemYeuCauBaoTriTheoUser TO UserRole;
GRANT EXECUTE ON OBJECT::dbo.sp_ThemTaiKhoan TO UserRole;

GRANT SELECT ON OBJECT::dbo.fn_LocPhongTheoTinhTrang TO UserRole;
GRANT SELECT ON OBJECT::dbo.fn_LocThietBiTheoTinhTrang TO UserRole;
GRANT SELECT ON OBJECT::dbo.fn_ThongTinTaiKhoan TO UserRole;
GRANT SELECT ON OBJECT::dbo.fn_LayPhongQuaThietBi TO UserRole;

-- Chặn quyền trên các bảng khác
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.TaiKhoan TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.Phong TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.ThietBi TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.Phong_ThietBi TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.BaoTri TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.BaoTriPhong TO UserRole;
DENY SELECT, INSERT, UPDATE, DELETE ON dbo.BaoTriThietBi TO UserRole;

-- User
CREATE LOGIN user1 WITH PASSWORD = 'User@123';
CREATE USER user1 FOR LOGIN user1;
EXEC sp_addrolemember 'UserRole', 'user1';

CREATE LOGIN user2 WITH PASSWORD = 'User@123';
CREATE USER user2 FOR LOGIN user2;
EXEC sp_addrolemember 'UserRole', 'user2';

-- Xem danh sách user và role trong DB
USE QLThuVien
EXEC sp_helpuser;

SELECT name, schema_name(schema_id) as SchemaName, type_desc
FROM sys.objects
WHERE type IN ('P','FN','IF','TF','V');