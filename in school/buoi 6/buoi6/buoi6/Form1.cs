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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("dân trí");
            this.lstWeb.Items.Add("tuổi trẻ");
            this.lstWeb.Items.Add("VNepsss");
            this.lstWeb.Items.Add("công an");
            this.lstWeb.Items.Add("tuổi trẻ");
            this.lstWeb.Items.Add("tuổi trẻ");
        }

        private void bttOK_Click(object sender, EventArgs e)
        {

            this.txtKQ.Text = "ban đã chọn website ";
   
            if (this.lstWeb.SelectedIndex == -1)
            {

                MessageBox.Show("error");
            }
            else
            {

                this.txtKQ.Text += this.lstWeb.SelectedItem.ToString().ToUpper();
            }
        }

        private void bttReset_Click(object sender, EventArgs e)
        {
            this.txtKQ.ResetText();
        }
    }
}
