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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
            this.txtUser.Focus();
        }
        

        private void bttDangNhap_Click(object sender, EventArgs e)
        {
            /*
            string thongbao;
            thongbao = "tên đang nhâp: "; thongbao += this.txtUser.Text; thongbao += "\n";
            thongbao += "Mật Khẩu:"; thongbao += this.txtPass.Text; thongbao += "\n";

            if (this.chbGhiNho.Checked == true)
            {
                thongbao += "Ghi Nho Dang NHap!";
            }
            else thongbao += "KHONG ghi nho dang nhap?";
            MessageBox.Show(thongbao, "Thông Báo");
            */

            if (true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("mật khẩu hoặc tên đăng nhâp chưa đúng", "thông báo");
                this.txtPass.Focus();
            }
        }

        private void bttDung_Click(object sender, EventArgs e)
        {
            //this.Close();
            DialogResult traloi;
            traloi = MessageBox.Show("bạn có chăc chắn muốn dừng!!", "trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttXoa_Click(object sender, EventArgs e)
        {
            this.txtPass.Clear();
            this.txtUser.Clear();
            this.txtUser.Focus();
        }
    }
}
