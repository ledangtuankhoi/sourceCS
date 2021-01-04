using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_Dangnhap
{
    public partial class frmChaoMung : Form
    {
        public frmChaoMung()
        {
            InitializeComponent();
        }

        private void frmChaoMung_Load(object sender, EventArgs e)
        {
            Form frm = new fDangNhap();
            frm.ShowDialog();

        }

        private void bttBaiiTap1_Click(object sender, EventArgs e)
        {
           
            Form frm = new frmBaiTap1();
            frm.ShowDialog();

            //this.Visible = false;
        }

        private void bttBaiTap2_Click(object sender, EventArgs e)
        {
            Form frm = new frmBaiTap3();
            frm.ShowDialog();
        }

        private void bttBaiTap3_Click(object sender, EventArgs e)
        {
            Form frm = new frmBaiTap3();
            frm.ShowDialog();
        }
    }
}
