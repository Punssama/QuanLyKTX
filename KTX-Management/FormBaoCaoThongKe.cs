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

        public FormBaoCaoThongKe()
        {
            InitializeComponent();
            this.Load += FormBaoCaoThongKe_Load;

            button11.Click += Button11_Click;
            button9.Click += Button9_Click;
        }

        private async void Button11_Click(object? sender, EventArgs e)
        {
            await LoadThongKeDoanhThuAsync(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private async void Button9_Click(object? sender, EventArgs e)
        {
            await LoadThongKeDoanhThuAsync(null, null);
        }

        private async void FormBaoCaoThongKe_Load(object? sender, EventArgs e)
        {
            await LoadThongKeSinhVienAsync();
            await LoadThongKeDoanhThuAsync(null, null);
        }

        private async Task LoadThongKeSinhVienAsync()
        {
            try
            {
                var url = "api/BaoCaoThongKe/thong-ke-sinh-vien";
                var data = await client.GetFromJsonAsync<List<ThongKeSinhVienToaDTO>>(url);
                if (data != null && chart1 != null)
                {
                    chart1.Series.Clear();
                    Series series = new Series("Số Sinh Viên");
                    series.ChartType = SeriesChartType.Column;

                    foreach (var item in data)
                    {
                        series.Points.AddXY(item.MaToa ?? "Chưa rõ", item.TongSoSinhVien);
                    }
                    chart1.Series.Add(series);
                    chart1.ChartAreas[0].AxisX.Title = "Tòa";
                    chart1.ChartAreas[0].AxisY.Title = "Tổng số sinh viên";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu thống kê sinh viên: " + ex.Message);
            }
        }

        private async Task LoadThongKeDoanhThuAsync(DateTime? tuNgay, DateTime? denNgay)
        {
            try
            {
                var url = "api/BaoCaoThongKe/thong-ke-doanh-thu";
                if (tuNgay.HasValue && denNgay.HasValue)
                {
                    // Lấy ngày đầu của tháng đầu và ngày cuối của tháng cuối do CustomFormat là "MM/yyyy"
                    var start = new DateTime(tuNgay.Value.Year, tuNgay.Value.Month, 1);
                    var end = new DateTime(denNgay.Value.Year, denNgay.Value.Month, DateTime.DaysInMonth(denNgay.Value.Year, denNgay.Value.Month));
                    url += $"?tuNgay={start:yyyy-MM-dd}&denNgay={end:yyyy-MM-dd}";
                }

                var data = await client.GetFromJsonAsync<List<ThongKeDoanhThuToaDTO>>(url);
                if (data != null && chart2 != null)
                {
                    chart2.Series.Clear();
                    Series series = new Series("Doanh Thu");
                    series.ChartType = SeriesChartType.Pie;
                    series.IsValueShownAsLabel = true;

                    foreach (var item in data)
                    {
                        series.Points.AddXY(item.MaToa ?? "Chưa rõ", item.TongDoanhThu);
                    }
                    chart2.Series.Add(series);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu thống kê doanh thu: " + ex.Message);
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

        private void btLocDoanhThu_Click(object sender, EventArgs e)
        {
            pnThongKeDoanhThu.Visible = !pnThongKeDoanhThu.Visible;
        }

        private void tcBaoCaoThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnThongKeSVPhong.Visible = false;
            pnThongKeDoanhThu.Visible = false;
        }

        private void btQuayVeTrangChu_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpTrangChu;
        }
    }
}
