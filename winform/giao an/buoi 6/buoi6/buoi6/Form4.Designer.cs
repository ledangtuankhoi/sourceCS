namespace buoi6
{
    partial class frmBai3
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.bttTinh = new System.Windows.Forms.Button();
            this.bbtXoa = new System.Windows.Forms.Button();
            this.bttClose = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhap n=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "nhap m=";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(117, 30);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 1;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(117, 96);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 1;
            this.txtM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(0, 20);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(158, 17);
            this.rad1.TabIndex = 2;
            this.rad1.TabStop = true;
            this.rad1.Text = "các ước chung \\của m và n";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Location = new System.Drawing.Point(272, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn";
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(0, 43);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(152, 17);
            this.rad2.TabIndex = 2;
            this.rad2.TabStop = true;
            this.rad2.Text = "chung lớn nhất của m và n";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // bttTinh
            // 
            this.bttTinh.Location = new System.Drawing.Point(36, 217);
            this.bttTinh.Name = "bttTinh";
            this.bttTinh.Size = new System.Drawing.Size(75, 23);
            this.bttTinh.TabIndex = 5;
            this.bttTinh.Text = "tính";
            this.bttTinh.UseVisualStyleBackColor = true;
            this.bttTinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // bbtXoa
            // 
            this.bbtXoa.Location = new System.Drawing.Point(202, 217);
            this.bbtXoa.Name = "bbtXoa";
            this.bbtXoa.Size = new System.Drawing.Size(75, 23);
            this.bbtXoa.TabIndex = 5;
            this.bbtXoa.Text = "xóa";
            this.bbtXoa.UseVisualStyleBackColor = true;
            this.bbtXoa.Click += new System.EventHandler(this.bbtXoa_Click);
            // 
            // bttClose
            // 
            this.bttClose.Location = new System.Drawing.Point(397, 217);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(75, 23);
            this.bttClose.TabIndex = 5;
            this.bttClose.Text = "close";
            this.bttClose.UseVisualStyleBackColor = true;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(36, 180);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(433, 20);
            this.txtOut.TabIndex = 1;
            this.txtOut.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "kết quả là";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 252);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.bbtXoa);
            this.Controls.Add(this.bttTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bai3";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.RadioButton rad1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad2;
        private System.Windows.Forms.Button bttTinh;
        private System.Windows.Forms.Button bbtXoa;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label3;
    }
}