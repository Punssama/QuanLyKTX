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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(80, 306);
            button1.Name = "button1";
            button1.Size = new Size(187, 100);
            button1.TabIndex = 0;
            button1.Text = "Quản lý hợp đồng";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Font = new Font("Segoe UI", 13F);
            button2.Location = new Point(413, 169);
            button2.Name = "button2";
            button2.Size = new Size(182, 100);
            button2.TabIndex = 0;
            button2.Text = "Quản lý thu chi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(413, 306);
            button3.Name = "button3";
            button3.Size = new Size(182, 100);
            button3.TabIndex = 0;
            button3.Text = "Báo cáo thống kê";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(268, 52);
            label1.Name = "label1";
            label1.Size = new Size(136, 54);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13F);
            button4.Location = new Point(80, 169);
            button4.Name = "button4";
            button4.Size = new Size(187, 100);
            button4.TabIndex = 0;
            button4.Text = "Quản lý phòng";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 441);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button1);
            Name = "FormTrangChu";
            Text = "FormTrangChu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
    }
}