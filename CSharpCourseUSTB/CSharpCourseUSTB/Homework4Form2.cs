using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourseUSTB
{
    public partial class Homework4Form2 : Form
    {
        public Homework4Form2()
        {
            InitializeComponent();
        }
        char op;
        int firstNum;
        int secondNum;
        double result = 0.0;

        private void button13_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                firstNum = Convert.ToInt32(textBox1.Text);
                op = Convert.ToChar(((Button)sender).Text);
                textBox1.Text = "";
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstNum = 0;
            secondNum = 0;
            op = ' ';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                secondNum = Convert.ToInt32(textBox1.Text);
                switch (op)
                {
                    case '+':
                        result = firstNum + secondNum;
                        break;
                    case '-':
                        result = firstNum - secondNum;
                        break;
                    case '*':
                        result = firstNum * secondNum;
                        break;
                    case '/':
                        {
                            if (secondNum.Equals(0))
                            {
                                textBox1.Text = "0不能为除数";
                                return;
                            }
                            result = Convert.ToDouble(firstNum) / Convert.ToDouble(secondNum);
                            break;
                        }
                }
                textBox1.Text = Convert.ToString(result);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button thisButtom = (Button)sender;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = thisButtom.Text;
            }
            else
            {
                textBox1.Text += thisButtom.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                firstNum = Convert.ToInt32(textBox1.Text);
                op = Convert.ToChar(((Button)sender).Text);
                textBox1.Text = "";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                firstNum = Convert.ToInt32(textBox1.Text);
                op = Convert.ToChar(((Button)sender).Text);
                textBox1.Text = "";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {
                firstNum = Convert.ToInt32(textBox1.Text);
                op = Convert.ToChar(((Button)sender).Text);
                textBox1.Text = "";
            }
        }
    }
}
