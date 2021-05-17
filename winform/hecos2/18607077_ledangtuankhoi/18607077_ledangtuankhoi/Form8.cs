using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18607077_ledangtuankhoi
{
    public partial class frmkhachhang : Form
    {
        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.KhachHang' table. You can move, or remove it, as needed.

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.KhachHangTableAdapter.Fill(this.DataSet1.KhachHang);
            this.reportViewer1.RefreshReport();
        }
    }
}
