using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTX_Management
{
    public partial class FormBaoCaoThongKe : Form
    {
        public FormBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void btThongKeSVPhong_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpThongKeSVPhong;
        }

        private void btThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpThongKeDoanhThu;
        }

        private void btThongKePhanAnh_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpThongKePhanAnh;
        }

        private void btLocSVPhong_Click(object sender, EventArgs e)
        {
            pnThongKeSVPhong.Visible = !pnThongKeSVPhong.Visible;
        }

        private void btLocDoanhThu_Click(object sender, EventArgs e)
        {
            pnThongKeDoanhThu.Visible = !pnThongKeDoanhThu.Visible;
        }

        private void btLocPhanAnh_Click(object sender, EventArgs e)
        {
            pnThongKePhanAnh.Visible = !pnThongKePhanAnh.Visible;
        }

        private void tcBaoCaoThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnThongKeSVPhong.Visible = false;
            pnThongKeDoanhThu.Visible = false;
            pnThongKePhanAnh.Visible = false;
        }

        private void btQuayVeTrangChu_Click(object sender, EventArgs e)
        {
            tcBaoCaoThongKe.SelectedTab = tpTrangChu;
        }
    }
}
