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
            btnHienTatCa.Click += btnHienTatCa_Click;
            btnXoaTk.Click += btnXoaTk_Click;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private async void btnHienTatCa_Click(object sender, EventArgs e)
        {
            await LoadDataTaiKhoan();
        }

        private async Task LoadDataTaiKhoan()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://huyphongprojectapi.dev:5294/api/TaiKhoan";
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var options = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        string json = await response.Content.ReadAsStringAsync();
                        var data = System.Text.Json.JsonSerializer.Deserialize<List<TaiKhoanModel>>(json, options);

                        if (data != null)
                        {
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = data;
                            dataGridView1.ClearSelection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy dữ liệu!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private async void btnXoaTk_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa bằng cách ấn vào dòng tương ứng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            var confirmResult = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản ID {id}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string url = $"http://huyphongprojectapi.dev:5294/api/TaiKhoan/xoataikhoan/{id}";
                        var response = await client.DeleteAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Xóa tài khoản thành công!", "Thông báo");
                            await LoadDataTaiKhoan();
                        }
                        else
                        {
                            MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
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

            if (!int.TryParse(IDTb.Text, out int id) || id < 0)
            {
                MessageBox.Show("ID phải là số nguyên dương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IDTb.Focus();
                return;
            }

            var taikhoan = new
            {
                Id = id,
                TenDangNhap = TenDangNhapTb.Text,
                MatKhau = MatKhauTb.Text,
                QuyenHan = string.IsNullOrWhiteSpace(roleTb.Text) ? "Nhân viên" : roleTb.Text,
                TrangThai = true
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://huyphongprojectapi.dev:5294/api/TaiKhoan/themtaikhoan";
                    var response = await client.PostAsJsonAsync(url, taikhoan);
                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear fields after success
                        IDTb.Clear();
                        TenDangNhapTb.Clear();
                        MatKhauTb.Clear();
                        roleTb.Clear();
                    }
                    else
                    {
                        var errorMsg = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Thêm tài khoản thất bại! Lỗi: {errorMsg}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class TaiKhoanModel
    {
        public int id { get; set; }
        public string tenDangNhap { get; set; } = string.Empty;
        public string quyenHan { get; set; } = string.Empty;
        public int? maNV { get; set; }
        public bool? trangThai { get; set; }
    }
}
