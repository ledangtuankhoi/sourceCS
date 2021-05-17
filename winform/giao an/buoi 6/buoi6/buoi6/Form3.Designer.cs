namespace buoi6
{
    partial class frmBai1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDongHo = new System.Windows.Forms.Label();
            this.bttBatDau = new System.Windows.Forms.Button();
            this.bttDung = new System.Windows.Forms.Button();
            this.txtOUt = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.lblChucMung = new System.Windows.Forms.Label();
            this.bttclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDongHo
            // 
            this.lblDongHo.AutoSize = true;
            this.lblDongHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongHo.Location = new System.Drawing.Point(67, 24);
            this.lblDongHo.Name = "lblDongHo";
            this.lblDongHo.Size = new System.Drawing.Size(80, 24);
            this.lblDongHo.TabIndex = 0;
            this.lblDongHo.Text = "bắt đầu";
            this.lblDongHo.Click += new System.EventHandler(this.lblDongHo_Click);
            // 
            // bttBatDau
            // 
            this.bttBatDau.Location = new System.Drawing.Point(12, 71);
            this.bttBatDau.Name = "bttBatDau";
            this.bttBatDau.Size = new System.Drawing.Size(75, 23);
            this.bttBatDau.TabIndex = 1;
            this.bttBatDau.Text = "Bắt Đầu";
            this.bttBatDau.UseVisualStyleBackColor = true;
            this.bttBatDau.Click += new System.EventHandler(this.bttBatDau_Click);
            // 
            // bttDung
            // 
            this.bttDung.Location = new System.Drawing.Point(116, 71);
            this.bttDung.Name = "bttDung";
            this.bttDung.Size = new System.Drawing.Size(75, 23);
            this.bttDung.TabIndex = 1;
            this.bttDung.Text = "Dừng";
            this.bttDung.UseVisualStyleBackColor = true;
            this.bttDung.Click += new System.EventHandler(this.bttDung_Click);
            // 
            // txtOUt
            // 
            this.txtOUt.Location = new System.Drawing.Point(12, 120);
            this.txtOUt.Multiline = true;
            this.txtOUt.Name = "txtOUt";
            this.txtOUt.Size = new System.Drawing.Size(281, 34);
            this.txtOUt.TabIndex = 2;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(163, 28);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(130, 20);
            this.txtIn.TabIndex = 3;
            this.txtIn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblChucMung
            // 
            this.lblChucMung.AutoSize = true;
            this.lblChucMung.Location = new System.Drawing.Point(33, 166);
            this.lblChucMung.Name = "lblChucMung";
            this.lblChucMung.Size = new System.Drawing.Size(35, 13);
            this.lblChucMung.TabIndex = 4;
            this.lblChucMung.Text = "label1";
            // 
            // bttclose
            // 
            this.bttclose.Location = new System.Drawing.Point(207, 71);
            this.bttclose.Name = "bttclose";
            this.bttclose.Size = new System.Drawing.Size(75, 23);
            this.bttclose.TabIndex = 5;
            this.bttclose.Text = "close";
            this.bttclose.UseVisualStyleBackColor = true;
            this.bttclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 226);
            this.Controls.Add(this.bttclose);
            this.Controls.Add(this.lblChucMung);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtOUt);
            this.Controls.Add(this.bttDung);
            this.Controls.Add(this.bttBatDau);
            this.Controls.Add(this.lblDongHo);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDongHo;
        private System.Windows.Forms.Button bttBatDau;
        private System.Windows.Forms.Button bttDung;
        private System.Windows.Forms.TextBox txtOUt;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label lblChucMung;
        private System.Windows.Forms.Button bttclose;
    }
}