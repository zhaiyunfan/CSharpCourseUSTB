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
    public partial class Homework4Form1 : Form
    {
        public Homework4Form1()
        {
            InitializeComponent();
        }

        private void FormHomework1Part1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = -1;
            pictureBox1.Visible = false;
            try
            {
                score = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                textBox2.Text = "输入格式错误";
                //throw;
            }

            if (score > 100)
            {
                textBox2.Text = "输入格式错误";
            }
            else if (score > 85)
            {
                //TODO: 添加显示图片功能
                textBox2.Text = "优";
                pictureBox1.Visible = true;

            }
            else if (score > 75)
            {
                textBox2.Text = "良";
            }
            else if (score > 60)
            {
                textBox2.Text = "合格";
            }
            else if (score >= 0)
            {
                textBox2.Text = "不合格";
            }
            else
            {
                textBox2.Text = "输入格式错误";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
