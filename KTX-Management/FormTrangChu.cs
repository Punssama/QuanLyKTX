using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTX.Shared.DTOs;

namespace KTX_Management
{
    public partial class FormTrangChu : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public FormTrangChu()
        {
            InitializeComponent();
            this.Load += FormTrangChu_Load;

            // Allow selecting the entire row instead of single cell
            dgrvPhongO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Handle cell click
            dgrvPhongO.CellClick += DgrvPhongO_CellClick;
        }

        private async void FormTrangChu_Load(object? sender, EventArgs e)
        {
            await LoadDanhSachPhongO();
        }

        private async Task LoadDanhSachPhongO()
        {
            try
            {
                string url = "http://localhost:5294/api/PhongO";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<PhongODTO>? phongOs = JsonSerializer.Deserialize<List<PhongODTO>>(responseBody, options);

                if (phongOs != null)  
                {
                    dgrvPhongO.DataSource = phongOs;

                    // Rename column headers for better UI (optional)
                    if (dgrvPhongO.Columns["maphong"] != null) dgrvPhongO.Columns["maphong"].HeaderText = "Mã Phòng";
                    if (dgrvPhongO.Columns["matoa"] != null) dgrvPhongO.Columns["matoa"].HeaderText = "Mã Tòa";
                    if (dgrvPhongO.Columns["succhua"] != null) dgrvPhongO.Columns["succhua"].HeaderText = "Sức chứa";
                    if (dgrvPhongO.Columns["songuoihientai"] != null) dgrvPhongO.Columns["songuoihientai"].HeaderText = "Số người hiện tại";
                    if (dgrvPhongO.Columns["giatien"] != null) dgrvPhongO.Columns["giatien"].HeaderText = "Giá tiền";
                    if (dgrvPhongO.Columns["trangthai"] != null) dgrvPhongO.Columns["trangthai"].HeaderText = "Trạng thái";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối API: " + ex.Message);
            }
        }

        private void DgrvPhongO_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgrvPhongO.Rows[e.RowIndex];

                string phongName = row.Cells["maphong"].Value?.ToString() ?? "";
                string numPeople = row.Cells["songuoihientai"].Value?.ToString() ?? "0";
                string capacity = row.Cells["succhua"].Value?.ToString() ?? "0";
                string status = row.Cells["trangthai"].Value?.ToString() ?? "";

                tbRoomName.Text = $"{phongName}";
                tbNumOPeople.Text = $"{numPeople}/{capacity}";
                tbState.Text = $"{status}";

               
                if (status.ToLower().Contains("đầy"))
                {
                    lbState.ForeColor = Color.Red;
                }
                else
                {
                    lbState.ForeColor = Color.Green;
                }
            }
        }

        private void btnGoQLHD_Click(object sender, EventArgs e)
        {
            QuanLyHopDong quanlyhopdong = new QuanLyHopDong();
            quanlyhopdong.ShowDialog();
        }
        private void btnGoBCTK_Click(object sender, EventArgs e)
        {
            FormBaoCaoThongKe formBaoCaoThongKe = new FormBaoCaoThongKe();
            formBaoCaoThongKe.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
