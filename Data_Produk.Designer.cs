namespace CRUD_TugasAkhir
{
    partial class Data_Produk
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
            this.label5 = new System.Windows.Forms.Label();
            this.stoktxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hargatxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.desktxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaProtxt = new System.Windows.Forms.TextBox();
            this.idProduktxt = new System.Windows.Forms.TextBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.idKategoritxt = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toko_BukuDataSet2 = new CRUD_TugasAkhir.Toko_BukuDataSet2();
            this.produkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSet2TableAdapters.ProdukTableAdapter();
            this.iDProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_btn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Stok";
            // 
            // stoktxt
            // 
            this.stoktxt.Location = new System.Drawing.Point(321, 216);
            this.stoktxt.Name = "stoktxt";
            this.stoktxt.Size = new System.Drawing.Size(335, 26);
            this.stoktxt.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Harga";
            // 
            // hargatxt
            // 
            this.hargatxt.Location = new System.Drawing.Point(321, 167);
            this.hargatxt.Name = "hargatxt";
            this.hargatxt.Size = new System.Drawing.Size(335, 26);
            this.hargatxt.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Deskripsi";
            // 
            // desktxt
            // 
            this.desktxt.Location = new System.Drawing.Point(321, 124);
            this.desktxt.Name = "desktxt";
            this.desktxt.Size = new System.Drawing.Size(335, 26);
            this.desktxt.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nama Produk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID Produk";
            // 
            // namaProtxt
            // 
            this.namaProtxt.Location = new System.Drawing.Point(321, 82);
            this.namaProtxt.Name = "namaProtxt";
            this.namaProtxt.Size = new System.Drawing.Size(335, 26);
            this.namaProtxt.TabIndex = 23;
            // 
            // idProduktxt
            // 
            this.idProduktxt.Location = new System.Drawing.Point(321, 37);
            this.idProduktxt.Name = "idProduktxt";
            this.idProduktxt.Size = new System.Drawing.Size(335, 26);
            this.idProduktxt.TabIndex = 22;
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(321, 263);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(335, 28);
            this.cbxKategori.TabIndex = 32;
            this.cbxKategori.SelectedIndexChanged += new System.EventHandler(this.cbxKategori_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Kategori";
            // 
            // idKategoritxt
            // 
            this.idKategoritxt.AutoSize = true;
            this.idKategoritxt.Location = new System.Drawing.Point(317, 307);
            this.idKategoritxt.Name = "idKategoritxt";
            this.idKategoritxt.Size = new System.Drawing.Size(89, 20);
            this.idKategoritxt.TabIndex = 34;
            this.idKategoritxt.Text = "ID Kategori";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProdukDataGridViewTextBoxColumn,
            this.namaProdukDataGridViewTextBoxColumn,
            this.deskripsiDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.iDKategoriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produkBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(153, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(503, 208);
            this.dataGridView1.TabIndex = 35;
            // 
            // toko_BukuDataSet2
            // 
            this.toko_BukuDataSet2.DataSetName = "Toko_BukuDataSet2";
            this.toko_BukuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produkBindingSource
            // 
            this.produkBindingSource.DataMember = "Produk";
            this.produkBindingSource.DataSource = this.toko_BukuDataSet2;
            // 
            // produkTableAdapter
            // 
            this.produkTableAdapter.ClearBeforeFill = true;
            // 
            // iDProdukDataGridViewTextBoxColumn
            // 
            this.iDProdukDataGridViewTextBoxColumn.DataPropertyName = "ID_Produk";
            this.iDProdukDataGridViewTextBoxColumn.HeaderText = "ID_Produk";
            this.iDProdukDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDProdukDataGridViewTextBoxColumn.Name = "iDProdukDataGridViewTextBoxColumn";
            this.iDProdukDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaProdukDataGridViewTextBoxColumn
            // 
            this.namaProdukDataGridViewTextBoxColumn.DataPropertyName = "Nama_Produk";
            this.namaProdukDataGridViewTextBoxColumn.HeaderText = "Nama_Produk";
            this.namaProdukDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaProdukDataGridViewTextBoxColumn.Name = "namaProdukDataGridViewTextBoxColumn";
            this.namaProdukDataGridViewTextBoxColumn.Width = 150;
            // 
            // deskripsiDataGridViewTextBoxColumn
            // 
            this.deskripsiDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.HeaderText = "Deskripsi";
            this.deskripsiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.deskripsiDataGridViewTextBoxColumn.Name = "deskripsiDataGridViewTextBoxColumn";
            this.deskripsiDataGridViewTextBoxColumn.Width = 150;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.Width = 150;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.Width = 150;
            // 
            // iDKategoriDataGridViewTextBoxColumn
            // 
            this.iDKategoriDataGridViewTextBoxColumn.DataPropertyName = "ID_Kategori";
            this.iDKategoriDataGridViewTextBoxColumn.HeaderText = "ID_Kategori";
            this.iDKategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDKategoriDataGridViewTextBoxColumn.Name = "iDKategoriDataGridViewTextBoxColumn";
            this.iDKategoriDataGridViewTextBoxColumn.Width = 150;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(465, 599);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(85, 35);
            this.delete_btn.TabIndex = 38;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(354, 599);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 35);
            this.updateBtn.TabIndex = 37;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(242, 599);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 35);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Data_Produk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 672);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idKategoritxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stoktxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hargatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desktxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namaProtxt);
            this.Controls.Add(this.idProduktxt);
            this.Name = "Data_Produk";
            this.Text = "Data Produk";
            this.Load += new System.EventHandler(this.Data_Produk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stoktxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hargatxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desktxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaProtxt;
        private System.Windows.Forms.TextBox idProduktxt;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label idKategoritxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Toko_BukuDataSet2 toko_BukuDataSet2;
        private System.Windows.Forms.BindingSource produkBindingSource;
        private Toko_BukuDataSet2TableAdapters.ProdukTableAdapter produkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}