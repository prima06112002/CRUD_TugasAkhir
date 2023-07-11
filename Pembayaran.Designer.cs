namespace CRUD_TugasAkhir
{
    partial class Pembayaran
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idPembtxt = new System.Windows.Forms.TextBox();
            this.bayartxt = new System.Windows.Forms.TextBox();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxmetode = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.toko_BukuDataSet6 = new CRUD_TugasAkhir.Toko_BukuDataSet6();
            this.pembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pembayaranTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSet6TableAdapters.PembayaranTableAdapter();
            this.iDPembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodePembayaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Metode Pembayaran";
            // 
            // idPembtxt
            // 
            this.idPembtxt.Location = new System.Drawing.Point(294, 48);
            this.idPembtxt.Name = "idPembtxt";
            this.idPembtxt.Size = new System.Drawing.Size(414, 26);
            this.idPembtxt.TabIndex = 4;
            // 
            // bayartxt
            // 
            this.bayartxt.Location = new System.Drawing.Point(294, 177);
            this.bayartxt.Name = "bayartxt";
            this.bayartxt.Size = new System.Drawing.Size(414, 26);
            this.bayartxt.TabIndex = 5;
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(294, 94);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(414, 28);
            this.cbxNama.TabIndex = 6;
            this.cbxNama.SelectedIndexChanged += new System.EventHandler(this.cbxNama_SelectedIndexChanged);
            // 
            // cbxmetode
            // 
            this.cbxmetode.FormattingEnabled = true;
            this.cbxmetode.Items.AddRange(new object[] {
            "Cash",
            "QRIS",
            "Transfer"});
            this.cbxmetode.Location = new System.Drawing.Point(294, 232);
            this.cbxmetode.Name = "cbxmetode";
            this.cbxmetode.Size = new System.Drawing.Size(227, 28);
            this.cbxmetode.TabIndex = 7;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(290, 138);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(106, 20);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID Pelanggan";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPembayaranDataGridViewTextBoxColumn,
            this.iDPelangganDataGridViewTextBoxColumn,
            this.totalPembayaranDataGridViewTextBoxColumn,
            this.metodePembayaranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pembayaranBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(775, 407);
            this.dataGridView1.TabIndex = 9;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(465, 739);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(85, 35);
            this.delBtn.TabIndex = 16;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(354, 739);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 35);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(242, 739);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 35);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toko_BukuDataSet6
            // 
            this.toko_BukuDataSet6.DataSetName = "Toko_BukuDataSet6";
            this.toko_BukuDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pembayaranBindingSource
            // 
            this.pembayaranBindingSource.DataMember = "Pembayaran";
            this.pembayaranBindingSource.DataSource = this.toko_BukuDataSet6;
            // 
            // pembayaranTableAdapter
            // 
            this.pembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // iDPembayaranDataGridViewTextBoxColumn
            // 
            this.iDPembayaranDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDPembayaranDataGridViewTextBoxColumn.DataPropertyName = "ID_Pembayaran";
            this.iDPembayaranDataGridViewTextBoxColumn.HeaderText = "ID Pembayaran";
            this.iDPembayaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPembayaranDataGridViewTextBoxColumn.Name = "iDPembayaranDataGridViewTextBoxColumn";
            // 
            // iDPelangganDataGridViewTextBoxColumn
            // 
            this.iDPelangganDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDPelangganDataGridViewTextBoxColumn.DataPropertyName = "ID_Pelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.HeaderText = "ID Pelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPelangganDataGridViewTextBoxColumn.Name = "iDPelangganDataGridViewTextBoxColumn";
            // 
            // totalPembayaranDataGridViewTextBoxColumn
            // 
            this.totalPembayaranDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPembayaranDataGridViewTextBoxColumn.DataPropertyName = "Total_Pembayaran";
            this.totalPembayaranDataGridViewTextBoxColumn.HeaderText = "Total Pembayaran";
            this.totalPembayaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPembayaranDataGridViewTextBoxColumn.Name = "totalPembayaranDataGridViewTextBoxColumn";
            // 
            // metodePembayaranDataGridViewTextBoxColumn
            // 
            this.metodePembayaranDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.metodePembayaranDataGridViewTextBoxColumn.DataPropertyName = "Metode_Pembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.HeaderText = "Metode Pembayaran";
            this.metodePembayaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.metodePembayaranDataGridViewTextBoxColumn.Name = "metodePembayaranDataGridViewTextBoxColumn";
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 804);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cbxmetode);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.bayartxt);
            this.Controls.Add(this.idPembtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pembayaran";
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.Pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembayaranBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idPembtxt;
        private System.Windows.Forms.TextBox bayartxt;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxmetode;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private Toko_BukuDataSet6 toko_BukuDataSet6;
        private System.Windows.Forms.BindingSource pembayaranBindingSource;
        private Toko_BukuDataSet6TableAdapters.PembayaranTableAdapter pembayaranTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPembayaranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodePembayaranDataGridViewTextBoxColumn;
    }
}