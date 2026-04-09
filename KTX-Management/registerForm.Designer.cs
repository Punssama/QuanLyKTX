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
            RecheckPassWordTb = new TextBox();
            RegisterAccountNameLb = new Label();
            panel1 = new Panel();
            RegisterBtn = new Button();
            RegisterAccountNameTb = new TextBox();
            SchoolEmailTb = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
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
            RegisterLb.Size = new Size(422, 52);
            RegisterLb.TabIndex = 0;
            RegisterLb.Text = "ĐĂNG KÝ Ở KÝ TÚC XÁ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.65306F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.34694F));
            tableLayoutPanel1.Controls.Add(ReCheckPassLb, 0, 3);
            tableLayoutPanel1.Controls.Add(SchoolMailLb, 0, 4);
            tableLayoutPanel1.Controls.Add(RecheckPassWordTb, 1, 3);
            tableLayoutPanel1.Controls.Add(RegisterAccountNameLb, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 5);
            tableLayoutPanel1.Controls.Add(RegisterAccountNameTb, 1, 0);
            tableLayoutPanel1.Controls.Add(SchoolEmailTb, 1, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 125);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
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
            ReCheckPassLb.Location = new Point(161, 65);
            ReCheckPassLb.Name = "ReCheckPassLb";
            ReCheckPassLb.Size = new Size(137, 28);
            ReCheckPassLb.TabIndex = 2;
            ReCheckPassLb.Text = "Số điện thoại:";
            // 
            // SchoolMailLb
            // 
            SchoolMailLb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SchoolMailLb.AutoSize = true;
            SchoolMailLb.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold);
            SchoolMailLb.Location = new Point(230, 100);
            SchoolMailLb.Name = "SchoolMailLb";
            SchoolMailLb.Size = new Size(68, 28);
            SchoolMailLb.TabIndex = 3;
            SchoolMailLb.Text = "Email:";
            // 
            // RecheckPassWordTb
            // 
            RecheckPassWordTb.Font = new Font("Montserrat", 10.8F);
            RecheckPassWordTb.Location = new Point(304, 68);
            RecheckPassWordTb.Name = "RecheckPassWordTb";
            RecheckPassWordTb.Size = new Size(422, 29);
            RecheckPassWordTb.TabIndex = 7;
            // 
            // RegisterAccountNameLb
            // 
            RegisterAccountNameLb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RegisterAccountNameLb.AutoSize = true;
            RegisterAccountNameLb.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold);
            RegisterAccountNameLb.Location = new Point(163, 0);
            RegisterAccountNameLb.Name = "RegisterAccountNameLb";
            RegisterAccountNameLb.Size = new Size(135, 28);
            RegisterAccountNameLb.TabIndex = 0;
            RegisterAccountNameLb.Text = "Tên sinh viên:";
            // 
            // panel1
            // 
            panel1.Controls.Add(RegisterBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(304, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 236);
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
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // RegisterAccountNameTb
            // 
            RegisterAccountNameTb.Font = new Font("Montserrat", 10.8F);
            RegisterAccountNameTb.Location = new Point(304, 3);
            RegisterAccountNameTb.Name = "RegisterAccountNameTb";
            RegisterAccountNameTb.Size = new Size(422, 29);
            RegisterAccountNameTb.TabIndex = 5;
            RegisterAccountNameTb.TextChanged += RegisterAccountNameTb_TextChanged;
            // 
            // SchoolEmailTb
            // 
            SchoolEmailTb.Font = new Font("Montserrat", 10.8F);
            SchoolEmailTb.Location = new Point(304, 103);
            SchoolEmailTb.Name = "SchoolEmailTb";
            SchoolEmailTb.Size = new Size(422, 29);
            SchoolEmailTb.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 10.8F, FontStyle.Bold);
            label1.Location = new Point(168, 35);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Montserrat", 10.8F);
            textBox1.Location = new Point(304, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 29);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += RegisterAccountNameTb_TextChanged;
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
        private Label ReCheckPassLb;
        private Label SchoolMailLb;
        private TextBox RecheckPassWordTb;
        private TextBox SchoolEmailTb;
        private TextBox RegisterAccountNameTb;
        private Button RegisterBtn;
        private Label RegisterLb;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
    }
}