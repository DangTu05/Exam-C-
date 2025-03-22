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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void a_Click(object sender, EventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            double A = (double)numericUpDownA.Value;
            double B = (double)numericUpDownB.Value;
            double C = (double)numericUpDownC.Value;
            PTBH p = new PTBH(A, B, C);
            string ketQua;
            double x1, x2;
            if (p.Giai(out x1, out x2, out ketQua))
            {
                value1.Text = x1.ToString();
                value2.Text = x2.ToString();
            }
            else
            {
                value1.Text = value2.Text = "";
            }
            Label lblKetQua = new Label
            {
                Text = ketQua,
                AutoSize = true,
                Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.Blue
            };
            KQ.Controls.Add(lblKetQua);
        }


    }
}
