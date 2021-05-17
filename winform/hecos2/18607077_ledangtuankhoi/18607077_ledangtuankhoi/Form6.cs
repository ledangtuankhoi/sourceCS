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
    public partial class Form6 : Form
    {
        string strConnectionString = @"Data Source=DESKTOP-5RKP31B;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daNhanVien = null;
        DataTable dthanVien= null;
        bool Them;
        void LoadData()
        {
            try
            {
                conn = new SqlConnection(strConnectionString);
                daNhanVien = new SqlDataAdapter("select * from KhachHang", conn);
                dthanVien= new DataTable();
                dthanVien.Clear();
                daNhanVien.Fill(dthanVien);
                dgvnhanvien.DataSource = dthanVien;


                this.txtdt.ResetText();
                this.txtdiacho.ResetText();
                this.txtho.ResetText();
                this.txtma.ResetText();
                this.txtten.ResetText();
                this.txtngayNV.ResetText();


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
        public Form6()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.panel1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            Them = true;
            this.txtdt.ResetText();
            this.txtdiacho.ResetText();
            this.txtho.ResetText();
            this.txtma.ResetText();
            this.txtten.ResetText();
            this.txtngayNV.ResetText();

            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.txtma.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            int r = dgvnhanvien.CurrentCell.RowIndex;
            this.txtma.Text = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
            this.txtho.Text = dgvnhanvien.Rows[r].Cells[1].Value.ToString();
            this.txtngayNV.Text = dgvnhanvien.Rows[r].Cells[2].Value.ToString();      
            this.txtdiacho.Text = dgvnhanvien.Rows[r].Cells[3].Value.ToString();
            this.txtdt.Text = dgvnhanvien.Rows[r].Cells[4].Value.ToString();


            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;

            this.txtma.Focus();
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
                    int a;
                    if (this.checkBox1.Checked == true) a = 1; else a = 0;
                    cmd.CommandText = System.String.Concat("Insert Into NhanVien Values(" + "'" + this.txtma.Text.ToString() + "','" + this.txtho.Text.ToString() + "','" + this.txtten.Text.ToString() + "','" + a + "','" + this.txtngayNV.Text.ToString() + "','" + this.txtdiacho.Text.ToString() + "','" + this.txtdt.Text.ToString() + "')");
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
                int r = dgvnhanvien.CurrentCell.RowIndex;
                // MaKH hiện hành 
                string strTHANHPHO = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh SQL
                cmd.CommandText = System.String.Concat("Update NhanVien Set MaNV='" + this.txtma.Text.ToString() + "' Where Ten='" + strTHANHPHO + "'");
                //int a;
                //if (this.checkBox1.Checked == true) a = 1; else a = 0;
                //cmd.CommandText = System.String.Concat("update NhanVien set '" + this.txtma.Text.ToString() + "','" + this.txtho.Text.ToString() + "','" + this.txtten.Text.ToString() + "','" + a + "','" + this.txtngayNV.Text.ToString() + "','" + this.txtdiacho.Text.ToString() + "','" + this.txtdt.Text.ToString() + "')");
                    
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtdt.ResetText();
            this.txtdiacho.ResetText();
            this.txtho.ResetText();
            this.txtma.ResetText();
            this.txtten.ResetText();
            this.txtngayNV.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.btnThem.Enabled = true; 
            this.btnSua.Enabled = true; 
            this.btnXoa.Enabled = true; 
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false; 
            this.panel1.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                // Thực hiện lệnh
                SqlCommand cmd = new SqlCommand(); cmd.Connection = conn; cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành
                int r = dgvnhanvien.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strTHANHPHO = dgvnhanvien.Rows[r].Cells[0].Value.ToString();
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
    }
}
