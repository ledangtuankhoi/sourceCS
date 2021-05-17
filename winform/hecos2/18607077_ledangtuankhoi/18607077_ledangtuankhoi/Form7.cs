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
    public partial class frmChiTiethoadon : Form
    {
        public frmChiTiethoadon()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsThuVien.ChiTietHoaDon' table. You can move, or remove it, as needed.
            this.ChiTietHoaDonTableAdapter.Fill(this.dsThuVien.ChiTietHoaDon);

            this.reportViewer1.RefreshReport();
        }
    }
}
