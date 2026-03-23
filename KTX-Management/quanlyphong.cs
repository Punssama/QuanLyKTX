using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTX_Management
{
    public partial class quanlyphong : Form
    {
        public BindingList<Phong> listPhong = new BindingList<Phong>();
        int soNguoi;
        int sucChua;
        public quanlyphong()
        {
            InitializeComponent();
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text) || string.IsNullOrEmpty(txtTenPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtTrangThai.Text == "Còn trống" || txtTrangThai.Text == "Đầy")
            {
                Phong p = new Phong();
                p.maPhong = Convert.ToInt32(txtMaPhong.Text);
                p.tenPhong = txtTenPhong.Text;
                p.soNguoi = Convert.ToInt32(txtSoNguoi.Text);
                p.loaiPhong = cboLoaiPhong.Text;
                p.sucChua = Convert.ToInt32(cboSucChua.Text);
                p.trangThai = txtTrangThai.Text;

                listPhong.Add(p);

                txtMaPhong.Clear();
                txtSoNguoi.Clear();
                txtTenPhong.Clear();
                cboSucChua.SelectedIndex = -1;
                cboLoaiPhong.SelectedIndex = -1;
                txtTrangThai.Clear();
            }
            else
            {
                MessageBox.Show("Số người hiện tại không được vượt quá sức chứa của phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = listPhong;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanlyphong_Load(object sender, EventArgs e)
        {

        }

        private void cboSucChua_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sucChua = Convert.ToInt32(cboSucChua.SelectedItem);
                if (sucChua > soNguoi)
                {
                    txtTrangThai.Text = "Còn trống";
                }
                else if (sucChua == soNguoi)
                {
                    txtTrangThai.Text = "Đầy";
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
                soNguoi = Convert.ToInt32(txtSoNguoi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số người phải là một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoNguoi.Clear();
            }
        }
    }
}