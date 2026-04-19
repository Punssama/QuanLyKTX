using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using KTX.Shared.DTOs;

namespace KTX_Management
{
    public partial class QuanLyHopDong : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://huyphongprojectapi.dev:5294/") };
        private List<HopDongDTO> _allHopDongs = new List<HopDongDTO>();

        public QuanLyHopDong()
        {
            InitializeComponent();
            BangTimKiemNangCao.Visible = false;
            this.Load += QuanLyHopDong_Load;
            btnOutQLHD.Click += btnOutQLHD_Click;
        }

        private async void QuanLyHopDong_Load(object? sender, EventArgs e)
        {
            await FetchAllDataAsync();
            UpdateDataView();
        }
         privatesdfaweasdfasdfádfa
        private async Task FetchAllDataAsync()
        {
            try
            {
                var response = await client.GetAsync("api/HopDong");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<HopDongDTO>>();
                    if (data != null)
                    {
                        _allHopDongs = data;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến máy chủ API để lấy Dữ liệu Hợp đồng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu Hợp đồng từ API: " + ex.Message);
            }
        }


        private void btnDeleteKeyWords_Click(object sender, EventArgs e)
        {
            // Clear all search inputs and results
            ClearSearchFields();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnTImKiemNangCao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnTImKiemNangCao.Checked)
            {
                BangTimKiemNangCao.Visible = true;
            }
            else
            {
                BangTimKiemNangCao.Visible = false;
            }
        }

        private void btnSearchHD_Click(object sender, EventArgs e)
        {
            UpdateDataView();
        }

        private void UpdateDataView()
        {
            var filtered = _allHopDongs.AsEnumerable();

            // basic name search
            if (!string.IsNullOrWhiteSpace(TenSVtxb.Text))
            {
                var filterStr = TenSVtxb.Text.Trim().ToLower();
                filtered = filtered.Where(h => (h.TenSV ?? "").ToLower().Contains(filterStr));
            }

            // advanced search
            if (rdbtnTImKiemNangCao.Checked)
            {
                if (!string.IsNullOrWhiteSpace(txbMSV.Text))
                {
                    filtered = filtered.Where(h => h.MaSV == txbMSV.Text.Trim());
                }

                if (!string.IsNullOrWhiteSpace(txbContractNumber.Text))
                {
                    filtered = filtered.Where(h => h.MaHopDong == txbContractNumber.Text.Trim());
                }

                if (!string.IsNullOrWhiteSpace(txbSignedDate.Text))
                {
                    if (DateTime.TryParse(txbSignedDate.Text.Trim(), out var dt))
                    {
                        filtered = filtered.Where(h => h.NgayKy.HasValue && h.NgayKy.Value.Date == dt.Date);
                    }
                    else
                    {
                        filtered = filtered.Where(h => h.NgayKy.HasValue && h.NgayKy.Value.ToString("dd/MM/yyyy").Contains(txbSignedDate.Text.Trim()));
                    }
                }

                if (!string.IsNullOrWhiteSpace(txbRoomNumber.Text))
                {
                    filtered = filtered.Where(h => h.SoPhong == txbRoomNumber.Text.Trim());
                }

                if (rdbtnCtAvail.Checked)
                {
                    filtered = filtered.Where(h => h.TinhTrang == "Vẫn còn");
                }
                else if (rdbtnCtNotAvail.Checked)
                {
                    filtered = filtered.Where(h => h.TinhTrang == "Không còn");
                }
            }

            var resultList = filtered.ToList();
            dataGridView1.DataSource = resultList;

            if (dataGridView1.Columns["MaHopDong"] != null) dataGridView1.Columns["MaHopDong"].HeaderText = "Mã Hợp Đồng";
            if (dataGridView1.Columns["MaSV"] != null) dataGridView1.Columns["MaSV"].HeaderText = "Mã SV";
            if (dataGridView1.Columns["TenSV"] != null) dataGridView1.Columns["TenSV"].HeaderText = "Tên Sinh Viên";
            if (dataGridView1.Columns["NgayKy"] != null) dataGridView1.Columns["NgayKy"].HeaderText = "Ngày Ký";
            if (dataGridView1.Columns["SoPhong"] != null) dataGridView1.Columns["SoPhong"].HeaderText = "Số Phòng";
            if (dataGridView1.Columns["TinhTrang"] != null) dataGridView1.Columns["TinhTrang"].HeaderText = "Tình Trạng";
        }


        private void ClearSearchFields()
        {

            TenSVtxb.Text = string.Empty;

            txbMSV.Text = string.Empty;
            txbContractNumber.Text = string.Empty;
            txbSignedDate.Text = string.Empty;
            txbRoomNumber.Text = string.Empty;

            rdbtnTImKiemNangCao.Checked = false;
            rdbtnCtAvail.Checked = false;
            rdbtnCtNotAvail.Checked = false;
            BangTimKiemNangCao.Visible = false;

            UpdateDataView();
        }

        private void btnOutQLHD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HopDongKTX hdktx = new HopDongKTX();
            hdktx.Show();
            
        }
    }
}
