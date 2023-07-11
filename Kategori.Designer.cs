namespace CRUD_TugasAkhir
{
    partial class KategoriForm
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
            this.IDKategoritxt = new System.Windows.Forms.TextBox();
            this.namaKategoritxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toko_BukuDataSet = new CRUD_TugasAkhir.Toko_BukuDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kategoriTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSetTableAdapters.KategoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IDKategoritxt
            // 
            this.IDKategoritxt.Location = new System.Drawing.Point(307, 36);
            this.IDKategoritxt.Name = "IDKategoritxt";
            this.IDKategoritxt.Size = new System.Drawing.Size(335, 26);
            this.IDKategoritxt.TabIndex = 0;
            // 
            // namaKategoritxt
            // 
            this.namaKategoritxt.Location = new System.Drawing.Point(307, 114);
            this.namaKategoritxt.Name = "namaKategoritxt";
            this.namaKategoritxt.Size = new System.Drawing.Size(335, 26);
            this.namaKategoritxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Kategori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama Kategori";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKategoriDataGridViewTextBoxColumn,
            this.namaKategoriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kategoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(139, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(503, 212);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDKategoriDataGridViewTextBoxColumn
            // 
            this.iDKategoriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDKategoriDataGridViewTextBoxColumn.DataPropertyName = "ID_Kategori";
            this.iDKategoriDataGridViewTextBoxColumn.HeaderText = "ID Kategori";
            this.iDKategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDKategoriDataGridViewTextBoxColumn.Name = "iDKategoriDataGridViewTextBoxColumn";
            // 
            // namaKategoriDataGridViewTextBoxColumn
            // 
            this.namaKategoriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaKategoriDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kategori";
            this.namaKategoriDataGridViewTextBoxColumn.HeaderText = "Nama Kategori";
            this.namaKategoriDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaKategoriDataGridViewTextBoxColumn.Name = "namaKategoriDataGridViewTextBoxColumn";
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.toko_BukuDataSet;
            // 
            // toko_BukuDataSet
            // 
            this.toko_BukuDataSet.DataSetName = "Toko_BukuDataSet";
            this.toko_BukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namaKategoritxt);
            this.Controls.Add(this.IDKategoritxt);
            this.Name = "KategoriForm";
            this.Text = "Input Kategori";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDKategoritxt;
        private System.Windows.Forms.TextBox namaKategoritxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Toko_BukuDataSet toko_BukuDataSet;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private Toko_BukuDataSetTableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKategoriDataGridViewTextBoxColumn;
    }
}

