using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using KTX.Shared.DTOs;

namespace KTX_Management
{
    public partial class FormBaoCaoThongKe : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("http://huyphongprojectapi.dev:5294/") };
        private List<PhongODTO> _allPhong = new List<PhongODTO>();

        public FormBaoCaoThongKe()
        {
            InitializeComponent();
            this.Load += FormBaoCaoThongKe_Load;

        }



        private async void FormBaoCaoThongKe_Load(object? sender, EventArgs e)
        {
            await FetchAllDataAsync();
            InitComboBoxes();
            UpdateDataViewSV();
            UpdateDataViewDoanhThu(dtpNamDoanhThu.Value.Year);
        }

        private async Task FetchAllDataAsync()
        {
            try
            {
                var response = await client.GetAsync("api/PhongO");
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadFromJsonAsync<List<PhongODTO>>();
                    if (data != null)
                        _allPhong = data;
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến máy chủ API.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu API: " + ex.Message);
            }
        }

        private void InitComboBoxes()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Tất cả");
            foreach (var toa in _allPhong.Select(p => p.matoa).Distinct())
            {
                comboBox1.Items.Add(toa);
            }
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Clear();
            comboBox2.Items.Add("Tất cả");
            foreach (var phong in _allPhong.Select(p => p.maphong).Distinct())
            {
                comboBox2.Items.Add(phong);
            }
            comboBox2.SelectedIndex = 0;

            comboBox3.Items.Clear();
            comboBox3.Items.Add("Tất cả");
            comboBox3.Items.Add("Đang ở");
            comboBox3.Items.Add("Đã đầy");
            comboBox3.Items.Add("Trống");
            comboBox3.SelectedIndex = 0;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            UpdateDataViewSV();
        }

        private void BtHoanTac_Click(object? sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            UpdateDataViewSV();
        }

        private void DtpNamDoanhThu_ValueChanged(object? sender, EventArgs e)
        {
            UpdateDataViewDoanhThu(dtpNamDoanhThu.Value.Year);
        }

        private void UpdateDataViewSV()
        {
            var filtered = _allPhong.AsEnumerable();

            if (comboBox1.SelectedIndex > 0)
                filtered = filtered.Where(p => p.matoa == comboBox1.SelectedItem?.ToString());

            if (comboBox2.SelectedIndex > 0)
                filtered = filtered.Where(p => p.maphong == comboBox2.SelectedItem?.ToString());

            if (comboBox3.SelectedIndex > 0)
                filtered = filtered.Where(p => p.trangthai == comboBox3.SelectedItem?.ToString());

            var resultList = filtered.ToList();

            dataGridView1.DataSource = resultList;

            if (dataGridView1.Columns["maphong"] != null) dataGridView1.Columns["maphong"].HeaderText = "Mã Phòng";
            if (dataGridView1.Columns["matoa"] != null) dataGridView1.Columns["matoa"].HeaderText = "Loại/Tòa";
            if (dataGridView1.Columns["succhua"] != null) dataGridView1.Columns["succhua"].HeaderText = "Sức chứa";
            if (dataGridView1.Columns["songuoihientai"] != null) dataGridView1.Columns["songuoihientai"].HeaderText = "Số người";
            if (dataGridView1.Columns["giatien"] != null) dataGridView1.Columns["giatien"].HeaderText = "Giá tiền";
            if (dataGridView1.Columns["trangthai"] != null) dataGridView1.Columns["trangthai"].HeaderText = "Trạng thái";
            if (dataGridView1.Columns["ngaycapnhat"] != null) dataGridView1.Columns["ngaycapnhat"].HeaderText = "Ngày Cập Nhật";

            chart1.Series.Clear();
            Series series = new Series("Số Sinh Viên");
            series.ChartType = SeriesChartType.Column;

           
            var stats = resultList.GroupBy(p => p.matoa)
                                  .Select(g => new { MaToa = g.Key, TongSV = g.Sum(p => p.songuoihientai) })
                                  .ToList();

            foreach (var item in stats)
            {
                series.Points.AddXY(item.MaToa ?? "Chưa rõ", item.TongSV);
            }
            chart1.Series.Add(series);
            chart1.ChartAreas[0].AxisX.Title = "Tòa";
            chart1.ChartAreas[0].AxisY.Title = "Tổng số sinh viên";
        }

        private void UpdateDataViewDoanhThu(int nam)
        {
            // Lọc các phòng có ngày cập nhật/ngày thu tiền thuộc Năm hiện tại 
            var filtered = _allPhong.Where(p => p.ngaycapnhat.HasValue && p.ngaycapnhat.Value.Year == nam).ToList();
            if (!filtered.Any())
            {
                chart2.Series.Clear();
                dataGridView2.DataSource = null;
                textBox1.Text = "";
                textBox2.Text = "0";
                return;
            }

        
            var dtResult = filtered.Select(p => new
            {
                Toa = p.matoa,
                Phong = p.maphong,
                Thang = p.ngaycapnhat.Value.Month,
                Nam = p.ngaycapnhat.Value.Year,
                DoanhThu = p.songuoihientai * p.giatien
            }).ToList();
            dataGridView2.DataSource = dtResult;

            if (dataGridView2.Columns["Toa"] != null) dataGridView2.Columns["Toa"].HeaderText = "Tòa (Loại)";
            if (dataGridView2.Columns["Phong"] != null) dataGridView2.Columns["Phong"].HeaderText = "Phòng";
            if (dataGridView2.Columns["Thang"] != null) dataGridView2.Columns["Thang"].HeaderText = "Tháng";
            if (dataGridView2.Columns["Nam"] != null) dataGridView2.Columns["Nam"].HeaderText = "Năm";
            if (dataGridView2.Columns["DoanhThu"] != null) 
            {
                dataGridView2.Columns["DoanhThu"].HeaderText = "Doanh thu";
                dataGridView2.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";
            }

            chart2.Series.Clear();
            Series series = new Series("Doanh Thu");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;

            var statsToa = dtResult.GroupBy(x => x.Toa)
                                   .Select(g => new { MaToa = g.Key, TongDT = g.Sum(x => x.DoanhThu) })
                                   .ToList();

            foreach (var item in statsToa)
            {
                series.Points.AddXY(item.MaToa ?? "Chưa rõ", item.TongDT);
            }
            chart2.Series.Add(series);

            var statsThang = dtResult.GroupBy(x => x.Thang)
                                     .Select(g => new { Thang = g.Key, TongDT = g.Sum(x => x.DoanhThu) })
                                     .OrderByDescending(x => x.TongDT)
                                     .FirstOrDefault();

            if (statsThang != null)
            {
                textBox1.Text = statsThang.Thang.ToString();
                textBox2.Text = statsThang.TongDT.ToString("N0") + " VNĐ";
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "0 VNĐ";
            }
        }

        private void btThongKeSVPhong_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpThongKeSVPhong;
        }

        private void btThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpThongKeDoanhThu;
        }

        private void btLocSVPhong_Click(object sender, EventArgs e)
        {
            pnThongKeSVPhong.Visible = !pnThongKeSVPhong.Visible;
        }

        private void tcBaoCaoThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnThongKeSVPhong.Visible = false;
        }

        private void btQuayVeTrangChu_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpTrangChu;
        }


    }
}
