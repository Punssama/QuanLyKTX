namespace KTX_Management
{
    partial class quanlyphong
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
            splitContainer1 = new SplitContainer();
            button4 = new Button();
            textBox4 = new TextBox();
            button3 = new Button();
            comboBox4 = new ComboBox();
            label7 = new Label();
            BTxoa = new Button();
            button1 = new Button();
            button2 = new Button();
            splitContainer2 = new SplitContainer();
            txtTrangThai = new TextBox();
            cboLoaiPhong = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cboSucChua = new ComboBox();
            label4 = new Label();
            txtSoNguoi = new TextBox();
            label3 = new Label();
            txtTenPhong = new TextBox();
            label2 = new Label();
            txtMaPhong = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(textBox4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(comboBox4);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(BTxoa);
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(button2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1293, 640);
            splitContainer1.SplitterDistance = 166;
            splitContainer1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(1141, 62);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 7;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(929, 65);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 31);
            textBox4.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(38, 30);
            button3.Name = "button3";
            button3.Size = new Size(152, 34);
            button3.TabIndex = 5;
            button3.Text = "<- Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Mã phòng", "Tên phòng", "Loại phòng", "Số người" });
            comboBox4.Location = new Point(929, 120);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 33);
            comboBox4.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(839, 71);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 3;
            label7.Text = "Tìm kiếm";
            // 
            // BTxoa
            // 
            BTxoa.Location = new Point(452, 119);
            BTxoa.Name = "BTxoa";
            BTxoa.Size = new Size(112, 34);
            BTxoa.TabIndex = 2;
            BTxoa.Text = "Xóa";
            BTxoa.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(13, 119);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 0;
            button1.Text = "Thêm sinh viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(219, 119);
            button2.Name = "button2";
            button2.Size = new Size(176, 34);
            button2.TabIndex = 1;
            button2.Text = "Chuyển phòng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtTrangThai);
            splitContainer2.Panel1.Controls.Add(cboLoaiPhong);
            splitContainer2.Panel1.Controls.Add(label6);
            splitContainer2.Panel1.Controls.Add(label5);
            splitContainer2.Panel1.Controls.Add(cboSucChua);
            splitContainer2.Panel1.Controls.Add(label4);
            splitContainer2.Panel1.Controls.Add(txtSoNguoi);
            splitContainer2.Panel1.Controls.Add(label3);
            splitContainer2.Panel1.Controls.Add(txtTenPhong);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(txtMaPhong);
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Paint += splitContainer2_Panel1_Paint;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dataGridView1);
            splitContainer2.Size = new Size(1293, 470);
            splitContainer2.SplitterDistance = 366;
            splitContainer2.TabIndex = 0;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(120, 385);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.ReadOnly = true;
            txtTrangThai.Size = new Size(182, 31);
            txtTrangThai.TabIndex = 11;
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboLoaiPhong.Location = new Point(120, 318);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(182, 33);
            cboLoaiPhong.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 388);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 9;
            label6.Text = "Trạng thái";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 321);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 8;
            label5.Text = "Loại phòng";
            // 
            // cboSucChua
            // 
            cboSucChua.FormattingEnabled = true;
            cboSucChua.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cboSucChua.Location = new Point(120, 250);
            cboSucChua.Name = "cboSucChua";
            cboSucChua.Size = new Size(182, 33);
            cboSucChua.TabIndex = 7;
            cboSucChua.SelectedIndexChanged += cboSucChua_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 171);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 6;
            label4.Text = "Số người";
            // 
            // txtSoNguoi
            // 
            txtSoNguoi.Location = new Point(120, 165);
            txtSoNguoi.Name = "txtSoNguoi";
            txtSoNguoi.Size = new Size(182, 31);
            txtSoNguoi.TabIndex = 5;
            txtSoNguoi.Leave += txtSoNguoi_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 250);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Sức chứa";
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new Point(120, 101);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new Size(182, 31);
            txtTenPhong.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 101);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên phòng";
            // 
            // txtMaPhong
            // 
            txtMaPhong.Location = new Point(120, 30);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.Size = new Size(182, 31);
            txtMaPhong.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 30);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã phòng";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(923, 470);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "maPhong";
            Column1.HeaderText = "Mã phòng";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "tenPhong";
            Column2.HeaderText = "Tên phòng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "loaiPhong";
            Column3.HeaderText = "Loại phòng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "sucChua";
            Column4.HeaderText = "Sức chứa";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "soNguoi";
            Column5.HeaderText = "Số người";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "trangThai";
            Column6.HeaderText = "Trạng thái";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.Width = 150;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // quanlyphong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 640);
            Controls.Add(splitContainer1);
            Name = "quanlyphong";
            Text = "quanlyphong";
            Load += quanlyphong_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button button1;
        private Button button2;
        private Button Xóa;
        private Label label4;
        private TextBox txtSoNguoi;
        private Label label3;
        private TextBox txtTenPhong;
        private Label label2;
        private TextBox txtMaPhong;
        private Label label1;
        private ComboBox cboLoaiPhong;
        private Label label6;
        private Label label5;
        private ComboBox cboSucChua;
        private DataGridView dataGridView1;
        private Label label7;
        private ComboBox comboBox4;
        private NotifyIcon notifyIcon1;
        private Button button3;
        private Button BTxoa;
        private TextBox textBox4;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox textBox1;
        private TextBox txtTrangThai;
    }
}