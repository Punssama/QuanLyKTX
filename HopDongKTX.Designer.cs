namespace KTX_Management
{
    partial class HopDongKTX
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            HdtxTxbName = new TextBox();
            HdtxTxbCCCD = new TextBox();
            HdktxAddress = new TextBox();
            HdtxTxbMSV = new TextBox();
            HdktxTimeout = new ComboBox();
            HdktxTimeBorn = new DateTimePicker();
            HdktxTimein = new DateTimePicker();
            HdktxBtnMale = new RadioButton();
            HdktxBtnFemale = new RadioButton();
            HdktxLogout = new Button();
            HdktxTaoHopDong = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 75);
            label1.Name = "label1";
            label1.Size = new Size(525, 38);
            label1.TabIndex = 0;
            label1.Text = "Hợp đồng ở ký túc xá cho sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 196);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 1;
            label2.Text = "Họ tên sinh viên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 255);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 2;
            label3.Text = "Mã căn cước công dân";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 316);
            label4.Name = "label4";
            label4.Size = new Size(131, 30);
            label4.TabIndex = 3;
            label4.Text = "Mã sinh viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 380);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 447);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 5;
            label6.Text = "Năm sinh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 517);
            label7.Name = "label7";
            label7.Size = new Size(183, 30);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ thường trú";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(119, 587);
            label8.Name = "label8";
            label8.Size = new Size(172, 30);
            label8.TabIndex = 7;
            label8.Text = "Thời gian vào ktx";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(119, 653);
            label9.Name = "label9";
            label9.Size = new Size(114, 30);
            label9.TabIndex = 8;
            label9.Text = "Thời hạn ở";
            // 
            // HdtxTxbName
            // 
            HdtxTxbName.Location = new Point(394, 193);
            HdtxTxbName.Name = "HdtxTxbName";
            HdtxTxbName.Size = new Size(292, 35);
            HdtxTxbName.TabIndex = 9;
            // 
            // HdtxTxbCCCD
            // 
            HdtxTxbCCCD.Location = new Point(394, 252);
            HdtxTxbCCCD.Name = "HdtxTxbCCCD";
            HdtxTxbCCCD.Size = new Size(292, 35);
            HdtxTxbCCCD.TabIndex = 10;
            // 
            // HdktxAddress
            // 
            HdktxAddress.Location = new Point(394, 514);
            HdktxAddress.Name = "HdktxAddress";
            HdktxAddress.Size = new Size(292, 35);
            HdktxAddress.TabIndex = 14;
            // 
            // HdtxTxbMSV
            // 
            HdtxTxbMSV.Location = new Point(394, 313);
            HdtxTxbMSV.Name = "HdtxTxbMSV";
            HdtxTxbMSV.Size = new Size(292, 35);
            HdtxTxbMSV.TabIndex = 15;
            // 
            // HdktxTimeout
            // 
            HdktxTimeout.FormattingEnabled = true;
            HdktxTimeout.Items.AddRange(new object[] { "1 năm", "2 năm", "3 năm", "4 năm", "4,5 năm" });
            HdktxTimeout.Location = new Point(394, 650);
            HdktxTimeout.Name = "HdktxTimeout";
            HdktxTimeout.Size = new Size(292, 38);
            HdktxTimeout.TabIndex = 16;
            // 
            // HdktxTimeBorn
            // 
            HdktxTimeBorn.Location = new Point(389, 443);
            HdktxTimeBorn.Name = "HdktxTimeBorn";
            HdktxTimeBorn.Size = new Size(348, 35);
            HdktxTimeBorn.TabIndex = 17;
            // 
            // HdktxTimein
            // 
            HdktxTimein.Location = new Point(389, 583);
            HdktxTimein.Name = "HdktxTimein";
            HdktxTimein.Size = new Size(348, 35);
            HdktxTimein.TabIndex = 18;
            // 
            // HdktxBtnMale
            // 
            HdktxBtnMale.AutoSize = true;
            HdktxBtnMale.Location = new Point(394, 378);
            HdktxBtnMale.Name = "HdktxBtnMale";
            HdktxBtnMale.Size = new Size(83, 34);
            HdktxBtnMale.TabIndex = 19;
            HdktxBtnMale.TabStop = true;
            HdktxBtnMale.Text = "Nam";
            HdktxBtnMale.UseVisualStyleBackColor = true;
            // 
            // HdktxBtnFemale
            // 
            HdktxBtnFemale.AutoSize = true;
            HdktxBtnFemale.Location = new Point(548, 378);
            HdktxBtnFemale.Name = "HdktxBtnFemale";
            HdktxBtnFemale.Size = new Size(66, 34);
            HdktxBtnFemale.TabIndex = 20;
            HdktxBtnFemale.TabStop = true;
            HdktxBtnFemale.Text = "Nữ";
            HdktxBtnFemale.UseVisualStyleBackColor = true;
            // 
            // HdktxLogout
            // 
            HdktxLogout.Location = new Point(1129, 12);
            HdktxLogout.Name = "HdktxLogout";
            HdktxLogout.Size = new Size(131, 40);
            HdktxLogout.TabIndex = 21;
            HdktxLogout.Text = "Thoát";
            HdktxLogout.UseVisualStyleBackColor = true;
            HdktxLogout.Click += button1_Click;
            // 
            // HdktxTaoHopDong
            // 
            HdktxTaoHopDong.Location = new Point(1024, 705);
            HdktxTaoHopDong.Name = "HdktxTaoHopDong";
            HdktxTaoHopDong.Size = new Size(193, 129);
            HdktxTaoHopDong.TabIndex = 22;
            HdktxTaoHopDong.Text = "Tạo hợp đồng";
            HdktxTaoHopDong.UseVisualStyleBackColor = true;
            HdktxTaoHopDong.Click += HdktxTaoHopDong_Click;
            // 
            // HopDongKTX
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 863);
            Controls.Add(HdktxTaoHopDong);
            Controls.Add(HdktxLogout);
            Controls.Add(HdktxBtnFemale);
            Controls.Add(HdktxBtnMale);
            Controls.Add(HdktxTimein);
            Controls.Add(HdktxTimeBorn);
            Controls.Add(HdktxTimeout);
            Controls.Add(HdtxTxbMSV);
            Controls.Add(HdktxAddress);
            Controls.Add(HdtxTxbCCCD);
            Controls.Add(HdtxTxbName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HopDongKTX";
            Text = "HopDongKTX";
            Load += HopDongKTX_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox HdtxTxbName;
        private TextBox HdtxTxbCCCD;
        private TextBox HdktxAddress;
        private TextBox HdtxTxbMSV;
        private ComboBox HdktxTimeout;
        private DateTimePicker HdktxTimeBorn;
        private DateTimePicker HdktxTimein;
        private RadioButton HdktxBtnMale;
        private RadioButton HdktxBtnFemale;
        private Button HdktxLogout;
        private Button HdktxTaoHopDong;
    }
}