using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nhap_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = DateTime.Parse(NgaySinh.Text); // Chuyển đổi sang DateTime
            double diemTrungBinh = double.Parse(DiemTrungBinh.Text); // Chuyển đổi sang double
            SinhVienChuyenNganh sv = new SinhVienChuyenNganh(MaSv.Text, HoTen.Text, ngaySinh, diemTrungBinh, ChuyenNganh.Text);
            KetQua.Text = sv.XepLoai().ToString();
        }

    }
}
