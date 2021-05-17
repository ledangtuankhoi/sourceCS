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

namespace buoi9
{
    public partial class Form1 : Form
    {
       
        string strConnectionString = "Data Source=PC05/SQLEXPRESS; Initial Catalog=QuanLyBanHang; Integrated Security=True";
 
        SqlConnection conn= null;
      
        SqlDataAdapter daThanhPho = null;

        DataTable dtThanhPho = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection(strConnectionString);
           // daTABLENAME = new SqlDataAdapter("SELECT * FROM TABLENAME", conn);
            //dtTABLENAME = new DataTable();
          //  daTABLENAME.Fill(dtTABLENAME);

       try
       {

        conn = new SqlConnection (strConnectionString); 

        daThanhPho = new SqlDataAdapter("SELECT * FROM  THANHPHO" , conn);
        dtThanhPho = new DataTable();
        dtThanhPho.Clear(); 
        daThanhPho.Fill(dtThanhPho);
        this.lstThanhPho.DataSource = dtThanhPho; 
        this.lstThanhPho.DisplayMember = "TenThanhPho" ;
        this.lstThanhPho.ValueMember = "ThanhPho";
        }
        catch (SqlException )
        {
        MessageBox.Show("Khong lay du9c n9i dung trong table THANHPHO. L6i r6i!!!");

        }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dtThanhPho.Dispose();
            dtThanhPho = null; 
            conn = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        DialogResult traloi;
        traloi = MessageBox.Show("Chae khong?", "Tra loi",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)Application.Exit();
        }
    }
}
