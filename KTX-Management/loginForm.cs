using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
namespace KTX_Management
{
    public partial class loginForm : Form
    {

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

            registerForm registerForm = new registerForm();
            var taikhoan = new
            {
                TenDangNhap = TenDangNhaptb.Text,
                MatKhau = MatKhauTb.Text
            };
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://localhost:5294/api/TaiKhoan/dangnhap";
                    var response = await client.PostAsJsonAsync(url, taikhoan);
                    if (response.IsSuccessStatusCode)
                    {
                        string result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Dang nhap thanh cong!" + result, "Thong bao");
                        registerForm.ShowDialog();
                        this.Dispose();
                      

                    }
                    else
                    {
                        MessageBox.Show("Dang nhap that bai!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}
