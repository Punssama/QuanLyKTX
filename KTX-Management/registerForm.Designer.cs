namespace KTX_Management
{
    partial class registerForm
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
            RegisterTitlePn = new Panel();
            RegisterLb = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ReCheckPassLb = new Label();
            SchoolMailLb = new Label();
            RegisterPassWordTb = new TextBox();
            RecheckPassWordTb = new TextBox();
            SchoolEmailTb = new TextBox();
            RegisterAccountNameLb = new Label();
            RegisterPassWordLb = new Label();
            RegisterAccountNameTb = new TextBox();
            panel1 = new Panel();
            RegisterBtn = new Button();
            RegisterTitlePn.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterTitlePn
            // 
            RegisterTitlePn.Controls.Add(RegisterLb);
            RegisterTitlePn.Dock = DockStyle.Top;
            RegisterTitlePn.Location = new Point(0, 0);
            RegisterTitlePn.Name = "RegisterTitlePn";
            RegisterTitlePn.Size = new Size(922, 125);
            RegisterTitlePn.TabIndex = 0;
            // 
            // RegisterLb
            // 
            RegisterLb.Anchor = AnchorStyles.None;
            RegisterLb.AutoSize = true;
            RegisterLb.Font = new Font("Montserrat Black", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterLb.ForeColor = SystemColors.Highlight;
            RegisterLb.Location = new Point(304, 41);
            RegisterLb.Name = "RegisterLb";
            RegisterLb.Size = new Size(399, 52);
            RegisterLb.TabIndex = 0;
            RegisterLb.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.65306F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.34694F));
            tableLayoutPanel1.Controls.Add(ReCheckPassLb, 0, 2);
            tableLayoutPanel1.Controls.Add(SchoolMailLb, 0, 3);
            tableLayoutPanel1.Controls.Add(RegisterPassWordTb, 1, 1);
            tableLayoutPanel1.Controls.Add(RecheckPassWordTb, 1, 2);
            tableLayoutPanel1.Controls.Add(SchoolEmailTb, 1, 3);
            tableLayoutPanel1.Controls.Add(RegisterAccountNameLb, 0, 0);
            tableLayoutPanel1.Controls.Add(RegisterPassWordLb, 0, 1);
            tableLayoutPanel1.Controls.Add(RegisterAccountNameTb, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(922, 347);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ReCheckPassLb
            // 
            ReCheckPassLb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ReCheckPassLb.AutoSize = true;
            ReCheckPassLb.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold);
            ReCheckPassLb.Location = new Point(112, 70);
            ReCheckPassLb.Name = "ReCheckPassLb";
            ReCheckPassLb.Size = new Size(186, 28);
            ReCheckPassLb.TabIndex = 2;
            ReCheckPassLb.Text = "Nhập lại mật khẩu:";
            // 
            // SchoolMailLb
            // 
            SchoolMailLb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SchoolMailLb.AutoSize = true;
            SchoolMailLb.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold);
            SchoolMailLb.Location = new Point(121, 105);
            SchoolMailLb.Name = "SchoolMailLb";
            SchoolMailLb.Size = new Size(177, 28);
            SchoolMailLb.TabIndex = 3;
            SchoolMailLb.Text = "Email nhà trường:";
            // 
            // RegisterPassWordTb
            // 
            RegisterPassWordTb.Font = new Font("Montserrat", 10.8F);
            RegisterPassWordTb.Location = new Point(304, 38);
            RegisterPassWordTb.Name = "RegisterPassWordTb";
            RegisterPassWordTb.Size = new Size(422, 29);
            RegisterPassWordTb.TabIndex = 6;
            // 
            // RecheckPassWordTb
            // 
            RecheckPassWordTb.Font = new Font("Montserrat", 10.8F);
            RecheckPassWordTb.Location = new Point(304, 73);
            RecheckPassWordTb.Name = "RecheckPassWordTb";
            RecheckPassWordTb.Size = new Size(422, 29);
            RecheckPassWordTb.TabIndex = 7;
            // 
            // SchoolEmailTb
            // 
            SchoolEmailTb.Font = new Font("Montserrat", 10.8F);
            SchoolEmailTb.Location = new Point(304, 108);
            SchoolEmailTb.Name = "SchoolEmailTb";
            SchoolEmailTb.Size = new Size(422, 29);
            SchoolEmailTb.TabIndex = 8;
            // 
            // RegisterAccountNameLb
            // 
            RegisterAccountNameLb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RegisterAccountNameLb.AutoSize = true;
            RegisterAccountNameLb.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold);
            RegisterAccountNameLb.Location = new Point(145, 0);
            RegisterAccountNameLb.Name = "RegisterAccountNameLb";
            RegisterAccountNameLb.Size = new Size(153, 28);
            RegisterAccountNameLb.TabIndex = 0;
            RegisterAccountNameLb.Text = "Tên đăng nhập:";
            // 
            // RegisterPassWordLb
            // 
            RegisterPassWordLb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RegisterPassWordLb.AutoSize = true;
            RegisterPassWordLb.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold);
            RegisterPassWordLb.Location = new Point(195, 35);
            RegisterPassWordLb.Name = "RegisterPassWordLb";
            RegisterPassWordLb.Size = new Size(103, 28);
            RegisterPassWordLb.TabIndex = 1;
            RegisterPassWordLb.Text = "Mật khẩu:";
            // 
            // RegisterAccountNameTb
            // 
            RegisterAccountNameTb.Font = new Font("Montserrat", 10.8F);
            RegisterAccountNameTb.Location = new Point(304, 3);
            RegisterAccountNameTb.Name = "RegisterAccountNameTb";
            RegisterAccountNameTb.Size = new Size(422, 29);
            RegisterAccountNameTb.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(RegisterBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(304, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 201);
            panel1.TabIndex = 9;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterBtn.Location = new Point(139, 3);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(123, 40);
            RegisterBtn.TabIndex = 4;
            RegisterBtn.Text = "Đăng ký";
            RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 472);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(RegisterTitlePn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "registerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Page";
            RegisterTitlePn.ResumeLayout(false);
            RegisterTitlePn.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel RegisterTitlePn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label RegisterAccountNameLb;
        private Label RegisterPassWordLb;
        private Label ReCheckPassLb;
        private Label SchoolMailLb;
        private TextBox RegisterPassWordTb;
        private TextBox RecheckPassWordTb;
        private TextBox SchoolEmailTb;
        private TextBox RegisterAccountNameTb;
        private Button RegisterBtn;
        private Label RegisterLb;
        private Panel panel1;
    }
}