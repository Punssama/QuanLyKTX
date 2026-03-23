using KTX.Shared.DTOs;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Cryptography.Xml;
using System.Text.Json;
using System.Threading.Tasks;
namespace KTX_Management
{
    public partial class loginForm : Form
    {
        static string quyen = string.Empty;
        public loginForm()
        {
            InitializeComponent();
        }

        private void signUpLinkLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.ShowDialog();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            var taikhoan = new
            {
                TenDangNhap = TenDangNhaptb.Text,
                MatKhau = MatKhauTb.Text
            };
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://huyphongprojectapi.dev:5294/api/TaiKhoan/dangnhap";
                    var response = await client.PostAsJsonAsync(url, taikhoan);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        };
                        loginResponse? loginResp = JsonSerializer.Deserialize<loginResponse>(responseContent, options);
                        quyen = loginResp?.quyen ?? "";

                         if (quyen != "Quản lý")
                        {
                            MessageBox.Show("Đăng nhập thành công với quyền Quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thành công với quyền Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Hide();
                        FormTrangChu formTrangChu = new FormTrangChu();
                        formTrangChu.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi!");
                }
            }

        }

        private void ForgetPassWordLb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ quản lý để được cấp lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
