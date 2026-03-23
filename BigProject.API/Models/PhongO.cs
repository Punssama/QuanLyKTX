using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace BigProject.API.Models
{
    [Table("PHONG")]
    public class PhongO
    {
        [Key]
        [Column("MAPHONG")] 
        public string maphong { get; set; } = string.Empty;
        [Column("SUCCHUA")]
        public int succhua { get; set; }
        [Column("SONGUOIHIENTAI")]
        public int songuoihientai { get; set; }
        [Column("GIATIEN")]
        public double giatien { get; set; }
        [Column("TRANGTHAI")]
        public string trangthai { get; set; } = "Trống";
        [Column("MATOA")]
        public string matoa { get; set; } = string.Empty;


    }
}
