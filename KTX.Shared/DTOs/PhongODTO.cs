namespace KTX.Shared.DTOs
{
    public class PhongODTO
    {
        public string maphong { get; set; } = string.Empty;
        public string matoa { get; set; } = string.Empty;
        public int succhua { get; set; }
        public int songuoihientai { get; set; }
        public double giatien { get; set; }
        public string trangthai { get; set; } = "Trống";
    }
    public class loginResponse
    {
        public string tendangnhap { get; set; } = string.Empty;
        public string quyen { get; set; } = string.Empty;
    }
}
