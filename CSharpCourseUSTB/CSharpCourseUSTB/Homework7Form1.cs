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
    public partial class Homework7Form1 : Form
    {
        public Homework7Form1()
        {
            InitializeComponent();
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(this.BackColor);
            graphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            graphics.Clear(this.BackColor);
            graphics.DrawRectangle(pen, 50, 50, 400, 300);
            pen.Dispose();
            graphics.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Red);
            graphics.Clear(this.BackColor);
            graphics.DrawEllipse(pen, 50, 50, 300, 300);
            pen.Dispose();
            graphics.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(this.BackColor);
            graphics.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(this.BackColor);
            Pen pen = new Pen(Color.Green, 2);
            int maxY = this.Height;
            int maxX = this.Width;

            double f = 2.0 * Math.PI / 200.0;
            int lmin = 0;
            int rmax = 200;//把具体的宽度分成200等份
            int count = rmax - lmin;
            PointF[] mypoint = new PointF[count + 1];
            int x = 0;
            for (int i = lmin; i <= rmax; i++)
            {
                double temp = 0.5 * (maxY - maxY * Math.Sin(f * i));
                mypoint[x] = new PointF((float)i, (float)temp);
                x++;
            }
            graphics.DrawCurve(pen, mypoint);
            pen.Dispose();
            graphics.Dispose();
        }

    }

}
