namespace _18607077_ledangtuankhoi
{
    partial class frmChiTiethoadon
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsThuVien = new _18607077_ledangtuankhoi.dsThuVien();
            this.ChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiTietHoaDonTableAdapter = new _18607077_ledangtuankhoi.dsThuVienTableAdapters.ChiTietHoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsThuVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChiTietHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "_18607077_ledangtuankhoi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(872, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsThuVien
            // 
            this.dsThuVien.DataSetName = "dsThuVien";
            this.dsThuVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiTietHoaDonBindingSource
            // 
            this.ChiTietHoaDonBindingSource.DataMember = "ChiTietHoaDon";
            this.ChiTietHoaDonBindingSource.DataSource = this.dsThuVien;
            // 
            // ChiTietHoaDonTableAdapter
            // 
            this.ChiTietHoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmChiTiethoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 490);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmChiTiethoadon";
            this.Text = "báo cáo chi tiet khach hang";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsThuVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiTietHoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiTietHoaDonBindingSource;
        private dsThuVien dsThuVien;
        private dsThuVienTableAdapters.ChiTietHoaDonTableAdapter ChiTietHoaDonTableAdapter;
    }
}