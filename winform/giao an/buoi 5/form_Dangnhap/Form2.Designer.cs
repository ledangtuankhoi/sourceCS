namespace form_Dangnhap
{
    partial class frmChaoMung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttBaiTap1 = new System.Windows.Forms.Button();
            this.bttBaiTap2 = new System.Windows.Forms.Button();
            this.bttBaiTap3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRUNG TÂM MẠNG MÁY TÍNH NHẤT NGHỆ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "LẬP TRÌNH MÁY TÍNH CƠ BẢN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "o0-----0o";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(137, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "CHƯƠNG TRÌNH MINH HỌA";
            // 
            // bttBaiTap1
            // 
            this.bttBaiTap1.Location = new System.Drawing.Point(76, 196);
            this.bttBaiTap1.Name = "bttBaiTap1";
            this.bttBaiTap1.Size = new System.Drawing.Size(95, 47);
            this.bttBaiTap1.TabIndex = 1;
            this.bttBaiTap1.Text = "BaiTap1";
            this.bttBaiTap1.UseVisualStyleBackColor = true;
            this.bttBaiTap1.Click += new System.EventHandler(this.bttBaiiTap1_Click);
            // 
            // bttBaiTap2
            // 
            this.bttBaiTap2.Location = new System.Drawing.Point(218, 196);
            this.bttBaiTap2.Name = "bttBaiTap2";
            this.bttBaiTap2.Size = new System.Drawing.Size(97, 47);
            this.bttBaiTap2.TabIndex = 2;
            this.bttBaiTap2.Text = "Bài tập 2";
            this.bttBaiTap2.UseVisualStyleBackColor = true;
            this.bttBaiTap2.Click += new System.EventHandler(this.bttBaiTap2_Click);
            // 
            // bttBaiTap3
            // 
            this.bttBaiTap3.Location = new System.Drawing.Point(367, 196);
            this.bttBaiTap3.Name = "bttBaiTap3";
            this.bttBaiTap3.Size = new System.Drawing.Size(97, 47);
            this.bttBaiTap3.TabIndex = 2;
            this.bttBaiTap3.Text = "Bài tập 3";
            this.bttBaiTap3.UseVisualStyleBackColor = true;
            this.bttBaiTap3.Click += new System.EventHandler(this.bttBaiTap3_Click);
            // 
            // frmChaoMung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 318);
            this.Controls.Add(this.bttBaiTap3);
            this.Controls.Add(this.bttBaiTap2);
            this.Controls.Add(this.bttBaiTap1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChaoMung";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmChaoMung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttBaiTap1;
        private System.Windows.Forms.Button bttBaiTap2;
        private System.Windows.Forms.Button bttBaiTap3;
    }
}