namespace CRUD_TugasAkhir
{
    partial class Pesanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.idPesanantxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPesanan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxPelanggan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxEkspedisi = new System.Windows.Forms.ComboBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Pesanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal_Pesanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEkspedisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_BukuDataSet4 = new CRUD_TugasAkhir.Toko_BukuDataSet4();
            this.toko_BukuDataSet3 = new CRUD_TugasAkhir.Toko_BukuDataSet3();
            this.ekspedisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ekspedisiTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSet3TableAdapters.EkspedisiTableAdapter();
            this.pesananTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSet4TableAdapters.PesananTableAdapter();
            this.IDPeltxt = new System.Windows.Forms.Label();
            this.IDEkstxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekspedisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Pesanan";
            // 
            // idPesanantxt
            // 
            this.idPesanantxt.Location = new System.Drawing.Point(307, 34);
            this.idPesanantxt.Name = "idPesanantxt";
            this.idPesanantxt.Size = new System.Drawing.Size(335, 26);
            this.idPesanantxt.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tanggal Pesan";
            // 
            // dtPesanan
            // 
            this.dtPesanan.CustomFormat = "MM-dd-yyyy";
            this.dtPesanan.Location = new System.Drawing.Point(307, 103);
            this.dtPesanan.Name = "dtPesanan";
            this.dtPesanan.Size = new System.Drawing.Size(200, 26);
            this.dtPesanan.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nama Pelanggan";
            // 
            // cbxPelanggan
            // 
            this.cbxPelanggan.FormattingEnabled = true;
            this.cbxPelanggan.Location = new System.Drawing.Point(307, 151);
            this.cbxPelanggan.Name = "cbxPelanggan";
            this.cbxPelanggan.Size = new System.Drawing.Size(335, 28);
            this.cbxPelanggan.TabIndex = 30;
            this.cbxPelanggan.SelectedIndexChanged += new System.EventHandler(this.cbxPelanggan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nama Ekspedisi";
            // 
            // cbxEkspedisi
            // 
            this.cbxEkspedisi.FormattingEnabled = true;
            this.cbxEkspedisi.Location = new System.Drawing.Point(307, 241);
            this.cbxEkspedisi.Name = "cbxEkspedisi";
            this.cbxEkspedisi.Size = new System.Drawing.Size(335, 28);
            this.cbxEkspedisi.TabIndex = 32;
            this.cbxEkspedisi.SelectedIndexChanged += new System.EventHandler(this.cbxEkspedisi_SelectedIndexChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(462, 722);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(85, 35);
            this.delete_btn.TabIndex = 41;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(351, 722);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 35);
            this.updateBtn.TabIndex = 40;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(239, 722);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 35);
            this.saveBtn.TabIndex = 39;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pesanan,
            this.Tanggal_Pesanan,
            this.ID_Pelanggan,
            this.iDEkspedisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pesananBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 329);
            this.dataGridView1.TabIndex = 42;
            // 
            // ID_Pesanan
            // 
            this.ID_Pesanan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Pesanan.DataPropertyName = "ID_Pesanan";
            this.ID_Pesanan.HeaderText = "ID Pesanan";
            this.ID_Pesanan.MinimumWidth = 8;
            this.ID_Pesanan.Name = "ID_Pesanan";
            // 
            // Tanggal_Pesanan
            // 
            this.Tanggal_Pesanan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tanggal_Pesanan.DataPropertyName = "Tanggal_Pesanan";
            this.Tanggal_Pesanan.HeaderText = "Tanggal Pesanan";
            this.Tanggal_Pesanan.MinimumWidth = 8;
            this.Tanggal_Pesanan.Name = "Tanggal_Pesanan";
            // 
            // ID_Pelanggan
            // 
            this.ID_Pelanggan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Pelanggan.DataPropertyName = "ID_Pelanggan";
            this.ID_Pelanggan.HeaderText = "ID Pelanggan";
            this.ID_Pelanggan.MinimumWidth = 8;
            this.ID_Pelanggan.Name = "ID_Pelanggan";
            // 
            // iDEkspedisiDataGridViewTextBoxColumn
            // 
            this.iDEkspedisiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDEkspedisiDataGridViewTextBoxColumn.DataPropertyName = "ID_Ekspedisi";
            this.iDEkspedisiDataGridViewTextBoxColumn.HeaderText = "ID Ekspedisi";
            this.iDEkspedisiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDEkspedisiDataGridViewTextBoxColumn.Name = "iDEkspedisiDataGridViewTextBoxColumn";
            // 
            // pesananBindingSource
            // 
            this.pesananBindingSource.DataMember = "Pesanan";
            this.pesananBindingSource.DataSource = this.toko_BukuDataSet4;
            // 
            // toko_BukuDataSet4
            // 
            this.toko_BukuDataSet4.DataSetName = "Toko_BukuDataSet4";
            this.toko_BukuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toko_BukuDataSet3
            // 
            this.toko_BukuDataSet3.DataSetName = "Toko_BukuDataSet3";
            this.toko_BukuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ekspedisiBindingSource
            // 
            this.ekspedisiBindingSource.DataMember = "Ekspedisi";
            this.ekspedisiBindingSource.DataSource = this.toko_BukuDataSet3;
            // 
            // ekspedisiTableAdapter
            // 
            this.ekspedisiTableAdapter.ClearBeforeFill = true;
            // 
            // pesananTableAdapter
            // 
            this.pesananTableAdapter.ClearBeforeFill = true;
            // 
            // IDPeltxt
            // 
            this.IDPeltxt.AutoSize = true;
            this.IDPeltxt.Location = new System.Drawing.Point(303, 182);
            this.IDPeltxt.Name = "IDPeltxt";
            this.IDPeltxt.Size = new System.Drawing.Size(106, 20);
            this.IDPeltxt.TabIndex = 43;
            this.IDPeltxt.Text = "ID Pelanggan";
            // 
            // IDEkstxt
            // 
            this.IDEkstxt.AutoSize = true;
            this.IDEkstxt.Location = new System.Drawing.Point(303, 272);
            this.IDEkstxt.Name = "IDEkstxt";
            this.IDEkstxt.Size = new System.Drawing.Size(98, 20);
            this.IDEkstxt.TabIndex = 44;
            this.IDEkstxt.Text = "ID Ekspedisi";
            // 
            // Pesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 769);
            this.Controls.Add(this.IDEkstxt);
            this.Controls.Add(this.IDPeltxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cbxEkspedisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxPelanggan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPesanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idPesanantxt);
            this.Name = "Pesanan";
            this.Text = "Pesanan";
            this.Load += new System.EventHandler(this.Pesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekspedisiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idPesanantxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPesanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxPelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxEkspedisi;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Toko_BukuDataSet3 toko_BukuDataSet3;
        private System.Windows.Forms.BindingSource ekspedisiBindingSource;
        private Toko_BukuDataSet3TableAdapters.EkspedisiTableAdapter ekspedisiTableAdapter;
        private Toko_BukuDataSet4 toko_BukuDataSet4;
        private System.Windows.Forms.BindingSource pesananBindingSource;
        private Toko_BukuDataSet4TableAdapters.PesananTableAdapter pesananTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal_Pesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEkspedisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label IDPeltxt;
        private System.Windows.Forms.Label IDEkstxt;
    }
}