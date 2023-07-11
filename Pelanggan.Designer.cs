namespace CRUD_TugasAkhir
{
    partial class Pelanggan
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namaPelanggantxt = new System.Windows.Forms.TextBox();
            this.IDPelanggantxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alamatPelanggantxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hpPelanggantxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailPelanggantxt = new System.Windows.Forms.TextBox();
            this.toko_BukuDataSet1 = new CRUD_TugasAkhir.Toko_BukuDataSet1();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pelangganTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSet1TableAdapters.PelangganTableAdapter();
            this.iDPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomorTeleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(468, 538);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(85, 35);
            this.delete_btn.TabIndex = 15;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(357, 538);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 35);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(245, 538);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 35);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPelangganDataGridViewTextBoxColumn,
            this.namaPelangganDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.nomorTeleponDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pelangganBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(149, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(503, 212);
            this.dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID Pelanggan";
            // 
            // namaPelanggantxt
            // 
            this.namaPelanggantxt.Location = new System.Drawing.Point(317, 95);
            this.namaPelanggantxt.Name = "namaPelanggantxt";
            this.namaPelanggantxt.Size = new System.Drawing.Size(335, 26);
            this.namaPelanggantxt.TabIndex = 9;
            // 
            // IDPelanggantxt
            // 
            this.IDPelanggantxt.Location = new System.Drawing.Point(317, 50);
            this.IDPelanggantxt.Name = "IDPelanggantxt";
            this.IDPelanggantxt.Size = new System.Drawing.Size(335, 26);
            this.IDPelanggantxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alamat";
            // 
            // alamatPelanggantxt
            // 
            this.alamatPelanggantxt.Location = new System.Drawing.Point(317, 137);
            this.alamatPelanggantxt.Name = "alamatPelanggantxt";
            this.alamatPelanggantxt.Size = new System.Drawing.Size(335, 26);
            this.alamatPelanggantxt.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nomor Telephone";
            // 
            // hpPelanggantxt
            // 
            this.hpPelanggantxt.Location = new System.Drawing.Point(317, 180);
            this.hpPelanggantxt.Name = "hpPelanggantxt";
            this.hpPelanggantxt.Size = new System.Drawing.Size(335, 26);
            this.hpPelanggantxt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(145, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email";
            // 
            // emailPelanggantxt
            // 
            this.emailPelanggantxt.Location = new System.Drawing.Point(317, 229);
            this.emailPelanggantxt.Name = "emailPelanggantxt";
            this.emailPelanggantxt.Size = new System.Drawing.Size(335, 26);
            this.emailPelanggantxt.TabIndex = 20;
            // 
            // toko_BukuDataSet1
            // 
            this.toko_BukuDataSet1.DataSetName = "Toko_BukuDataSet1";
            this.toko_BukuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.toko_BukuDataSet1;
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // iDPelangganDataGridViewTextBoxColumn
            // 
            this.iDPelangganDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDPelangganDataGridViewTextBoxColumn.DataPropertyName = "ID_Pelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.HeaderText = "ID Pelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDPelangganDataGridViewTextBoxColumn.Name = "iDPelangganDataGridViewTextBoxColumn";
            // 
            // namaPelangganDataGridViewTextBoxColumn
            // 
            this.namaPelangganDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaPelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.HeaderText = "Nama Pelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaPelangganDataGridViewTextBoxColumn.Name = "namaPelangganDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // nomorTeleponDataGridViewTextBoxColumn
            // 
            this.nomorTeleponDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomorTeleponDataGridViewTextBoxColumn.DataPropertyName = "Nomor_Telepon";
            this.nomorTeleponDataGridViewTextBoxColumn.HeaderText = "Nomor Telepon";
            this.nomorTeleponDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomorTeleponDataGridViewTextBoxColumn.Name = "nomorTeleponDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailPelanggantxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hpPelanggantxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alamatPelanggantxt);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namaPelanggantxt);
            this.Controls.Add(this.IDPelanggantxt);
            this.Name = "Pelanggan";
            this.Text = "Pelanggan";
            this.Load += new System.EventHandler(this.Pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaPelanggantxt;
        private System.Windows.Forms.TextBox IDPelanggantxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alamatPelanggantxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hpPelanggantxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailPelanggantxt;
        private Toko_BukuDataSet1 toko_BukuDataSet1;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private Toko_BukuDataSet1TableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomorTeleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}