namespace TAHUUCONG_BUOI4
{
    partial class Form1
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
            label1 = new Label();
            txt_mssv = new TextBox();
            button1 = new Button();
            label2 = new Label();
            txt_hoten = new TextBox();
            label3 = new Label();
            txt_gioitinh = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            txt_diachi = new TextBox();
            dt_ngaySinh = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 76);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            // 
            // txt_mssv
            // 
            txt_mssv.Location = new Point(160, 68);
            txt_mssv.Name = "txt_mssv";
            txt_mssv.Size = new Size(201, 23);
            txt_mssv.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(529, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 123);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ Và Tên";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(160, 115);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(201, 23);
            txt_hoten.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 174);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Giới Tính";
            // 
            // txt_gioitinh
            // 
            txt_gioitinh.Location = new Point(160, 166);
            txt_gioitinh.Name = "txt_gioitinh";
            txt_gioitinh.Size = new Size(201, 23);
            txt_gioitinh.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 76);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 0;
            label4.Text = "Ngày Sinh";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(465, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 23);
            textBox4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 123);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 0;
            label5.Text = "Địa Chỉ";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(465, 115);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(201, 23);
            txt_diachi.TabIndex = 1;
            // 
            // dt_ngaySinh
            // 
            dt_ngaySinh.Location = new Point(465, 70);
            dt_ngaySinh.Name = "dt_ngaySinh";
            dt_ngaySinh.Size = new Size(200, 23);
            dt_ngaySinh.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dt_ngaySinh);
            Controls.Add(button1);
            Controls.Add(txt_gioitinh);
            Controls.Add(label3);
            Controls.Add(txt_hoten);
            Controls.Add(label2);
            Controls.Add(txt_diachi);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(txt_mssv);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_mssv;
        private Button button1;
        private Label label2;
        private TextBox txt_hoten;
        private Label label3;
        private TextBox txt_gioitinh;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox txt_diachi;
        private DateTimePicker dt_ngaySinh;
    }
}
