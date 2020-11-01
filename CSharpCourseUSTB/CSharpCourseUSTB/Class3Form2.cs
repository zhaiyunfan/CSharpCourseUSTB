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
    
    public partial class Class3Form2 : Form
    {
        public Class3Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class3Form1.time_boundary = Convert.ToInt32(textBox1.Text);
            Class3Form1.time_remind = textBox2.Text;
            this.Close();
        }
        [STAThread]
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "图片文件(*.jpg,*.bmp)|*.jpg;*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Class3Form1.picPath = dialog.FileName;
            }
        }
    }
}
