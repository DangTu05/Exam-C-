using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ketqua.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ketqua.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ketqua.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ketqua.Text += "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ketqua.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ketqua.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ketqua.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ketqua.Text += "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ketqua.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ketqua.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ketqua.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ketqua.Text += "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ketqua.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ketqua.Text += "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ketqua.Text += "/";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MatchCollection matches = Regex.Matches(ketqua.Text, @"\d+|[+\-*/]");
            int kq = int.Parse(matches[0].Value); // Lấy số đầu tiên làm kq
            char currentOperation = '+';

            foreach (Match match in matches)
            {
                if (int.TryParse(match.Value, out int number))
                {
                    switch (currentOperation)
                    {
                        case '+':
                            kq += number;
                            break;
                        case '-':
                            kq -= number;
                            break;
                        case '*':
                            kq *= number;
                            break;
                        case '/':
                            kq /= number;
                            break;
                    }
                }
                else
                {
                    currentOperation = match.Value[0];
                }
            }

            ketqua.Text = kq.ToString();
        }
    }
}
