using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _18607077_ledangtuankhoi
{
    public partial class Form5 : Form
    {

        string strConnectionString = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daKhachHang = null;
        DataTable dtKhachHang = null;
        bool Them;
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daKhachHang = new SqlDataAdapter("select * from KhachHang", conn);
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                dgvkhachhang.DataSource = dtKhachHang;


                this.txtTenCt.ResetText();
                this.txtDiachi.ResetText();
                this.txtDT.ResetText();
                this.txtThanhPho.ResetText();
                this.txtmaKH.ResetText();

                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
            }
            catch (SqlException)
            {

                MessageBox.Show("khong lay dc du lieu trong table THANHPHO. loi roi");

            }
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Them = true;
            this.txtTenCt.ResetText();
            this.txtDiachi.ResetText();
            this.txtDT.ResetText();
            this.txtThanhPho.ResetText();
            this.txtmaKH.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.txtmaKH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            int r = dgvkhachhang.CurrentCell.RowIndex;
            this.txtmaKH.Text = dgvkhachhang.Rows[r].Cells[0].Value.ToString();
            this.txtTenCt.Text = dgvkhachhang.Rows[r].Cells[1].Value.ToString();
            this.txtDiachi.Text = dgvkhachhang.Rows[r].Cells[2].Value.ToString();
            this.txtThanhPho.Text = dgvkhachhang.Rows[r].Cells[3].Value.ToString();
            this.txtDT.Text = dgvkhachhang.Rows[r].Cells[4].Value.ToString();
  

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtmaKH.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
