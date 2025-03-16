namespace Test
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.Label();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.MaSv = new System.Windows.Forms.TextBox();
            this.HoTen = new System.Windows.Forms.TextBox();
            this.ChuyenNganh = new System.Windows.Forms.ComboBox();
            this.DiemTrungBinh = new System.Windows.Forms.TextBox();
            this.Nhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyên ngành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm trung bình";
            // 
            // KetQua
            // 
            this.KetQua.AutoSize = true;
            this.KetQua.Location = new System.Drawing.Point(74, 302);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(52, 16);
            this.KetQua.TabIndex = 5;
            this.KetQua.Text = "Kết quả";
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(194, 130);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(200, 22);
            this.NgaySinh.TabIndex = 6;
            // 
            // MaSv
            // 
            this.MaSv.Location = new System.Drawing.Point(194, 51);
            this.MaSv.Name = "MaSv";
            this.MaSv.Size = new System.Drawing.Size(151, 22);
            this.MaSv.TabIndex = 7;
            this.MaSv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HoTen
            // 
            this.HoTen.Location = new System.Drawing.Point(194, 89);
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(151, 22);
            this.HoTen.TabIndex = 8;
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.FormattingEnabled = true;
            this.ChuyenNganh.Items.AddRange(new object[] {
            "CNTT",
            "HTTTQL",
            "Kế toán",
            "Ngân hàng"});
            this.ChuyenNganh.Location = new System.Drawing.Point(194, 184);
            this.ChuyenNganh.Name = "ChuyenNganh";
            this.ChuyenNganh.Size = new System.Drawing.Size(151, 24);
            this.ChuyenNganh.TabIndex = 10;
            // 
            // DiemTrungBinh
            // 
            this.DiemTrungBinh.Location = new System.Drawing.Point(194, 234);
            this.DiemTrungBinh.Name = "DiemTrungBinh";
            this.DiemTrungBinh.Size = new System.Drawing.Size(107, 22);
            this.DiemTrungBinh.TabIndex = 11;
            // 
            // Nhap
            // 
            this.Nhap.Location = new System.Drawing.Point(194, 277);
            this.Nhap.Name = "Nhap";
            this.Nhap.Size = new System.Drawing.Size(75, 28);
            this.Nhap.TabIndex = 12;
            this.Nhap.Text = "Nhập";
            this.Nhap.UseVisualStyleBackColor = true;
            this.Nhap.Click += new System.EventHandler(this.Nhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nhap);
            this.Controls.Add(this.DiemTrungBinh);
            this.Controls.Add(this.ChuyenNganh);
            this.Controls.Add(this.HoTen);
            this.Controls.Add(this.MaSv);
            this.Controls.Add(this.NgaySinh);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.TextBox MaSv;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.ComboBox ChuyenNganh;
        private System.Windows.Forms.TextBox DiemTrungBinh;
        private System.Windows.Forms.Button Nhap;
    }
}

