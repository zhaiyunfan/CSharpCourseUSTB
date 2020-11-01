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
    public partial class Class3Form1 : Form
    {
        public static int time_boundary = 5;
        public static string time_remind = "您该休息了";
        public static string picPath;
        public Class3Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Interval = time_boundary * 1000;
            timer2.Start();          
        }

        public void timer1_fresh()
        {
            timer2.Interval = time_boundary * 1000;
            label2.Text = time_remind;
            if (picPath!=null)
            {
                this.BackgroundImage = Image.FromFile(@picPath);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "现在是" + DateTime.Now.ToString();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            label2.Visible = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Visible = true;
            label2.Visible = true;
            timer1_fresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class3Form2 form2 = new Class3Form2();
            form2.Show();
            this.Visible = false;
        }
    }
}
