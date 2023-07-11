namespace CRUD_TugasAkhir
{
    partial class Ekspedisi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.namatxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tariftxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toko_BukuDataSet5 = new CRUD_TugasAkhir.Toko_BukuDataSet5();
            this.ekspedisiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ekspedisiTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSet5TableAdapters.EkspedisiTableAdapter();
            this.iDEkspedisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaEkspedisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekspedisiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama Ekspedisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Ekspedisi";
            // 
            // namatxt
            // 
            this.namatxt.Location = new System.Drawing.Point(307, 87);
            this.namatxt.Name = "namatxt";
            this.namatxt.Size = new System.Drawing.Size(335, 26);
            this.namatxt.TabIndex = 5;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(307, 38);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(335, 26);
            this.idtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarif";
            // 
            // tariftxt
            // 
            this.tariftxt.Location = new System.Drawing.Point(307, 141);
            this.tariftxt.Name = "tariftxt";
            this.tariftxt.Size = new System.Drawing.Size(335, 26);
            this.tariftxt.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEkspedisiDataGridViewTextBoxColumn,
            this.namaEkspedisiDataGridViewTextBoxColumn,
            this.tarifDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ekspedisiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 348);
            this.dataGridView1.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(475, 600);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toko_BukuDataSet5
            // 
            this.toko_BukuDataSet5.DataSetName = "Toko_BukuDataSet5";
            this.toko_BukuDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ekspedisiBindingSource
            // 
            this.ekspedisiBindingSource.DataMember = "Ekspedisi";
            this.ekspedisiBindingSource.DataSource = this.toko_BukuDataSet5;
            // 
            // ekspedisiTableAdapter
            // 
            this.ekspedisiTableAdapter.ClearBeforeFill = true;
            // 
            // iDEkspedisiDataGridViewTextBoxColumn
            // 
            this.iDEkspedisiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDEkspedisiDataGridViewTextBoxColumn.DataPropertyName = "ID_Ekspedisi";
            this.iDEkspedisiDataGridViewTextBoxColumn.HeaderText = "ID Ekspedisi";
            this.iDEkspedisiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDEkspedisiDataGridViewTextBoxColumn.Name = "iDEkspedisiDataGridViewTextBoxColumn";
            // 
            // namaEkspedisiDataGridViewTextBoxColumn
            // 
            this.namaEkspedisiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaEkspedisiDataGridViewTextBoxColumn.DataPropertyName = "Nama Ekspedisi";
            this.namaEkspedisiDataGridViewTextBoxColumn.HeaderText = "Nama_Ekspedisi";
            this.namaEkspedisiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaEkspedisiDataGridViewTextBoxColumn.Name = "namaEkspedisiDataGridViewTextBoxColumn";
            // 
            // tarifDataGridViewTextBoxColumn
            // 
            this.tarifDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarifDataGridViewTextBoxColumn.DataPropertyName = "Tarif";
            this.tarifDataGridViewTextBoxColumn.HeaderText = "Tarif";
            this.tarifDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tarifDataGridViewTextBoxColumn.Name = "tarifDataGridViewTextBoxColumn";
            // 
            // Ekspedisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tariftxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namatxt);
            this.Controls.Add(this.idtxt);
            this.Name = "Ekspedisi";
            this.Text = "Ekspedisi";
            this.Load += new System.EventHandler(this.Ekspedisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekspedisiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namatxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tariftxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Toko_BukuDataSet5 toko_BukuDataSet5;
        private System.Windows.Forms.BindingSource ekspedisiBindingSource;
        private Toko_BukuDataSet5TableAdapters.EkspedisiTableAdapter ekspedisiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEkspedisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaEkspedisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifDataGridViewTextBoxColumn;
    }
}