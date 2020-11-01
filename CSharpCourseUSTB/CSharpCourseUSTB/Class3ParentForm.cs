using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourseUSTB
{
    public partial class Class3ParentForm : Form
    {
        public Class3ParentForm()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm chd = new Class3ChildForm();
            chd.MdiParent = this;
            chd.Show();
        }
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.SaveFile(childForm.filePath);
        }
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "富文本文件(*.ustb)|*.ustb";//设置文件类型
            fileDialog.FileName = "富文本文件";//设置默认文件名
            fileDialog.DefaultExt = "ustb";//设置默认格式（可以不设）
            fileDialog.AddExtension = true;//设置自动在文件名中添加扩展名
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
                childForm.richTextBox1.SaveFile(fileDialog.FileName);
                childForm.filePath = fileDialog.FileName;
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "富文本文件(*.ustb)|*.ustb";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Class3ChildForm childForm = new Class3ChildForm();
                childForm.MdiParent = this;
                childForm.Show();
                childForm.richTextBox1.LoadFile(openFileDialog.FileName);
                childForm.filePath = openFileDialog.FileName;
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.Paste();
        }
        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.Cut();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
                childForm.richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
                childForm.richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void 春ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.BackColor = Color.FromArgb(255, 255, 0, 0);
        }

        private void 夏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.BackColor = Color.FromArgb(255, 0, 255, 0);
        }

        private void 秋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.BackColor = Color.FromArgb(255, 255, 255, 0);
        }

        private void 冬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class3ChildForm childForm = (Class3ChildForm)this.ActiveMdiChild;
            childForm.richTextBox1.BackColor = Color.FromArgb(255, 255, 255, 255);
        }
    }
}
