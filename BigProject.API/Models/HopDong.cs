using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BigProject.API.Models
{
    [Table("HOPDONG")]
    public class HopDong
    {
        [Key]
        [Column("MaHopDong")]
        public string MaHopDong { get; set; } = string.Empty;
        
        [Column("MaSV")]
        public string MaSV { get; set; } = string.Empty;
        
        [Column("TenSV")]
        public string TenSV { get; set; } = string.Empty;
        
        [Column("NgayKy")]
        public DateTime? NgayKy { get; set; }
        
        [Column("SoPhong")]
        public string SoPhong { get; set; } = string.Empty;

        [Column("TinhTrang")]
        public string TinhTrang { get; set; } = "Vẫn còn";
    }
}