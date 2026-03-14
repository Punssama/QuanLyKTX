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
            TenDangNhapLb = new Label();
            MatKhauLb = new Label();
            IDTb = new TextBox();
            TenDangNhapTb = new TextBox();
            ThemTaiKhoanBtn = new Button();
            IDLb = new Label();
            MatKhauTb = new TextBox();
            SuspendLayout();
            // 
            // TenDangNhapLb
            // 
            TenDangNhapLb.AutoSize = true;
            TenDangNhapLb.Font = new Font("Segoe UI", 16.2F);
            TenDangNhapLb.Location = new Point(171, 151);
            TenDangNhapLb.Name = "TenDangNhapLb";
            TenDangNhapLb.Size = new Size(206, 38);
            TenDangNhapLb.TabIndex = 0;
            TenDangNhapLb.Text = "Tên đăng nhập:";
            // 
            // MatKhauLb
            // 
            MatKhauLb.AutoSize = true;
            MatKhauLb.Font = new Font("Segoe UI", 16.2F);
            MatKhauLb.Location = new Point(208, 202);
            MatKhauLb.Name = "MatKhauLb";
            MatKhauLb.Size = new Size(139, 38);
            MatKhauLb.TabIndex = 1;
            MatKhauLb.Text = "Mật khẩu:";
            // 
            // IDTb
            // 
            IDTb.Font = new Font("Segoe UI", 16.2F);
            IDTb.Location = new Point(383, 87);
            IDTb.Name = "IDTb";
            IDTb.Size = new Size(197, 43);
            IDTb.TabIndex = 2;
            IDTb.TextChanged += validate;
            // 
            // TenDangNhapTb
            // 
            TenDangNhapTb.Font = new Font("Segoe UI", 16.2F);
            TenDangNhapTb.Location = new Point(383, 148);
            TenDangNhapTb.Name = "TenDangNhapTb";
            TenDangNhapTb.Size = new Size(197, 43);
            TenDangNhapTb.TabIndex = 3;
            // 
            // ThemTaiKhoanBtn
            // 
            ThemTaiKhoanBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThemTaiKhoanBtn.Location = new Point(415, 263);
            ThemTaiKhoanBtn.Name = "ThemTaiKhoanBtn";
            ThemTaiKhoanBtn.Size = new Size(110, 39);
            ThemTaiKhoanBtn.TabIndex = 4;
            ThemTaiKhoanBtn.Text = "Thêm";
            ThemTaiKhoanBtn.UseVisualStyleBackColor = true;
            ThemTaiKhoanBtn.Click += ThemTaiKhoanBtn_Click;
            // 
            // IDLb
            // 
            IDLb.AutoSize = true;
            IDLb.Font = new Font("Segoe UI", 16.2F);
            IDLb.Location = new Point(254, 90);
            IDLb.Name = "IDLb";
            IDLb.Size = new Size(50, 38);
            IDLb.TabIndex = 5;
            IDLb.Text = "ID:";
            // 
            // MatKhauTb
            // 
            MatKhauTb.Font = new Font("Segoe UI", 16.2F);
            MatKhauTb.Location = new Point(383, 199);
            MatKhauTb.Name = "MatKhauTb";
            MatKhauTb.Size = new Size(197, 43);
            MatKhauTb.TabIndex = 6;
            // 
            // ThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MatKhauTb);
            Controls.Add(IDLb);
            Controls.Add(ThemTaiKhoanBtn);
            Controls.Add(TenDangNhapTb);
            Controls.Add(IDTb);
            Controls.Add(MatKhauLb);
            Controls.Add(TenDangNhapLb);
            Name = "ThemTaiKhoan";
            Text = "ThemTaiKhoan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TenDangNhapLb;
        private Label MatKhauLb;
        private TextBox IDTb;
        private TextBox TenDangNhapTb;
        private Button ThemTaiKhoanBtn;
        private Label IDLb;
        private TextBox MatKhauTb;
    }
}