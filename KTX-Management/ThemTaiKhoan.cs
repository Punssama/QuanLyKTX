using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;

namespace KTX_Management
{
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void validate(object sender, EventArgs e)
        {
            try
            {
                if (IDTb.Text == "")
                {
                    MessageBox.Show("ID không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IDTb.Focus();
                    return;
                }
                else
                {


                    int id = Convert.ToInt32(IDTb.Text);
                    if (id < 0)
                    {
                        MessageBox.Show("ID phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        IDTb.Focus();
                        return;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID phải là một số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IDTb.Focus();
                return;
            }
        }

        private async void ThemTaiKhoanBtn_Click(object sender, EventArgs e)
        {
            if (IDTb.Text == "" || TenDangNhapTb.Text == "" || MatKhauTb.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var taikhoan = new
                {
                    Id = Convert.ToInt32(IDTb.Text),
                    TenDangNhap = TenDangNhapTb.Text,
                    MatKhau = MatKhauTb.Text
                };
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string url = "http://localhost:5294/api/TaiKhoan/themtaikhoan";
                        var response = await client.PostAsJsonAsync(url, taikhoan);
                        if (response.IsSuccessStatusCode)
                        {
                            string result = await response.Content.ReadAsStringAsync();
                            MessageBox.Show("thanh cong!" + result, "Thong bao");

                        }
                        else
                        {
                            MessageBox.Show("that bai!");
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
}
