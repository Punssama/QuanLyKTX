using KTX.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTX_Management
{
    public partial class quanlyphong : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://huyphongprojectapi.dev:5294/") };
        public BindingList<PhongODTO> listPhong = new BindingList<PhongODTO>();
        int soNguoi;
        int sucChua;

        public quanlyphong()
        {
            InitializeComponent();
            this.Load += quanlyphong_Load;
        }

        private async void quanlyphong_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var data = await client.GetFromJsonAsync<List<PhongODTO>>("api/PhongO");
                if (data != null)
                {
                    listPhong = new BindingList<PhongODTO>(data);

                    // Xóa auto-generate để DataGridView chỉ bind cột đã cấu hình bằng tay trong Designer
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = listPhong;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu phòng: " + ex.Message);
            }
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text) || string.IsNullOrEmpty(txtToa.Text) || string.IsNullOrEmpty(cboLoaiPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng (Mã, Tòa, Loại phòng).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTrangThai.Text == "Còn trống" || txtTrangThai.Text == "Đã đầy" || txtTrangThai.Text == "Đầy" || txtTrangThai.Text == "Trống" || txtTrangThai.Text == "Đang ở" || txtTrangThai.Text == "Quá tải")
            {
                PhongODTO p = new PhongODTO();
                p.maphong = txtMaPhong.Text;  // Sử dụng maphong thay vì thuộc tính int
                p.matoa = txtToa.Text; 
                p.loaiphong = cboLoaiPhong.Text;

                int.TryParse(txtSoNguoi.Text, out int parsedSoNguoi);
                p.songuoihientai = parsedSoNguoi;

                int.TryParse(cboSucChua.Text, out int parsedSucChua);
                p.succhua = parsedSucChua;

                p.trangthai = txtTrangThai.Text;
                p.giatien = 1500000; // Giá mặc định nếu ko có ô trỏ
                p.ngaycapnhat = DateTime.Now;

                try
                {
                    var response = await client.PostAsJsonAsync("api/PhongO", p);
                    if(response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm phòng thành công!");
                        await LoadDataAsync();
                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng thất bại: " + response.ReasonPhrase);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Trạng thái không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaPhong.Clear();
            txtSoNguoi.Clear();
            txtToa.Clear();
            cboSucChua.SelectedIndex = -1;
            cboLoaiPhong.SelectedIndex = -1;
            txtTrangThai.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Nút Chuyển phòng (chưa implement chi tiết)
            MessageBox.Show("Chức năng đang phát triển.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSucChua_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cboSucChua.SelectedItem == null) return;
                sucChua = Convert.ToInt32(cboSucChua.SelectedItem);
                if (sucChua > soNguoi)
                {
                    if (soNguoi > 0)
                        txtTrangThai.Text = "Đang ở";
                    else
                        txtTrangThai.Text = "Trống";
                }
                else if (sucChua == soNguoi)
                {
                    txtTrangThai.Text = "Đã đầy";
                }
                else if (sucChua < soNguoi)
                {
                    txtTrangThai.Text = "Quá tải";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sức chứa phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtSoNguoi_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtSoNguoi.Text)) return;
                soNguoi = Convert.ToInt32(txtSoNguoi.Text);
                // Call change logic
                cboSucChua_SelectedIndexChanged(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số người phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNguoi.Clear();
            }
        }
    }
}