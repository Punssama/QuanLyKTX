namespace KTX_Management
{
    partial class ThemTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControlQuanLyTaiKhoan = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            MatKhauTb = new TextBox();
            IDLb = new Label();
            ThemTaiKhoanBtn = new Button();
            TenDangNhapTb = new TextBox();
            IDTb = new TextBox();
            MatKhauLb = new Label();
            TenDangNhapLb = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnXoaTk = new Button();
            btnHienTatCa = new Button();
            roleLb = new Label();
            roleTb = new TextBox();
            tabControlQuanLyTaiKhoan.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlQuanLyTaiKhoan
            // 
            tabControlQuanLyTaiKhoan.Controls.Add(tabPage1);
            tabControlQuanLyTaiKhoan.Controls.Add(tabPage2);
            tabControlQuanLyTaiKhoan.Dock = DockStyle.Fill;
            tabControlQuanLyTaiKhoan.Location = new Point(0, 0);
            tabControlQuanLyTaiKhoan.Name = "tabControlQuanLyTaiKhoan";
            tabControlQuanLyTaiKhoan.SelectedIndex = 0;
            tabControlQuanLyTaiKhoan.Size = new Size(800, 450);
            tabControlQuanLyTaiKhoan.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(roleTb);
            tabPage1.Controls.Add(MatKhauTb);
            tabPage1.Controls.Add(IDLb);
            tabPage1.Controls.Add(ThemTaiKhoanBtn);
            tabPage1.Controls.Add(TenDangNhapTb);
            tabPage1.Controls.Add(roleLb);
            tabPage1.Controls.Add(IDTb);
            tabPage1.Controls.Add(MatKhauLb);
            tabPage1.Controls.Add(TenDangNhapLb);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thêm tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Xoá tài khoản";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MatKhauTb
            // 
            MatKhauTb.Font = new Font("Segoe UI", 16.2F);
            MatKhauTb.Location = new Point(357, 202);
            MatKhauTb.Name = "MatKhauTb";
            MatKhauTb.Size = new Size(197, 43);
            MatKhauTb.TabIndex = 13;
            // 
            // IDLb
            // 
            IDLb.AutoSize = true;
            IDLb.Font = new Font("Segoe UI", 16.2F);
            IDLb.Location = new Point(228, 93);
            IDLb.Name = "IDLb";
            IDLb.Size = new Size(50, 38);
            IDLb.TabIndex = 12;
            IDLb.Text = "ID:";
            // 
            // ThemTaiKhoanBtn
            // 
            ThemTaiKhoanBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThemTaiKhoanBtn.Location = new Point(388, 323);
            ThemTaiKhoanBtn.Name = "ThemTaiKhoanBtn";
            ThemTaiKhoanBtn.Size = new Size(110, 39);
            ThemTaiKhoanBtn.TabIndex = 11;
            ThemTaiKhoanBtn.Text = "Thêm";
            ThemTaiKhoanBtn.UseVisualStyleBackColor = true;
            // 
            // TenDangNhapTb
            // 
            TenDangNhapTb.Font = new Font("Segoe UI", 16.2F);
            TenDangNhapTb.Location = new Point(357, 151);
            TenDangNhapTb.Name = "TenDangNhapTb";
            TenDangNhapTb.Size = new Size(197, 43);
            TenDangNhapTb.TabIndex = 10;
            // 
            // IDTb
            // 
            IDTb.Font = new Font("Segoe UI", 16.2F);
            IDTb.Location = new Point(357, 90);
            IDTb.Name = "IDTb";
            IDTb.Size = new Size(197, 43);
            IDTb.TabIndex = 9;
            // 
            // MatKhauLb
            // 
            MatKhauLb.AutoSize = true;
            MatKhauLb.Font = new Font("Segoe UI", 16.2F);
            MatKhauLb.Location = new Point(182, 205);
            MatKhauLb.Name = "MatKhauLb";
            MatKhauLb.Size = new Size(139, 38);
            MatKhauLb.TabIndex = 8;
            MatKhauLb.Text = "Mật khẩu:";
            // 
            // TenDangNhapLb
            // 
            TenDangNhapLb.AutoSize = true;
            TenDangNhapLb.Font = new Font("Segoe UI", 16.2F);
            TenDangNhapLb.Location = new Point(145, 154);
            TenDangNhapLb.Name = "TenDangNhapLb";
            TenDangNhapLb.Size = new Size(206, 38);
            TenDangNhapLb.TabIndex = 7;
            TenDangNhapLb.Text = "Tên đăng nhập:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(786, 411);
            splitContainer1.SplitterDistance = 343;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(786, 343);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnHienTatCa);
            flowLayoutPanel1.Controls.Add(btnXoaTk);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(786, 64);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnXoaTk
            // 
            btnXoaTk.Location = new Point(103, 3);
            btnXoaTk.Name = "btnXoaTk";
            btnXoaTk.Size = new Size(120, 29);
            btnXoaTk.TabIndex = 0;
            btnXoaTk.Text = "Xoá tài khoản";
            btnXoaTk.UseVisualStyleBackColor = true;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.Location = new Point(3, 3);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(94, 29);
            btnHienTatCa.TabIndex = 1;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = true;
            // 
            // roleLb
            // 
            roleLb.AutoSize = true;
            roleLb.Font = new Font("Segoe UI", 16.2F);
            roleLb.Location = new Point(216, 256);
            roleLb.Name = "roleLb";
            roleLb.Size = new Size(105, 38);
            roleLb.TabIndex = 8;
            roleLb.Text = "Quyền:";
            // 
            // roleTb
            // 
            roleTb.Font = new Font("Segoe UI", 16.2F);
            roleTb.Location = new Point(357, 251);
            roleTb.Name = "roleTb";
            roleTb.Size = new Size(197, 43);
            roleTb.TabIndex = 13;
            // 
            // ThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlQuanLyTaiKhoan);
            Name = "ThemTaiKhoan";
            Text = "ThemTaiKhoan";
            tabControlQuanLyTaiKhoan.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlQuanLyTaiKhoan;
        private TabPage tabPage1;
        private TextBox MatKhauTb;
        private Label IDLb;
        private Button ThemTaiKhoanBtn;
        private TextBox TenDangNhapTb;
        private TextBox IDTb;
        private Label MatKhauLb;
        private Label TenDangNhapLb;
        private TabPage tabPage2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox roleTb;
        private Label roleLb;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHienTatCa;
        private Button btnXoaTk;
    }
}