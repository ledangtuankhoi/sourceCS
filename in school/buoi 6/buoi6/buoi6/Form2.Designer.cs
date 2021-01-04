namespace buoi6
{
    partial class frmMenu
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
            this.bttLIstbox = new System.Windows.Forms.Button();
            this.bbtBai1 = new System.Windows.Forms.Button();
            this.bttBai2 = new System.Windows.Forms.Button();
            this.bttClose = new System.Windows.Forms.Button();
            this.bttBai3 = new System.Windows.Forms.Button();
            this.bttBai6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "buổi thứ 6";
            // 
            // bttLIstbox
            // 
            this.bttLIstbox.Location = new System.Drawing.Point(16, 75);
            this.bttLIstbox.Name = "bttLIstbox";
            this.bttLIstbox.Size = new System.Drawing.Size(75, 23);
            this.bttLIstbox.TabIndex = 1;
            this.bttLIstbox.Text = "ListBoxDemo";
            this.bttLIstbox.UseVisualStyleBackColor = true;
            this.bttLIstbox.Click += new System.EventHandler(this.bttLIstbox_Click);
            // 
            // bbtBai1
            // 
            this.bbtBai1.Location = new System.Drawing.Point(109, 75);
            this.bbtBai1.Name = "bbtBai1";
            this.bbtBai1.Size = new System.Drawing.Size(75, 23);
            this.bbtBai1.TabIndex = 1;
            this.bbtBai1.Text = "Bài 1";
            this.bbtBai1.UseVisualStyleBackColor = true;
            this.bbtBai1.Click += new System.EventHandler(this.bbtBai1_Click);
            // 
            // bttBai2
            // 
            this.bttBai2.Location = new System.Drawing.Point(207, 75);
            this.bttBai2.Name = "bttBai2";
            this.bttBai2.Size = new System.Drawing.Size(75, 23);
            this.bttBai2.TabIndex = 1;
            this.bttBai2.Text = "Bài 2";
            this.bttBai2.UseVisualStyleBackColor = true;
            this.bttBai2.Click += new System.EventHandler(this.bttBai2_Click);
            // 
            // bttClose
            // 
            this.bttClose.BackColor = System.Drawing.Color.Gray;
            this.bttClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bttClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bttClose.Location = new System.Drawing.Point(207, 185);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(75, 23);
            this.bttClose.TabIndex = 2;
            this.bttClose.Text = "Close";
            this.bttClose.UseVisualStyleBackColor = false;
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // bttBai3
            // 
            this.bttBai3.Location = new System.Drawing.Point(16, 121);
            this.bttBai3.Name = "bttBai3";
            this.bttBai3.Size = new System.Drawing.Size(75, 30);
            this.bttBai3.TabIndex = 3;
            this.bttBai3.Text = "bài 3";
            this.bttBai3.UseVisualStyleBackColor = true;
            this.bttBai3.Click += new System.EventHandler(this.bttBai3_Click);
            // 
            // bttBai6
            // 
            this.bttBai6.Location = new System.Drawing.Point(109, 121);
            this.bttBai6.Name = "bttBai6";
            this.bttBai6.Size = new System.Drawing.Size(75, 23);
            this.bttBai6.TabIndex = 4;
            this.bttBai6.Text = "Bai 6";
            this.bttBai6.UseVisualStyleBackColor = true;
            this.bttBai6.Click += new System.EventHandler(this.bttBai6_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 220);
            this.Controls.Add(this.bttBai6);
            this.Controls.Add(this.bttBai3);
            this.Controls.Add(this.bttClose);
            this.Controls.Add(this.bttBai2);
            this.Controls.Add(this.bbtBai1);
            this.Controls.Add(this.bttLIstbox);
            this.Controls.Add(this.label1);
            this.Name = "frmMenu";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttLIstbox;
        private System.Windows.Forms.Button bbtBai1;
        private System.Windows.Forms.Button bttBai2;
        private System.Windows.Forms.Button bttClose;
        private System.Windows.Forms.Button bttBai3;
        private System.Windows.Forms.Button bttBai6;
    }
}