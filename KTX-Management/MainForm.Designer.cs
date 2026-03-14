namespace KTX_Management
{
    partial class MainForm
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
            ThemTaiKhoanBtn = new Button();
            SuspendLayout();
            // 
            // ThemTaiKhoanBtn
            // 
            ThemTaiKhoanBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThemTaiKhoanBtn.Location = new Point(325, 180);
            ThemTaiKhoanBtn.Name = "ThemTaiKhoanBtn";
            ThemTaiKhoanBtn.Size = new Size(201, 91);
            ThemTaiKhoanBtn.TabIndex = 0;
            ThemTaiKhoanBtn.Text = "thêm tài khoản";
            ThemTaiKhoanBtn.UseVisualStyleBackColor = true;
            ThemTaiKhoanBtn.Click += ThemTaiKhoanBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ThemTaiKhoanBtn);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ThemTaiKhoanBtn;
    }
}