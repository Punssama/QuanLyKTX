using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTX_Management
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký đã được gửi, vui lòng chờ phản hồi từ quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterAccountNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
