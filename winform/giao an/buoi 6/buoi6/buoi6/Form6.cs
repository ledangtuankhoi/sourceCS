using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buoi6
{
    public partial class frmBai6 : Form
    {
        public frmBai6()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                this.richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
//            MessageBox.Show("asdas");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bbtclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttreset_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmlistBox = new frmBai6();
            frmlistBox.ShowDialog();
        }
    }
}
