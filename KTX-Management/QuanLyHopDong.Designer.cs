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
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(374, 48);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Hợp Đồng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 116);
            label2.Name = "label2";
            label2.Size = new Size(225, 32);
            label2.TabIndex = 1;
            label2.Text = "Tìm kiếm hợp đồng";
            // 
            // TenSVtxb
            // 
            TenSVtxb.Location = new Point(158, 177);
            TenSVtxb.Name = "TenSVtxb";
            TenSVtxb.Size = new Size(489, 35);
            TenSVtxb.TabIndex = 2;
            // 
            // rdbtnTImKiemNangCao
            // 
            rdbtnTImKiemNangCao.AutoSize = true;
            rdbtnTImKiemNangCao.Location = new Point(686, 178);
            rdbtnTImKiemNangCao.Name = "rdbtnTImKiemNangCao";
            rdbtnTImKiemNangCao.Size = new Size(214, 34);
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
            BangTimKiemNangCao.Location = new Point(158, 232);
            BangTimKiemNangCao.Name = "BangTimKiemNangCao";
            BangTimKiemNangCao.Size = new Size(742, 313);
            BangTimKiemNangCao.TabIndex = 4;
            BangTimKiemNangCao.TabStop = false;
            // 
            // rdbtnCtNotAvail
            // 
            rdbtnCtNotAvail.AutoSize = true;
            rdbtnCtNotAvail.Location = new Point(469, 170);
            rdbtnCtNotAvail.Name = "rdbtnCtNotAvail";
            rdbtnCtNotAvail.Size = new Size(138, 34);
            rdbtnCtNotAvail.TabIndex = 10;
            rdbtnCtNotAvail.TabStop = true;
            rdbtnCtNotAvail.Text = "Không còn";
            rdbtnCtNotAvail.UseVisualStyleBackColor = true;
            // 
            // rdbtnCtAvail
            // 
            rdbtnCtAvail.AutoSize = true;
            rdbtnCtAvail.Location = new Point(469, 100);
            rdbtnCtAvail.Name = "rdbtnCtAvail";
            rdbtnCtAvail.Size = new Size(114, 34);
            rdbtnCtAvail.TabIndex = 9;
            rdbtnCtAvail.TabStop = true;
            rdbtnCtAvail.Text = "Vẫn còn";
            rdbtnCtAvail.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(444, 44);
            label7.Name = "label7";
            label7.Size = new Size(280, 30);
            label7.TabIndex = 8;
            label7.Text = "Tình trạng hợp đồng hiện tại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 246);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 7;
            label6.Text = "Số phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 174);
            label5.Name = "label5";
            label5.Size = new Size(94, 30);
            label5.TabIndex = 6;
            label5.Text = "Ngày ký ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 104);
            label4.Name = "label4";
            label4.Size = new Size(140, 30);
            label4.TabIndex = 5;
            label4.Text = "Mã hợp đồng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 39);
            label3.Name = "label3";
            label3.Size = new Size(131, 30);
            label3.TabIndex = 4;
            label3.Text = "Mã sinh viên";
            // 
            // txbRoomNumber
            // 
            txbRoomNumber.Location = new Point(208, 243);
            txbRoomNumber.Name = "txbRoomNumber";
            txbRoomNumber.Size = new Size(175, 35);
            txbRoomNumber.TabIndex = 3;
            txbRoomNumber.TextChanged += textBox4_TextChanged;
            // 
            // txbSignedDate
            // 
            txbSignedDate.Location = new Point(208, 171);
            txbSignedDate.Name = "txbSignedDate";
            txbSignedDate.Size = new Size(175, 35);
            txbSignedDate.TabIndex = 2;
            txbSignedDate.TextChanged += textBox3_TextChanged;
            // 
            // txbContractNumber
            // 
            txbContractNumber.Location = new Point(208, 101);
            txbContractNumber.Name = "txbContractNumber";
            txbContractNumber.Size = new Size(175, 35);
            txbContractNumber.TabIndex = 1;
            // 
            // txbMSV
            // 
            txbMSV.Location = new Point(208, 39);
            txbMSV.Name = "txbMSV";
            txbMSV.Size = new Size(175, 35);
            txbMSV.TabIndex = 0;
            // 
            // btnSearchHD
            // 
            btnSearchHD.Location = new Point(955, 143);
            btnSearchHD.Name = "btnSearchHD";
            btnSearchHD.Size = new Size(170, 104);
            btnSearchHD.TabIndex = 5;
            btnSearchHD.Text = "Tìm kiếm";
            btnSearchHD.UseVisualStyleBackColor = true;
            btnSearchHD.Click += btnSearchHD_Click;
            // 
            // btnDeleteKeyWords
            // 
            btnDeleteKeyWords.Location = new Point(955, 297);
            btnDeleteKeyWords.Name = "btnDeleteKeyWords";
            btnDeleteKeyWords.Size = new Size(170, 105);
            btnDeleteKeyWords.TabIndex = 6;
            btnDeleteKeyWords.Text = "Xóa từ khóa";
            btnDeleteKeyWords.UseVisualStyleBackColor = true;
            btnDeleteKeyWords.Click += btnDeleteKeyWords_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(57, 483);
            label8.Name = "label8";
            label8.Size = new Size(197, 32);
            label8.TabIndex = 7;
            label8.Text = "Kết quả tìm kiếm";
            // 
            // btnOutQLHD
            // 
            btnOutQLHD.Location = new Point(1172, 12);
            btnOutQLHD.Name = "btnOutQLHD";
            btnOutQLHD.Size = new Size(131, 40);
            btnOutQLHD.TabIndex = 8;
            btnOutQLHD.Text = "Thoát";
            btnOutQLHD.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 518);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1300, 262);
            dataGridView1.TabIndex = 9;
            // 
            // QuanLyHopDong
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 784);
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
            Name = "QuanLyHopDong";
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