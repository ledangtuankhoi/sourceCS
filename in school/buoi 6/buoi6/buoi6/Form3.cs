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
    public partial class frmBai1 : Form
    {
        Timer timer = new Timer();
        string s = "Chúc mừng năm mới happynewyare";
        int IndexS = -1;
      
        public frmBai1()
        {
            InitializeComponent();
            timer1.Interval = 100;
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.lblChucMung.Text = "";
            
            if (IndexS < s.Length - 1)
                lblChucMung.Text += s[++IndexS];
            else
            {
                timer.Stop();
            }
        }
        //string strin = "hello";
        //int i = 5;
       
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDongHo.Text = i.ToString();
            i--;
            if (i < 0)
                this.timer1.Enabled = false;
            char[] chararry = strin.ToCharArray();
            this.txtOUt.Text = chararry[i-1].ToString();
        }*/
        /*
        private string str1, str2 = "";
        private int i = 0;
        private void btnChay_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int n = lblChucMung.Text.Length;
            if (i < n)
            {
                str1 = lblChucMung.Text[i].ToString();
                str2 += str1;
                lblChucMung.Text = str2;
                i++;
            }
            else
            {
                i = 0;
                str1 = "";
            }
        }
        */

       
        private void lblDongHo_Click(object sender, EventArgs e)
        {

        }

        private void bttBatDau_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }

        private void bttDung_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //this.txtIn.Text = 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
