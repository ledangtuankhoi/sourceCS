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
    public partial class Form4 : Form
    {
        string strConnectionstring = @" Data Source=PC12\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho = null;
        bool Them;
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionstring);
                daThanhPho = new SqlDataAdapter("select * from THANHPHO", conn);
                dtThanhPho = new DataTable();
                dtThanhPho.Clear();
                daThanhPho.Fill(dtThanhPho);
                dgvThanhpho.DataSource = dtThanhPho;

                this.txttenthanhpho.ResetText();
                this.txttenthanhpho.ResetText();
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;

                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnXoa.Enabled = true;

            }
            catch (SqlException)
            {

                MessageBox.Show("khong lay dc du lieu trong table THANHPHO. loi roi");

            }
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            this.txtthanhpho.ResetText();
            this.txttenthanhpho.ResetText();
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.txtthanhpho.Focus();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            int r = dgvThanhpho.CurrentCell.RowIndex;
            this.txtthanhpho.Text = dgvThanhpho.Rows[r].Cells[0].Value.ToString();
            this.txttenthanhpho.Text = dgvThanhpho.Rows[r].Cells[1].Value.ToString();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtthanhpho.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand(); cmd.Connection = conn; cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int r = dgvThanhpho.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strTHANHPHO = dgvThanhpho.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From ThanhPho Where ThanhPho='" + strTHANHPHO + "'"); cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView LoadData();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
            // Đóng kết nối 
            conn.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtthanhpho.ResetText();
            this.txttenthanhpho.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true; this.btnSua.Enabled = true; this.btnXoa.Enabled = true; this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false; this.panel1.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối 
            conn.Open();
            // Thêm dữ liệu 
            if (Them)
            {
            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand(); 
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lệnh Insert InTo
                cmd.CommandText = System.String.Concat("Insert Into ThanhPho Values(" + "'" + this.txtthanhpho.Text.ToString() + "','" + this.txttenthanhpho.Text.ToString() + "')"); 
                cmd.CommandType = CommandType.Text; 
                cmd.ExecuteNonQuery();
                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo
                MessageBox.Show("Đã thêm xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            }
            if (!Them)
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand(); cmd.Connection = conn; cmd.CommandType = CommandType.Text;
                // Thứ tự dòng hiện hành
                int r = dgvThanhpho.CurrentCell.RowIndex;
                // MaKH hiện hành 
                string strTHANHPHO = dgvThanhpho.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL
                cmd.CommandText = System.String.Concat("Update ThanhPho Set TenThanhPho='" + this.txttenthanhpho.Text.ToString() + "' Where ThanhPho='" + strTHANHPHO + "'");
                // Cập nhật
                cmd.CommandType = CommandType.Text; cmd.ExecuteNonQuery();
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
            conn.Close();


        }

    }
}