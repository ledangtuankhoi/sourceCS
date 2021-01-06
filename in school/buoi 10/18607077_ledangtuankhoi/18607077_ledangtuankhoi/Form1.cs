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
    public partial class Form1 : Form
    {
        // Chuỗi kết nối
        string strConnectionString = @"Data Source=PC12;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        // Đối tượng kết nối 
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTable 
        SqlDataAdapter daTable = null;
        // Đối tượng hiển thị dữ liệu lên Form 
        DataTable dtTable = null;

           public void frmlogin()
           {
            Form frm = new Form2();
            frm.ShowDialog();
           }
           void XemDanhMuc(int intDanhMuc)
           {
               Form frm = new Form3();
               frm.Text = intDanhMuc.ToString(); 
               frm.ShowDialog();
           }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmlogin();
        }

        private void danhSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.ShowDialog();
        }

        private void danhSáchThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void danhSáchSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhSáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5 );
        }

        private void danhSáchChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.ShowDialog();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form5();
            frm.ShowDialog();
        }
    }
}
