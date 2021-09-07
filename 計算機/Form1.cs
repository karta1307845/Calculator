using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算機
{
    public partial class Form1 : Form
    {
        double[] temp = new double[10];
        int x=0,y=1,z=1,i,j;
        double number,answer = 0;
        string[] op = new string[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (z != 1)
            {
                if (y == 0)
                {
                    textBox1.Text = "+";
                    y += 1;
                }
                else
                {
                    textBox1.Text += "+";
                }
                op[x] = "+";
                temp[x] = number;
                number = 0;
                x++;
                z = 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "1";
                number = 10 * number + 1;
                y += 1;
            }
            else
            {
                textBox1.Text += "1";
                number = 10 * number + 1;
            }
            z = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "2";
                number = 10 * number + 2;
                y += 1;
            }
            else
            {
                textBox1.Text += "2";
                number = 10 * number + 2;
            }
            z = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (y == 0||textBox1.Text=="0")
            {
                number = 0;
                textBox1.Text = "3";
                number = 10 * number + 3;
                y += 1;
            }
            else
            {
                textBox1.Text += "3";
                number = 10 * number + 3;
            }
            z = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "4";
                number = 10 * number + 4;
                y += 1;
            }
            else
            {
                textBox1.Text += "4";
                number = 10 * number + 4;
            }
            z = 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "5";
                number = 10 * number + 5;
                y += 1;
            }
            else
            {
                textBox1.Text += "5";
                number = 10 * number + 5;
            }
            z = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "6";
                number = 10 * number + 6;
                y += 1;
            }
            else
            {
                textBox1.Text += "6";
                number = 10 * number + 6;
            }
            z = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "7";
                number = 10 * number + 7;
                y += 1;
            }
            else
            {
                textBox1.Text += "7";
                number = 10 * number + 7;
            }
            z = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "8";
                number = 10 * number + 8;
                y += 1;
            }
            else
            {
                textBox1.Text += "8";
                number = 10 * number + 8;
            }
            z = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "9";
                number = 10 * number + 9;
                y += -1;
            }
            else
            {
                textBox1.Text += "9";
                number = 10 * number + 9;
            }
            z = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (y == 0 || textBox1.Text == "0")
            {
                number = 0;
                textBox1.Text = "0";
                number = 10 * number;
                y += 1;
            }
            else
            {
                textBox1.Text += "0";
                number = 10 * number;
            }
            z = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (z != 1)
            {
                if (x >= 10)
                {
                    textBox1.Text = "最多計算10個數";
                }
                else
                {
                    temp[x] = number;
                    answer = temp[0];
                    for (i = 0; i < 10; i++)
                    {
                        if (op[i] == "+")
                        {
                            answer += temp[i + 1];
                        }
                        else if (op[i] == "-")
                        {
                            answer -= temp[i + 1];
                        }
                        else if (op[i] == "*")
                        {
                            answer *= temp[i + 1];
                        }
                        else if (op[i] == "/")
                        {
                            if (temp[i + 1] == 0)
                            {
                                textBox1.Text = "Error";
                                break;
                            }
                            else
                            {
                                answer /= temp[i + 1];
                            }
                        }
                    }
                }
                for (j = 0; j < 10; j++)
                {
                    temp[j] = 1;
                    op[j] = "";
                }
                if (textBox1.Text != "Error" && textBox1.Text != "最多計算10個數")
                {
                    textBox1.Text = answer.ToString();
                }
                number = answer;
                x = 0;
                y = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (z != 1)
            {
                if (y == 0)
                {
                    textBox1.Text = "-";
                    y += 1;
                }
                else
                {
                    textBox1.Text += "-";
                }
                op[x] = "-";
                temp[x] = number;
                number = 0;
                x++;
                z = 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (z != 1)
            {
                if (y == 0)
                {
                    textBox1.Text = "*";
                    y += 1;
                }
                else
                {
                    textBox1.Text += "*";
                }
                op[x] = "*";
                temp[x] = number;
                number = 0;
                x++;
                z = 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (z != 1)
            {
                if (y == 0)
                {
                    textBox1.Text = "/";
                    y += 1;
                }
                else
                {
                    textBox1.Text += "/";
                }
                op[x] = "/";
                temp[x] = number;
                number = 0;
                x++;
                z = 1;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            answer = 0;
            number = 0;
            textBox1.Text = "";
            for (i = 0; i < 10; i++)
            {
                temp[i] = 1;
                op[i] = "";
            }
            x = 0;
        }
    }
}
