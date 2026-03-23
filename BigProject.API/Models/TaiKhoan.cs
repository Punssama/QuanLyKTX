using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BigProject.API.Models
{
    [Table("TAIKHOAN")]
    [Index(nameof(TenDangNhap), IsUnique = true)]
    public class TaiKhoan
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("TENDANGNHAP")]
        public string TenDangNhap { get; set; } = string.Empty;

        [Column("MATKHAU")]
        public string MatKhau { get; set; } = string.Empty;

        [Column("QUYENHAN")]
        public string QuyenHan { get; set; } = "Nhân viên";

        [Column("MANV")]
        public int? MaNV { get; set; }

        [Column("TRANGTHAI")]
        public bool? TrangThai { get; set; } = true;
    }
}
