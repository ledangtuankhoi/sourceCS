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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void bttLIstbox_Click(object sender, EventArgs e)
        {
            Form frmlistBox= new frmListBox();
            frmlistBox.ShowDialog();
        }

        private void bbtBai1_Click(object sender, EventArgs e)
        {
            Form frmbai1 = new frmBai1();
            frmbai1.ShowDialog();
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttBai2_Click(object sender, EventArgs e)
        {
            //Form frmBuom = new Form5();

        }

        private void bttBai3_Click(object sender, EventArgs e)
        {
            Form frmBai3 = new frmBai3();
            frmBai3.ShowDialog();
        }

        private void bttBai6_Click(object sender, EventArgs e)
        {
            Form frmBai6 = new frmBai6();
            frmBai6.ShowDialog();
        }
    }
}
