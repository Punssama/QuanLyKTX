namespace KTX_Management
{
    partial class quanlyphong
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cbf176a0193c9762ce2d;
            pictureBox1.Location = new Point(779, 139);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 264);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 2;
            label1.Text = "Tìm phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 42);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 4;
            label2.Text = "Thêm phòng";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(551, 42);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 6;
            label3.Text = "sửa phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(815, 42);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 7;
            label4.Text = "xóa phòng";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(114, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 33);
            comboBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(645, 38);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(386, 39);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(910, 39);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(817, 450);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 15;
            label5.Text = "Tổng phòng";
            // 
            // button4
            // 
            button4.AccessibleRole = AccessibleRole.None;
            button4.Location = new Point(934, 450);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 16;
            button4.UseVisualStyleBackColor = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "tình trạng";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "tầng mấy";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "loại phòng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "mã phòng";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(677, 75);
            dataGridView1.TabIndex = 14;
            // 
            // quanlyphong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 510);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "quanlyphong";
            Text = "quanlyphong";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private Button button4;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dataGridView1;
    }
}