﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "123") && (this.txtPass.Text == "123")) this.Close();

            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                this.txtUser.Focus();

            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
            if (traloi == DialogResult.OK)
                Application.Exit();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
