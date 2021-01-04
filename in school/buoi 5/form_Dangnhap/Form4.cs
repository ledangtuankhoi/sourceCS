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
    public partial class frmBaiTap3 : Form
    {
        public frmBaiTap3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToInt32(this.txt_a.Text);
            b = Convert.ToInt32(this.txt_b.Text);
            this.txtC.Text = Convert.ToDecimal((-b) / a).ToString("#,##0.000");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
