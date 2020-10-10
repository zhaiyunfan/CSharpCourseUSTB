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
    public partial class Homework5Form1 : Form
    {
        //private Form form2;
        public Homework5Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Homework5Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}
