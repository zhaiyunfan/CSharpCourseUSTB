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
    public partial class Class4Form1 : Form
    {
        private Postgraduate postgraduate;
        public Class4Form1()
        {
            InitializeComponent();
        }

        private void ShowText()
        {
            textBox5.Text = "该学生学号为：" + postgraduate.StudentId + "," + "该学生姓名为：" + postgraduate.StudentName + "," + "该学生学校名为：" + Postgraduate.SchoolName + "," + "该学生自述为：" + postgraduate.Introduction + "," + "该学生领域为：" + postgraduate.Field + "," + "该学生生日为：" + postgraduate.StudentBirthday + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Postgraduate.SchoolName = textBox3.Text;

            int stu_id = Convert.ToInt32(textBox2.Text);
            string stu_name = textBox1.Text;
            DateTime birthday = dateTimePicker1.Value;
            string introduction = textBox4.Text;
            string field = textBox6.Text;

            postgraduate = new Postgraduate(stu_id, stu_name, birthday, introduction, field);
            ShowText();
        }

    }
}
