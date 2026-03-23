namespace BigProject.API.DTOs
{
    public class CreatedAccountDto
    {
        public int Id { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
        public string QuyenHan { get; set; } = "Nhân viên";
        public int? MaNV { get; set; }
        public bool? TrangThai { get; set; } = true;
    }

    public class LoginRequestDto
    {
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhau { get; set; } = string.Empty;
    }

    public class LoginResponseDto
    {
        public string TenDangNhap { get; set; } = string.Empty;
        public string QuyenHan { get; set; } = string.Empty;
    }
}
