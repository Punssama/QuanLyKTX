using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;

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

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            dtpNamDoanhThu.MaxDate = DateTime.Today;
        }
    }
}
