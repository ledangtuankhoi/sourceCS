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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = int.Parse(this.txtN.Text);
            int n = int.Parse(this.txtN.Text);
            string temp = " " ;
            for (int i = 1; i < int.Parse(this.txtM.Text) ; i++)
            {
                if (n % i == 0 && m % i == 0 && rad1.Checked == true)
                {
                    temp += i.ToString();
                    temp += ", ";
                }
                if (n % i == 0 && m % i == 0 && rad2.Checked == true)
                {
                    temp = i.ToString();
                    //temp += ", ";
                }
            }
            txtOut.Text = temp;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void bbtXoa_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            txtM.Clear();
            txtN.Clear();
            txtN.Focus();
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
