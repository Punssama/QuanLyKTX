using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BigProject.API.Models
{
    [Table("TAIKHOAN")]

    public class TaiKhoan
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TENDANGNHAP")]
        public string TenDangNhap { get; set; } = string.Empty;
        [Column("MATKHAU")]
        public string MatKhau { get; set; } = string.Empty;
        [Column("Quyen") ]
        public string Quyen {  get; set; } = string.Empty;
    }
}
