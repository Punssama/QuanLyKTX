namespace KTX_Management
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginTopPanel = new Panel();
            LoginTitleLabel = new Label();
            LoginMidPanel = new Panel();
            ForgetPassWordLb = new LinkLabel();
            LoginBtn = new Button();
            signUpLinkLb = new LinkLabel();
            MatKhauTb = new TextBox();
            TenDangNhaptb = new TextBox();
            LoginPasswordLabel = new Label();
            LoginAccountNameLabel = new Label();
            LoginBotPanel = new Panel();
            sloganLb = new Label();
            LoginTopPanel.SuspendLayout();
            LoginMidPanel.SuspendLayout();
            LoginBotPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTopPanel
            // 
            LoginTopPanel.Controls.Add(LoginTitleLabel);
            LoginTopPanel.Dock = DockStyle.Top;
            LoginTopPanel.Location = new Point(0, 0);
            LoginTopPanel.Name = "LoginTopPanel";
            LoginTopPanel.Size = new Size(882, 116);
            LoginTopPanel.TabIndex = 0;
            // 
            // LoginTitleLabel
            // 
            LoginTitleLabel.Anchor = AnchorStyles.None;
            LoginTitleLabel.AutoSize = true;
            LoginTitleLabel.Font = new Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginTitleLabel.ForeColor = SystemColors.Highlight;
            LoginTitleLabel.Location = new Point(154, 33);
            LoginTitleLabel.Name = "LoginTitleLabel";
            LoginTitleLabel.Size = new Size(625, 58);
            LoginTitleLabel.TabIndex = 0;
            LoginTitleLabel.Text = "HỆ THỐNG QUẢN LÝ KÝ TÚC XÁ";
            // 
            // LoginMidPanel
            // 
            LoginMidPanel.Controls.Add(ForgetPassWordLb);
            LoginMidPanel.Controls.Add(LoginBtn);
            LoginMidPanel.Controls.Add(signUpLinkLb);
            LoginMidPanel.Controls.Add(MatKhauTb);
            LoginMidPanel.Controls.Add(TenDangNhaptb);
            LoginMidPanel.Controls.Add(LoginPasswordLabel);
            LoginMidPanel.Controls.Add(LoginAccountNameLabel);
            LoginMidPanel.Dock = DockStyle.Fill;
            LoginMidPanel.Location = new Point(0, 116);
            LoginMidPanel.Name = "LoginMidPanel";
            LoginMidPanel.Size = new Size(882, 337);
            LoginMidPanel.TabIndex = 1;
            // 
            // ForgetPassWordLb
            // 
            ForgetPassWordLb.AutoSize = true;
            ForgetPassWordLb.Location = new Point(629, 121);
            ForgetPassWordLb.Name = "ForgetPassWordLb";
            ForgetPassWordLb.Size = new Size(109, 20);
            ForgetPassWordLb.TabIndex = 6;
            ForgetPassWordLb.TabStop = true;
            ForgetPassWordLb.Text = "Quên mật khẩu";
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.None;
            LoginBtn.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(399, 147);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(159, 38);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Đăng nhập";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // signUpLinkLb
            // 
            signUpLinkLb.Anchor = AnchorStyles.None;
            signUpLinkLb.AutoSize = true;
            signUpLinkLb.Font = new Font("Montserrat", 10.2F);
            signUpLinkLb.Location = new Point(442, 188);
            signUpLinkLb.Name = "signUpLinkLb";
            signUpLinkLb.Size = new Size(82, 27);
            signUpLinkLb.TabIndex = 4;
            signUpLinkLb.TabStop = true;
            signUpLinkLb.Text = "Đăng ký";
            signUpLinkLb.LinkClicked += signUpLinkLb_LinkClicked;
            // 
            // MatKhauTb
            // 
            MatKhauTb.Anchor = AnchorStyles.None;
            MatKhauTb.Font = new Font("Montserrat", 13.1999989F);
            MatKhauTb.Location = new Point(351, 107);
            MatKhauTb.Name = "MatKhauTb";
            MatKhauTb.Size = new Size(272, 34);
            MatKhauTb.TabIndex = 3;
            MatKhauTb.UseSystemPasswordChar = true;
            // 
            // TenDangNhaptb
            // 
            TenDangNhaptb.Anchor = AnchorStyles.None;
            TenDangNhaptb.Font = new Font("Montserrat", 13.1999989F);
            TenDangNhaptb.Location = new Point(351, 52);
            TenDangNhaptb.Name = "TenDangNhaptb";
            TenDangNhaptb.Size = new Size(272, 34);
            TenDangNhaptb.TabIndex = 2;
            // 
            // LoginPasswordLabel
            // 
            LoginPasswordLabel.Anchor = AnchorStyles.None;
            LoginPasswordLabel.AutoSize = true;
            LoginPasswordLabel.Font = new Font("Montserrat", 13.7999992F);
            LoginPasswordLabel.Location = new Point(215, 105);
            LoginPasswordLabel.Name = "LoginPasswordLabel";
            LoginPasswordLabel.Size = new Size(130, 36);
            LoginPasswordLabel.TabIndex = 1;
            LoginPasswordLabel.Text = "Mật khẩu:";
            // 
            // LoginAccountNameLabel
            // 
            LoginAccountNameLabel.Anchor = AnchorStyles.None;
            LoginAccountNameLabel.AutoSize = true;
            LoginAccountNameLabel.Font = new Font("Montserrat", 13.7999992F);
            LoginAccountNameLabel.Location = new Point(147, 50);
            LoginAccountNameLabel.Name = "LoginAccountNameLabel";
            LoginAccountNameLabel.Size = new Size(198, 36);
            LoginAccountNameLabel.TabIndex = 0;
            LoginAccountNameLabel.Text = "Tên đăng nhập:";
            // 
            // LoginBotPanel
            // 
            LoginBotPanel.Controls.Add(sloganLb);
            LoginBotPanel.Dock = DockStyle.Bottom;
            LoginBotPanel.Location = new Point(0, 402);
            LoginBotPanel.Name = "LoginBotPanel";
            LoginBotPanel.Size = new Size(882, 51);
            LoginBotPanel.TabIndex = 2;
            // 
            // sloganLb
            // 
            sloganLb.Anchor = AnchorStyles.None;
            sloganLb.AutoSize = true;
            sloganLb.Font = new Font("Montserrat Medium", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sloganLb.ForeColor = Color.Firebrick;
            sloganLb.Location = new Point(328, 0);
            sloganLb.Name = "sloganLb";
            sloganLb.Size = new Size(295, 28);
            sloganLb.TabIndex = 0;
            sloganLb.Text = "Manage everything at ease!";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(LoginBotPanel);
            Controls.Add(LoginMidPanel);
            Controls.Add(LoginTopPanel);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(679, 497);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login page";
            LoginTopPanel.ResumeLayout(false);
            LoginTopPanel.PerformLayout();
            LoginMidPanel.ResumeLayout(false);
            LoginMidPanel.PerformLayout();
            LoginBotPanel.ResumeLayout(false);
            LoginBotPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginTopPanel;
        private Label LoginTitleLabel;
        private Panel LoginMidPanel;
        private LinkLabel signUpLinkLb;
        private TextBox MatKhauTb;
        private TextBox TenDangNhaptb;
        private Label LoginPasswordLabel;
        private Label LoginAccountNameLabel;
        private Panel LoginBotPanel;
        private Button LoginBtn;
        private Label sloganLb;
        private LinkLabel ForgetPassWordLb;
    }
}
