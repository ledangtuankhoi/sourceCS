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
    public partial class frmBaiTap1 : Form
    {
        public frmBaiTap1()
        {
            InitializeComponent();
        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            this.txtSo1.Clear();
            this.txtSo2.Clear();
            this.txtKetQua.Clear();
            this.txtSo1.Focus();
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void bttChia_Click(object sender, EventArgs e)
        {

            if (this.txtSo1.Text == "0")
            {
                MessageBox.Show("So Bi Chia không thể bằng không(0)");
            }
            /*
            do
            {
                MessageBox.Show("nhap chua dung");
                this.Close();
            } while (IsNumber(this.txtSo1.Text) == false);
             * */
            /*
            while (IsNumber(this.txtSo1.Text) == false)
            {
                MessageBox.Show("nhap chua dung");
            }
             * */
            int so1 = int.Parse( this.txtSo1.Text);
            int so2 = int.Parse( this.txtSo2.Text) ;
            //float ketqua = (float)so1 / so2;
            //MessageBox.Show(Convert.ToDecimal((float)so1 / so2).ToString("#,##0.00000"));
             this.txtKetQua.Text = Convert.ToDecimal(so1 / so2).ToString("#,##0.000") ;
        }

        private void bttNhan_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(this.txtSo1.Text);
            int so2 = int.Parse(this.txtSo2.Text);
            float ketqua = (float)so1 / so2;
            //MessageBox.Show(Convert.ToDecimal((float)so1 / so2).ToString("#,##0.00000"));
            this.txtKetQua.Text = Convert.ToDecimal((float)so1 * so2).ToString("#,##0.000");
        }

        private void bttCong_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(this.txtSo1.Text);
            int so2 = int.Parse(this.txtSo2.Text);
            float ketqua = (float)so1 / so2;
            //MessageBox.Show(Convert.ToDecimal((float)so1 / so2).ToString("#,##0.000"));
            this.txtKetQua.Text = Convert.ToDecimal((float)so1 + so2).ToString("#,##0.000");
        }

        private void bttTru_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(this.txtSo1.Text);
            int so2 = int.Parse(this.txtSo2.Text);
            float ketqua = (float)so1 / so2;
            //MessageBox.Show(Convert.ToDecimal((float)so1 / so2).ToString("#,##0.00000"));
            this.txtKetQua.Text = Convert.ToDecimal((float)so1 - so2).ToString("#,##0.000");
        }
    }
}
