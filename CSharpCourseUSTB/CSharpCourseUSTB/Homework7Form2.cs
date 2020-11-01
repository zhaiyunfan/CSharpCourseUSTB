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
    public partial class Homework7Form2 : Form
    {
        public Homework7Form2()
        {
            InitializeComponent();
        }
        public Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bitmap = new Bitmap(dialog.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp";
            fileDialog.FileName = "out";
            fileDialog.DefaultExt = "jpg";
            fileDialog.AddExtension = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(fileDialog.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gray;
            for (int c = 0; c < bitmap.Width; c++)
            {
                for (int r = 0; r < bitmap.Height; r++)
                {
                    gray = (int)(bitmap.GetPixel(c, r).R * 0.3f +
                                          bitmap.GetPixel(c, r).G * 0.6f +
                                          bitmap.GetPixel(c, r).B * 0.1f);
                    bitmap.SetPixel(c, r, Color.FromArgb(gray, gray, gray));
                }
            }
            pictureBox1.Image = bitmap;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, bitNumber, distance = 1;
            Random rand = new Random();
            for (int r = 2; r < bitmap.Height - 2; r++)
            {
                for (int c = 2; c < bitmap.Width - 2; c++)
                {
                    bitNumber = rand.Next(1, 4);
                    switch (bitNumber)
                    {
                        case 1: x = c - distance; y = r; break;
                        case 2: x = c; y = r - distance; break;
                        case 3: x = c + distance; y = r; break;
                        case 4: x = c; y = r + distance; break;
                    }
                    bitmap.SetPixel(c, r, ((Bitmap)pictureBox1.Image).GetPixel(x, y));
                }
            }
            pictureBox1.Image = bitmap;

        }
    }
}
