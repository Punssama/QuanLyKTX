erDiagram
TAIKHOAN ||--o| QUANLY : "is_a"
TAIKHOAN ||--o| NHANVIEN : "is_a"
TAIKHOAN ||--o| SINHVIEN : "is_a"
SINHVIEN ||--o{ HOPDONG : "đăng ký"
PHONG ||--o{ HOPDONG : "thuộc về"
QUANLY ||--o{ HOPDONG : "duyệt"
PHONG ||--o{ HOADON : "tính cho"
NHANVIEN ||--o{ HOADON : "lập"
SINHVIEN ||--o{ DONPHANANH : "gửi"
NHANVIEN |o--o{ DONPHANANH : "xử lý"

    TAIKHOAN {
        varchar_50 maTaiKhoan PK
        varchar_20 soDienThoai
        varchar_100 email
        varchar_50 tenDangNhap UK
        varchar_50 matKhau
        nvarchar_50 quyen
    }
    QUANLY {
        varchar_50 maNguoiQuanLy PK
        varchar_50 maTaiKhoan FK "ON DELETE CASCADE"
    }
    NHANVIEN {
        varchar_50 maNhanVien PK
        nvarchar_100 hoTen
        date ngaySinh
        nvarchar_10 gioiTinh
        varchar_20 soDienThoai
        varchar_100 email
        varchar_50 maTaiKhoan FK "ON DELETE CASCADE"
    }
    SINHVIEN {
        varchar_50 maSinhVien PK
        nvarchar_100 hoTen
        date ngaySinh
        nvarchar_10 gioiTinh
        varchar_20 soDienThoai
        varchar_100 email
        varchar_50 maTaiKhoan FK "ON DELETE CASCADE"
    }
    PHONG {
        varchar_50 soPhong PK
        varchar_50 toa
        nvarchar_50 loaiPhong
        int sucChua
        nvarchar_50 trangThai
    }
    HOPDONG {
        varchar_50 maHopDong PK
        varchar_50 maSinhVien FK
        varchar_50 soPhong FK
        varchar_50 ngayKy "Theo SQL: VARCHAR"
        varchar_50 ngayBatDau "Theo SQL: VARCHAR"
        varchar_50 ngayKetThuc "Theo SQL: VARCHAR"
        varchar_50 maNguoiQuanLy FK
    }
    HOADON {
        varchar_50 maHoaDon PK
        date ngayLap
        float tienPhong
        float tienDien
        float tienNuoc
        float tongTien
        nvarchar_50 trangThai
        varchar_50 soPhong FK
        varchar_50 maNhanVien FK
    }
    DONPHANANH {
        varchar_50 maPhanAnh PK
        date thoiGianPhanAnh
        nvarchar_100 loaiPhanAnh
        nvarchar_max noiDung
        nvarchar_50 trangThai
        varchar_50 maSinhVien FK
        varchar_50 maNhanVien FK "NULL"
    }
