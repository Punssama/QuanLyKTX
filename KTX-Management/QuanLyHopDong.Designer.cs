namespace KTX_Management
{
    partial class QuanLyHopDong
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
            label1 = new Label();
            label2 = new Label();
            TenSVtxb = new TextBox();
            rdbtnTImKiemNangCao = new RadioButton();
            BangTimKiemNangCao = new GroupBox();
            rdbtnCtNotAvail = new RadioButton();
            rdbtnCtAvail = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txbRoomNumber = new TextBox();
            txbSignedDate = new TextBox();
            txbContractNumber = new TextBox();
            txbMSV = new TextBox();
            btnSearchHD = new Button();
            btnDeleteKeyWords = new Button();
            label8 = new Label();
            btnOutQLHD = new Button();
            dataGridView1 = new DataGridView();
            BangTimKiemNangCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 36);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Hợp Đồng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 77);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm hợp đồng";
            // 
            // TenSVtxb
            // 
            TenSVtxb.Location = new Point(105, 118);
            TenSVtxb.Margin = new Padding(2, 2, 2, 2);
            TenSVtxb.Name = "TenSVtxb";
            TenSVtxb.Size = new Size(327, 27);
            TenSVtxb.TabIndex = 2;
            // 
            // rdbtnTImKiemNangCao
            // 
            rdbtnTImKiemNangCao.AutoSize = true;
            rdbtnTImKiemNangCao.Location = new Point(457, 119);
            rdbtnTImKiemNangCao.Margin = new Padding(2, 2, 2, 2);
            rdbtnTImKiemNangCao.Name = "rdbtnTImKiemNangCao";
            rdbtnTImKiemNangCao.Size = new Size(156, 24);
            rdbtnTImKiemNangCao.TabIndex = 3;
            rdbtnTImKiemNangCao.TabStop = true;
            rdbtnTImKiemNangCao.Text = "Tìm kiếm nâng cao";
            rdbtnTImKiemNangCao.UseVisualStyleBackColor = true;
            rdbtnTImKiemNangCao.CheckedChanged += rdbtnTImKiemNangCao_CheckedChanged;
            // 
            // BangTimKiemNangCao
            // 
            BangTimKiemNangCao.Controls.Add(rdbtnCtNotAvail);
            BangTimKiemNangCao.Controls.Add(rdbtnCtAvail);
            BangTimKiemNangCao.Controls.Add(label7);
            BangTimKiemNangCao.Controls.Add(label6);
            BangTimKiemNangCao.Controls.Add(label5);
            BangTimKiemNangCao.Controls.Add(label4);
            BangTimKiemNangCao.Controls.Add(label3);
            BangTimKiemNangCao.Controls.Add(txbRoomNumber);
            BangTimKiemNangCao.Controls.Add(txbSignedDate);
            BangTimKiemNangCao.Controls.Add(txbContractNumber);
            BangTimKiemNangCao.Controls.Add(txbMSV);
            BangTimKiemNangCao.Location = new Point(105, 155);
            BangTimKiemNangCao.Margin = new Padding(2, 2, 2, 2);
            BangTimKiemNangCao.Name = "BangTimKiemNangCao";
            BangTimKiemNangCao.Padding = new Padding(2, 2, 2, 2);
            BangTimKiemNangCao.Size = new Size(495, 209);
            BangTimKiemNangCao.TabIndex = 4;
            BangTimKiemNangCao.TabStop = false;
            // 
            // rdbtnCtNotAvail
            // 
            rdbtnCtNotAvail.AutoSize = true;
            rdbtnCtNotAvail.Location = new Point(313, 113);
            rdbtnCtNotAvail.Margin = new Padding(2, 2, 2, 2);
            rdbtnCtNotAvail.Name = "rdbtnCtNotAvail";
            rdbtnCtNotAvail.Size = new Size(101, 24);
            rdbtnCtNotAvail.TabIndex = 10;
            rdbtnCtNotAvail.TabStop = true;
            rdbtnCtNotAvail.Text = "Không còn";
            rdbtnCtNotAvail.UseVisualStyleBackColor = true;
            // 
            // rdbtnCtAvail
            // 
            rdbtnCtAvail.AutoSize = true;
            rdbtnCtAvail.Location = new Point(313, 67);
            rdbtnCtAvail.Margin = new Padding(2, 2, 2, 2);
            rdbtnCtAvail.Name = "rdbtnCtAvail";
            rdbtnCtAvail.Size = new Size(83, 24);
            rdbtnCtAvail.TabIndex = 9;
            rdbtnCtAvail.TabStop = true;
            rdbtnCtAvail.Text = "Vẫn còn";
            rdbtnCtAvail.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 29);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(198, 20);
            label7.TabIndex = 8;
            label7.Text = "Tình trạng hợp đồng hiện tại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 164);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 7;
            label6.Text = "Số phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 116);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 6;
            label5.Text = "Ngày ký ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 69);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 5;
            label4.Text = "Mã hợp đồng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 26);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Mã sinh viên";
            // 
            // txbRoomNumber
            // 
            txbRoomNumber.Location = new Point(139, 162);
            txbRoomNumber.Margin = new Padding(2, 2, 2, 2);
            txbRoomNumber.Name = "txbRoomNumber";
            txbRoomNumber.Size = new Size(118, 27);
            txbRoomNumber.TabIndex = 3;
            txbRoomNumber.TextChanged += textBox4_TextChanged;
            // 
            // txbSignedDate
            // 
            txbSignedDate.Location = new Point(139, 114);
            txbSignedDate.Margin = new Padding(2, 2, 2, 2);
            txbSignedDate.Name = "txbSignedDate";
            txbSignedDate.Size = new Size(118, 27);
            txbSignedDate.TabIndex = 2;
            txbSignedDate.TextChanged += textBox3_TextChanged;
            // 
            // txbContractNumber
            // 
            txbContractNumber.Location = new Point(139, 67);
            txbContractNumber.Margin = new Padding(2, 2, 2, 2);
            txbContractNumber.Name = "txbContractNumber";
            txbContractNumber.Size = new Size(118, 27);
            txbContractNumber.TabIndex = 1;
            // 
            // txbMSV
            // 
            txbMSV.Location = new Point(139, 26);
            txbMSV.Margin = new Padding(2, 2, 2, 2);
            txbMSV.Name = "txbMSV";
            txbMSV.Size = new Size(118, 27);
            txbMSV.TabIndex = 0;
            // 
            // btnSearchHD
            // 
            btnSearchHD.Location = new Point(637, 95);
            btnSearchHD.Margin = new Padding(2, 2, 2, 2);
            btnSearchHD.Name = "btnSearchHD";
            btnSearchHD.Size = new Size(113, 69);
            btnSearchHD.TabIndex = 5;
            btnSearchHD.Text = "Tìm kiếm";
            btnSearchHD.UseVisualStyleBackColor = true;
            btnSearchHD.Click += btnSearchHD_Click;
            // 
            // btnDeleteKeyWords
            // 
            btnDeleteKeyWords.Location = new Point(637, 198);
            btnDeleteKeyWords.Margin = new Padding(2, 2, 2, 2);
            btnDeleteKeyWords.Name = "btnDeleteKeyWords";
            btnDeleteKeyWords.Size = new Size(113, 70);
            btnDeleteKeyWords.TabIndex = 6;
            btnDeleteKeyWords.Text = "Xóa từ khóa";
            btnDeleteKeyWords.UseVisualStyleBackColor = true;
            btnDeleteKeyWords.Click += btnDeleteKeyWords_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 322);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 7;
            label8.Text = "Kết quả tìm kiếm";
            // 
            // btnOutQLHD
            // 
            btnOutQLHD.Location = new Point(781, 8);
            btnOutQLHD.Margin = new Padding(2, 2, 2, 2);
            btnOutQLHD.Name = "btnOutQLHD";
            btnOutQLHD.Size = new Size(87, 27);
            btnOutQLHD.TabIndex = 8;
            btnOutQLHD.Text = "Thoát";
            btnOutQLHD.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 345);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(867, 175);
            dataGridView1.TabIndex = 9;
            // 
            // QuanLyHopDong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 523);
            Controls.Add(dataGridView1);
            Controls.Add(btnOutQLHD);
            Controls.Add(label8);
            Controls.Add(btnDeleteKeyWords);
            Controls.Add(btnSearchHD);
            Controls.Add(BangTimKiemNangCao);
            Controls.Add(rdbtnTImKiemNangCao);
            Controls.Add(TenSVtxb);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "QuanLyHopDong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QuanLyHopDong";
            BangTimKiemNangCao.ResumeLayout(false);
            BangTimKiemNangCao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TenSVtxb;
        private RadioButton rdbtnTImKiemNangCao;
        private GroupBox BangTimKiemNangCao;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txbRoomNumber;
        private TextBox txbSignedDate;
        private TextBox txbContractNumber;
        private TextBox txbMSV;
        private Button btnSearchHD;
        private RadioButton rdbtnCtNotAvail;
        private RadioButton rdbtnCtAvail;
        private Label label7;
        private Button btnDeleteKeyWords;
        private Label label8;
        private Button btnOutQLHD;
        private DataGridView dataGridView1;
    }
}