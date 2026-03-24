using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTX_Management
{
    public partial class HopDongKTX : Form
    {
        public HopDongKTX()
        {
            InitializeComponent();
        }

        private void HopDongKTX_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Thông tin sẽ bị xóa. Bạn có muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Người dùng chọn Thoát
                this.Close();
            }
            else
            {
                // Người dùng chọn Ở lại
                // Không làm gì, quay lại form
            }
        }

        private void HdktxTaoHopDong_Click(object sender, EventArgs e)
        {
            // Thực hiện logic tạo hợp đồng ở đây
            // ...

            // Sau khi tạo thành công, hiện thông báo
            MessageBox.Show(
                "Hợp đồng đã được tạo thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }


}

