using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desktop_BuomBuom
{
    public partial class Form5 : Form
    {
        Timer time = new Timer();
        public Form5()
        {
            InitializeComponent();
            time.Interval = 100;
            time.Tick += new EventHandler(time_Tick);
            time.Start();
            pictureBox2.Visible = false;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
        }

        Random rd = new Random();
        Point vt = new Point();
        int changeX = 0;
        int changeY = 0;
        int dem_rd = 20;

        void time_Tick(object sender, EventArgs e)
        {            
            if (dem_rd == 20)
            {
                changeX = rd.Next(-3, 4);
                changeY = rd.Next(-3, 5);
            }
            dem_rd--;
            if (dem_rd == 0)
                dem_rd = 20;
            vt.X = pictureBox1.Location.X + changeX;
            vt.Y = pictureBox1.Location.Y + changeY;
            pictureBox1.Location = vt;
            if (pictureBox1.Location.Y > this.ClientSize.Height - 80)
                changeY = rd.Next(-3,0);
            if (pictureBox1.Location.Y < 0)
                changeY = rd.Next(0, 7);
            if (pictureBox1.Location.X < 0 || pictureBox1.Location.X > this.ClientSize.Width - 120)
                changeX = 0;
        }

        bool is_clicked = false;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                is_clicked = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (is_clicked)
            {
                Point p = new Point();
                p = this.PointToClient(MousePosition);
                pictureBox1.Location = p;
                this.Cursor = Cursors.Hand;
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            is_clicked = false;
            Point p = new Point();
            p = this.PointToClient(MousePosition);
            pictureBox1.Location = p;
            this.Cursor = Cursors.Default;            
        }
    }
}
