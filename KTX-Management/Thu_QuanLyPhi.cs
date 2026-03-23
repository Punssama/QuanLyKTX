using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KTX_Management
{
    public partial class Thu_QuanLyPhi : Form
    {
        public Thu_QuanLyPhi()
        {
            InitializeComponent();
            // ẩn pthem
            pthem.Visible = false;
            // ẩn psuaxoa
            psuaxoa.Visible = false;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            // hiện pthem
            pthem.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ẩn pthem
            pthem.Visible = false;
        }
        private void btdatlai_Click(object sender, EventArgs e)
        {
            // Xóa TextBox trong groupBox1 (số điện)
            tbdc.Text = "";
            tbdm.Text = "";
            tbdtt.Text = "";

            // Xóa TextBox trong groupBox2 (số nước)
            tbnc.Text = "";
            tbnm.Text = "";
            tbntt.Text = "";

            // Xóa TextBox trong groupBox3 (tiền)
            tbtiendien.Text = "";
            tbtiennuoc.Text = "";
            tbtiendv.Text = "";
            tbtongtien.Text = "";

            // Xóa phòng nhập
            textBox6.Text = "";
            tbtienphong.Text = "";
            // Reset RadioButton
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // Reset ComboBox nếu muốn (nếu không muốn để lại giá trị hiện tại thì bỏ dòng này)
            cbtkphong.SelectedIndex = -1;
            cbtkthang.SelectedIndex = -1;
            cbtknam.SelectedIndex = -1;
            cbtktrangthai.SelectedIndex = -1;

            // Thông báo đã đặt lại
            MessageBox.Show("hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btluuthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ TextBox và RadioButton
                string phong = textBox6.Text; // phòng
                int tienphong = int.Parse(tbtienphong.Text);
                int sodien_cu = int.Parse(tbdc.Text);
                int sodien_moi = int.Parse(tbdm.Text);
                int sodien_tt = sodien_moi - sodien_cu;

                int sonuoc_cu = int.Parse(tbnc.Text);
                int sonuoc_moi = int.Parse(tbnm.Text);
                int sonuoc_tt = sonuoc_moi - sonuoc_cu;

                int tiendien = int.Parse(tbtiendien.Text);
                int tiennuoc = int.Parse(tbtiennuoc.Text);
                int tiendv = int.Parse(tbtiendv.Text);
                int tongtien = tiendien + tiennuoc + tiendv;

                string trangthai = radioButton1.Checked ? "Đã thanh toán" : "Chưa thanh toán";


                // Cập nhật TextBox tổng tiền
                tbtongtien.Text = tongtien.ToString();

                // Thêm dòng mới vào DataGridView
                dataGridView1.Rows.Add(
                    phong,
                    tienphong,
                    sodien_cu,
                    sodien_moi,
                    sodien_tt,
                    sonuoc_cu,
                    sonuoc_moi,
                    sonuoc_tt,
                    tiendv,
                    tongtien,
                    trangthai,
                    DateTime.Now.Month, // cột tháng
                    DateTime.Now.Year   // cột năm
                );

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TinhTien()
        {
            int dienCu = 0, dienMoi = 0;
            int nuocCu = 0, nuocMoi = 0;
            int tienDichVu = 50000;
            int tienphong = 0;

            int.TryParse(tbdc.Text, out dienCu);
            int.TryParse(tbdm.Text, out dienMoi);
            int.TryParse(tbnc.Text, out nuocCu);
            int.TryParse(tbnm.Text, out nuocMoi);
            int.TryParse(tbtienphong.Text, out tienphong);
            tbdtt.Text = (dienMoi - dienCu).ToString();
            tbntt.Text = (nuocMoi - nuocCu).ToString();

            int tienDien = (dienMoi - dienCu) * 3000; // ví dụ 3000 VND/kWh
            int tienNuoc = (nuocMoi - nuocCu) * 20000; // ví dụ 20000 VND/m3
            tbtiendv.Text = tienDichVu.ToString();
            tbtiendien.Text = tienDien.ToString();
            tbtiennuoc.Text = tienNuoc.ToString();
            tbtongtien.Text = (tienDien + tienNuoc + tienDichVu + tienphong).ToString();
        }

        private void tbdm_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void tbnm_TextChanged_1(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void tbtienphong_TextChanged(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btsuaxoa_Click(object sender, EventArgs e)
        {
            // hiện psuaxoa
            psuaxoa.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // ẩn psuaxoa
            psuaxoa.Visible = false;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DialogResult result = MessageBox.Show(
                "Bạn có muốn sửa dòng này không?",
                "Xác nhận sửa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            psuaxoa.Visible = true;

            if (pthem.Visible)
                pthem.Visible = false;

            var row = dataGridView1.Rows[e.RowIndex];

            tbsuatienphong.Text = row.Cells["Column13"].Value?.ToString() ?? "";
            tbsuaphong.Text = row.Cells["Column1"].Value?.ToString() ?? "";
            tbsuadiencu.Text = row.Cells["Column2"].Value?.ToString() ?? "";
            tbsuadienmoi.Text = row.Cells["Column3"].Value?.ToString() ?? "";
            tbsuadtt.Text = row.Cells["Column4"].Value?.ToString() ?? "";
            tbsuanuoccu.Text = row.Cells["Column5"].Value?.ToString() ?? "";
            tbsuanuocmoi.Text = row.Cells["Column6"].Value?.ToString() ?? "";
            tbsuantt.Text = row.Cells["Column7"].Value?.ToString() ?? "";

            string trangThai = row.Cells["Column10"].Value?.ToString() ?? "";

            radioButton4.Checked = trangThai.Equals("Đã thanh toán", StringComparison.OrdinalIgnoreCase);
            radioButton3.Checked = !radioButton4.Checked;

            tbsuathang.Text = row.Cells["Column11"].Value?.ToString() ?? "";
            tbsuanam.Text = row.Cells["Column12"].Value?.ToString() ?? "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy chỉ số dòng đang chọn
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                var row = dataGridView1.Rows[rowIndex];

                // Lấy dữ liệu từ form sửa
                string phong = tbsuaphong.Text;
                int dienCu = int.Parse(tbsuadiencu.Text);
                int dienMoi = int.Parse(tbsuadienmoi.Text);
                int dienTT = dienMoi - dienCu;

                int nuocCu = int.Parse(tbsuanuoccu.Text);
                int nuocMoi = int.Parse(tbsuanuocmoi.Text);
                int nuocTT = nuocMoi - nuocCu;

                int tienPhong = int.Parse(tbsuatienphong.Text);
                int tienDV = 50000;
                int tienDien = dienTT * 3000;
                int tienNuoc = nuocTT * 20000;
                int tongTien = tienPhong + tienDV + tienDien + tienNuoc;

                string trangThai = radioButton4.Checked ? "Đã thanh toán" : "Chưa thanh toán";
                int thang = int.Parse(tbsuathang.Text);
                int nam = int.Parse(tbsuanam.Text);

                // Cập nhật DataGridView
                row.Cells["Column1"].Value = phong;
                row.Cells["Column2"].Value = dienCu;
                row.Cells["Column3"].Value = dienMoi;
                row.Cells["Column4"].Value = dienTT;
                row.Cells["Column5"].Value = nuocCu;
                row.Cells["Column6"].Value = nuocMoi;
                row.Cells["Column7"].Value = nuocTT;
                row.Cells["Column8"].Value = tienDV;
                row.Cells["Column9"].Value = tongTien;
                row.Cells["Column10"].Value = trangThai;
                row.Cells["Column11"].Value = thang;
                row.Cells["Column12"].Value = nam;
                row.Cells["column13"].Value = tienPhong;
                // xác nhận trước khi cập nhật

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ẩn panel sửa/xóa sau khi cập nhật
                psuaxoa.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Xác nhận trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //xóa dòng đang chọn
                if (dataGridView1.CurrentCell != null)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // lay dữ liệu từ TextBox tìm kiếm
            string tkphong = cbtkphong.SelectedItem?.ToString() ?? "";
            string tkthang = cbtkthang.SelectedItem?.ToString() ?? "";
            string tknam = cbtknam.SelectedItem?.ToString() ?? "";
            string tktrangthai = cbtktrangthai.SelectedItem?.ToString() ?? "";
            // lọc dữ liệu trong DataGridView dựa trên điều kiện tìm kiếm
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool match = true;
                if (!string.IsNullOrEmpty(tkphong) && row.Cells["Column1"].Value?.ToString() != tkphong)
                    match = false;
                if (!string.IsNullOrEmpty(tkthang) && row.Cells["Column11"].Value?.ToString() != tkthang)
                    match = false;
                if (!string.IsNullOrEmpty(tknam) && row.Cells["Column12"].Value?.ToString() != tknam)
                    match = false;
                if (!string.IsNullOrEmpty(tktrangthai) && row.Cells["Column10"].Value?.ToString() != tktrangthai)
                    match = false;
                row.Visible = match;
            }
        }
    }
}

