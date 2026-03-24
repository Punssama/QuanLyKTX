namespace KTX_Management
{
    partial class FormTrangChu
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
            panel1 = new Panel();
            lbTitle = new Label();
            panel2 = new Panel();
            btnLogOut = new Button();
            button1 = new Button();
            btnQuanLyTaiKhoan = new Button();
            btnGoQLPO = new Button();
            btnGoQLHD = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            tbState = new TextBox();
            tbNumOPeople = new TextBox();
            tbRoomName = new TextBox();
            lbState = new Label();
            lbNumOfPeople = new Label();
            lbRoomName = new Label();
            dgrvPhongO = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrvPhongO).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 83);
            panel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AccessibleDescription = "";
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Montserrat", 20F, FontStyle.Bold);
            lbTitle.Location = new Point(179, 8);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(381, 53);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "QUẢN LÝ KÝ TÚC XÁ";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnQuanLyTaiKhoan);
            panel2.Controls.Add(btnGoQLPO);
            panel2.Controls.Add(btnGoQLHD);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 505);
            panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.Anchor = AnchorStyles.Bottom;
            btnLogOut.Font = new Font("Montserrat", 8F);
            btnLogOut.Location = new Point(26, 396);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Montserrat", 9F);
            button1.Location = new Point(5, 117);
            button1.Name = "button1";
            button1.Size = new Size(153, 77);
            button1.TabIndex = 0;
            button1.Text = "Báo cáo thống kê";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnGoBCTK_Click;
            // 
            // btnQuanLyTaiKhoan
            // 
            btnQuanLyTaiKhoan.Font = new Font("Montserrat", 9F);
            btnQuanLyTaiKhoan.Location = new Point(5, 283);
            btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            btnQuanLyTaiKhoan.Size = new Size(153, 77);
            btnQuanLyTaiKhoan.TabIndex = 0;
            btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            btnQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            btnQuanLyTaiKhoan.Click += btnQuanLyTaiKhoan_Click;
            // 
            // btnGoQLPO
            // 
            btnGoQLPO.Font = new Font("Montserrat", 9F);
            btnGoQLPO.Location = new Point(5, 200);
            btnGoQLPO.Name = "btnGoQLPO";
            btnGoQLPO.Size = new Size(153, 77);
            btnGoQLPO.TabIndex = 0;
            btnGoQLPO.Text = "Quản lý phòng ở";
            btnGoQLPO.UseVisualStyleBackColor = true;
            btnGoQLPO.Click += btnGoQLPO_Click;
            // 
            // btnGoQLHD
            // 
            btnGoQLHD.Font = new Font("Montserrat", 9F);
            btnGoQLHD.Location = new Point(5, 37);
            btnGoQLHD.Name = "btnGoQLHD";
            btnGoQLHD.Size = new Size(153, 74);
            btnGoQLHD.TabIndex = 0;
            btnGoQLHD.Text = "Quản lý hợp đồng";
            btnGoQLHD.UseVisualStyleBackColor = true;
            btnGoQLHD.Click += btnGoQLHD_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(dgrvPhongO, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Montserrat", 7.79999971F);
            tableLayoutPanel1.Location = new Point(165, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.1031761F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.8968239F));
            tableLayoutPanel1.Size = new Size(594, 505);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbState);
            panel3.Controls.Add(tbNumOPeople);
            panel3.Controls.Add(tbRoomName);
            panel3.Controls.Add(lbState);
            panel3.Controls.Add(lbNumOfPeople);
            panel3.Controls.Add(lbRoomName);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(586, 180);
            panel3.TabIndex = 1;
            // 
            // tbState
            // 
            tbState.Font = new Font("Montserrat", 12F);
            tbState.Location = new Point(146, 120);
            tbState.Name = "tbState";
            tbState.Size = new Size(217, 32);
            tbState.TabIndex = 1;
            // 
            // tbNumOPeople
            // 
            tbNumOPeople.Font = new Font("Montserrat", 12F);
            tbNumOPeople.Location = new Point(146, 82);
            tbNumOPeople.Name = "tbNumOPeople";
            tbNumOPeople.Size = new Size(217, 32);
            tbNumOPeople.TabIndex = 1;
            // 
            // tbRoomName
            // 
            tbRoomName.Font = new Font("Montserrat", 12F);
            tbRoomName.Location = new Point(146, 39);
            tbRoomName.Name = "tbRoomName";
            tbRoomName.Size = new Size(217, 32);
            tbRoomName.TabIndex = 1;
            // 
            // lbState
            // 
            lbState.AutoSize = true;
            lbState.Font = new Font("Montserrat", 12F);
            lbState.Location = new Point(11, 120);
            lbState.Name = "lbState";
            lbState.Size = new Size(120, 31);
            lbState.TabIndex = 0;
            lbState.Text = "Trạng thái:";
            // 
            // lbNumOfPeople
            // 
            lbNumOfPeople.AutoSize = true;
            lbNumOfPeople.Font = new Font("Montserrat", 12F);
            lbNumOfPeople.Location = new Point(23, 77);
            lbNumOfPeople.Name = "lbNumOfPeople";
            lbNumOfPeople.Size = new Size(108, 31);
            lbNumOfPeople.TabIndex = 0;
            lbNumOfPeople.Text = "Số lượng:";
            // 
            // lbRoomName
            // 
            lbRoomName.AutoSize = true;
            lbRoomName.Font = new Font("Montserrat", 12F);
            lbRoomName.Location = new Point(3, 34);
            lbRoomName.Name = "lbRoomName";
            lbRoomName.Size = new Size(128, 31);
            lbRoomName.TabIndex = 0;
            lbRoomName.Text = "Tên phòng:";
            // 
            // dgrvPhongO
            // 
            dgrvPhongO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrvPhongO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrvPhongO.Dock = DockStyle.Fill;
            dgrvPhongO.Location = new Point(4, 191);
            dgrvPhongO.Name = "dgrvPhongO";
            dgrvPhongO.ReadOnly = true;
            dgrvPhongO.RowHeadersWidth = 51;
            dgrvPhongO.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgrvPhongO.Size = new Size(586, 310);
            dgrvPhongO.TabIndex = 0;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 588);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTrangChu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrvPhongO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbTitle;
        private Panel panel2;
        private Button btnLogOut;
        private Button btnGoQLPO;
        private Button btnGoQLHD;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgrvPhongO;
        private Panel panel3;
        private Label lbNumOfPeople;
        private Label lbRoomName;
        private Label lbState;
        private TextBox tbState;
        private TextBox tbNumOPeople;
        private TextBox tbRoomName;
        private Button button1;
        private Button btnQuanLyTaiKhoan;
    }
}