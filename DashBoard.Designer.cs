namespace CRUD_TugasAkhir
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPesananToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBuktiPembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataPelangganToolStripMenuItem,
            this.dataProdukToolStripMenuItem,
            this.dataKategoriToolStripMenuItem,
            this.dataPesananToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.dataPembayaranToolStripMenuItem,
            this.dataBuktiPembayaranToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(126, 33);
            this.toolStripDropDownButton1.Text = "Data Master";
            // 
            // dataPelangganToolStripMenuItem
            // 
            this.dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            this.dataPelangganToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.dataPelangganToolStripMenuItem.Text = "Data Pelanggan";
            this.dataPelangganToolStripMenuItem.Click += new System.EventHandler(this.dataPelangganToolStripMenuItem_Click);
            // 
            // dataProdukToolStripMenuItem
            // 
            this.dataProdukToolStripMenuItem.Name = "dataProdukToolStripMenuItem";
            this.dataProdukToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.dataProdukToolStripMenuItem.Text = "Data Produk";
            this.dataProdukToolStripMenuItem.Click += new System.EventHandler(this.dataProdukToolStripMenuItem_Click);
            // 
            // dataKategoriToolStripMenuItem
            // 
            this.dataKategoriToolStripMenuItem.Name = "dataKategoriToolStripMenuItem";
            this.dataKategoriToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.dataKategoriToolStripMenuItem.Text = "Data Kategori";
            this.dataKategoriToolStripMenuItem.Click += new System.EventHandler(this.dataKategoriToolStripMenuItem_Click);
            // 
            // dataPesananToolStripMenuItem
            // 
            this.dataPesananToolStripMenuItem.Name = "dataPesananToolStripMenuItem";
            this.dataPesananToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.dataPesananToolStripMenuItem.Text = "Data Pesanan";
            this.dataPesananToolStripMenuItem.Click += new System.EventHandler(this.dataPesananToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.dataToolStripMenuItem.Text = "Data Ekspedisi";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // dataPembayaranToolStripMenuItem
            // 
            this.dataPembayaranToolStripMenuItem.Name = "dataPembayaranToolStripMenuItem";
            this.dataPembayaranToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.dataPembayaranToolStripMenuItem.Text = "Data Pembayaran";
            this.dataPembayaranToolStripMenuItem.Click += new System.EventHandler(this.dataPembayaranToolStripMenuItem_Click);
            // 
            // dataBuktiPembayaranToolStripMenuItem
            // 
            this.dataBuktiPembayaranToolStripMenuItem.Name = "dataBuktiPembayaranToolStripMenuItem";
            this.dataBuktiPembayaranToolStripMenuItem.Size = new System.Drawing.Size(297, 34);
            this.dataBuktiPembayaranToolStripMenuItem.Text = "Data Bukti Pembayaran";
            this.dataBuktiPembayaranToolStripMenuItem.Click += new System.EventHandler(this.dataBuktiPembayaranToolStripMenuItem_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataProdukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPesananToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBuktiPembayaranToolStripMenuItem;
    }
}