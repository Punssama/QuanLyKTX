using System;

namespace KTX.Shared.DTOs
{
    public class HopDongDTO
    {
        public string MaHopDong { get; set; } = string.Empty;
        public string MaSV { get; set; } = string.Empty;
        public string TenSV { get; set; } = string.Empty;
        public DateTime? NgayKy { get; set; }
        public string SoPhong { get; set; } = string.Empty;
        public string TinhTrang { get; set; } = "Vẫn còn";
    }
}