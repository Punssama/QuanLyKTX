USE master;
GO

IF DB_ID('QUANLYKTX') IS NOT NULL
BEGIN
	ALTER DATABASE QUANLYKTX SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE QUANLYKTX;
END
GO

CREATE DATABASE QUANLYKTX;
GO

USE QUANLYKTX;
GO

-- 1. Bảng TÀI KHOẢN
CREATE TABLE TAIKHOAN (
    maTaiKhoan VARCHAR(50) PRIMARY KEY,
    soDienThoai VARCHAR(20),
    email VARCHAR(100),
    tenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    matKhau VARCHAR(50) NOT NULL,
    quyen NVARCHAR(50)
);
GO

-- 2. Bảng QUẢN LÝ
CREATE TABLE QUANLY (
    maNguoiQuanLy VARCHAR(50) PRIMARY KEY,
    maTaiKhoan VARCHAR(50) FOREIGN KEY REFERENCES TAIKHOAN(maTaiKhoan) ON DELETE CASCADE
);
GO

-- 3. Bảng NHÂN VIÊN
CREATE TABLE NHANVIEN (
    maNhanVien VARCHAR(50) PRIMARY KEY,
    hoTen NVARCHAR(100),
    ngaySinh DATE,
    gioiTinh NVARCHAR(10),
    soDienThoai VARCHAR(20),
    email VARCHAR(100),
    maTaiKhoan VARCHAR(50) FOREIGN KEY REFERENCES TAIKHOAN(maTaiKhoan) ON DELETE CASCADE
);
GO

-- 4. Bảng SINH VIÊN
CREATE TABLE SINHVIEN (
    maSinhVien VARCHAR(50) PRIMARY KEY,
    hoTen NVARCHAR(100),
    ngaySinh DATE,
    gioiTinh NVARCHAR(10),
    soDienThoai VARCHAR(20),
    email VARCHAR(100),
    maTaiKhoan VARCHAR(50) FOREIGN KEY REFERENCES TAIKHOAN(maTaiKhoan) ON DELETE CASCADE
);
GO

-- 5. Bảng PHÒNG
CREATE TABLE PHONG (
    soPhong VARCHAR(50) PRIMARY KEY,
    toa VARCHAR(50),
    loaiPhong NVARCHAR(50),
    sucChua INT,
    trangThai NVARCHAR(50)
);
GO

-- 6. Bảng HỢP ĐỒNG
CREATE TABLE HOPDONG (
    maHopDong VARCHAR(50) PRIMARY KEY,
    maSinhVien VARCHAR(50) FOREIGN KEY REFERENCES SINHVIEN(maSinhVien),
    soPhong VARCHAR(50) FOREIGN KEY REFERENCES PHONG(soPhong),
    ngayKy VARCHAR(50), -- Theo biểu đồ là string
    ngayBatDau VARCHAR(50), -- Theo biểu đồ là string
    ngayKetThuc VARCHAR(50), -- Theo biểu đồ là string
    maNguoiQuanLy VARCHAR(50) FOREIGN KEY REFERENCES QUANLY(maNguoiQuanLy)
);
GO

-- 7. Bảng HOÁ ĐƠN
CREATE TABLE HOADON (
    maHoaDon VARCHAR(50) PRIMARY KEY,
    ngayLap DATE,
    tienPhong FLOAT,
    tienDien FLOAT,
    tienNuoc FLOAT,
    tongTien FLOAT,
    trangThai NVARCHAR(50),
    soPhong VARCHAR(50) FOREIGN KEY REFERENCES PHONG(soPhong),
    maNhanVien VARCHAR(50) FOREIGN KEY REFERENCES NHANVIEN(maNhanVien)
);
GO

-- 8. Bảng ĐƠN PHẢN ÁNH
CREATE TABLE DONPHANANH (
    maPhanAnh VARCHAR(50) PRIMARY KEY,
    thoiGianPhanAnh DATE,
    loaiPhanAnh NVARCHAR(100),
    noiDung NVARCHAR(MAX),
    trangThai NVARCHAR(50),
    maSinhVien VARCHAR(50) FOREIGN KEY REFERENCES SINHVIEN(maSinhVien),
    maNhanVien VARCHAR(50) NULL FOREIGN KEY REFERENCES NHANVIEN(maNhanVien)
);
GO

-- ================= INSERTS (Dữ liệu mẫu) =================

INSERT INTO TAIKHOAN (maTaiKhoan, soDienThoai, email, tenDangNhap, matKhau, quyen) VALUES
('TK01', '0123456789', 'admin@ktx.com', 'admin', '123456', N'Quản lý'),
('TK02', '0987654321', 'nv1@ktx.com', 'nhanvien1', '123456', N'Nhân viên'),
('TK03', '0112233445', 'sv1@ktx.com', 'sinhvien1', '123456', N'Sinh viên');
GO

INSERT INTO QUANLY (maNguoiQuanLy, maTaiKhoan) VALUES ('QL01', 'TK01');
GO

INSERT INTO NHANVIEN (maNhanVien, hoTen, ngaySinh, gioiTinh, soDienThoai, email, maTaiKhoan) VALUES
('NV01', N'Nguyễn Văn A', '1990-01-01', N'Nam', '0987654321', 'nv1@ktx.com', 'TK02');
GO

INSERT INTO SINHVIEN (maSinhVien, hoTen, ngaySinh, gioiTinh, soDienThoai, email, maTaiKhoan) VALUES
('SV01', N'Trần Thị B', '2000-05-10', N'Nữ', '0112233445', 'sv1@ktx.com', 'TK03');
GO

INSERT INTO PHONG (soPhong, toa, loaiPhong, sucChua, trangThai) VALUES
('A101', 'A', N'Nam', 8, N'Trống'),
('A102', 'A', N'Nữ', 8, N'Đang ở');
GO

INSERT INTO HOPDONG (maHopDong, maSinhVien, soPhong, ngayKy, ngayBatDau, ngayKetThuc, maNguoiQuanLy) VALUES
('HD01', 'SV01', 'A102', '2023-08-01', '2023-08-05', '2024-08-05', 'QL01');
GO

INSERT INTO HOADON (maHoaDon, ngayLap, tienPhong, tienDien, tienNuoc, tongTien, trangThai, soPhong, maNhanVien) VALUES
('HDN01', '2023-09-01', 1500000, 200000, 100000, 1800000, N'Chưa thanh toán', 'A102', 'NV01');
GO

INSERT INTO DONPHANANH (maPhanAnh, thoiGianPhanAnh, loaiPhanAnh, noiDung, trangThai, maSinhVien, maNhanVien) VALUES
('PA01', '2023-09-15', N'Sửa chữa', N'Hỏng bóng đèn', N'Chưa xử lý', 'SV01', NULL);
GO







