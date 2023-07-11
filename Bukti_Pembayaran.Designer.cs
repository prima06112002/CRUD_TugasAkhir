namespace CRUD_TugasAkhir
{
    partial class Bukti_Pembayaran
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
            this.idLabel = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.bayartxt = new System.Windows.Forms.TextBox();
            this.idPembtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtBukti = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brwbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.toko_BukuDataSet7 = new CRUD_TugasAkhir.Toko_BukuDataSet7();
            this.buktiPembayaranBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bukti_PembayaranTableAdapter = new CRUD_TugasAkhir.Toko_BukuDataSet7TableAdapters.Bukti_PembayaranTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buktiPembayaranBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(291, 124);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(119, 20);
            this.idLabel.TabIndex = 17;
            this.idLabel.Text = "ID Pembayaran";
            // 
            // cbxID
            // 
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(295, 79);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(414, 28);
            this.cbxID.TabIndex = 15;
            this.cbxID.SelectedIndexChanged += new System.EventHandler(this.cbxID_SelectedIndexChanged);
            // 
            // bayartxt
            // 
            this.bayartxt.Location = new System.Drawing.Point(295, 219);
            this.bayartxt.Name = "bayartxt";
            this.bayartxt.Size = new System.Drawing.Size(414, 26);
            this.bayartxt.TabIndex = 14;
            // 
            // idPembtxt
            // 
            this.idPembtxt.Location = new System.Drawing.Point(295, 33);
            this.idPembtxt.Name = "idPembtxt";
            this.idPembtxt.Size = new System.Drawing.Size(414, 26);
            this.idPembtxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Foto Bukti Pembayaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total Pembayaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID Pembayaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Bukti Pembayaran";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tanggal Pembayaran";
            // 
            // dtBukti
            // 
            this.dtBukti.CustomFormat = "MM-dd-yyyy";
            this.dtBukti.Location = new System.Drawing.Point(295, 168);
            this.dtBukti.Name = "dtBukti";
            this.dtBukti.Size = new System.Drawing.Size(200, 26);
            this.dtBukti.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(295, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 252);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // brwbtn
            // 
            this.brwbtn.Location = new System.Drawing.Point(600, 277);
            this.brwbtn.Name = "brwbtn";
            this.brwbtn.Size = new System.Drawing.Size(109, 32);
            this.brwbtn.TabIndex = 21;
            this.brwbtn.Text = "Browse";
            this.brwbtn.UseVisualStyleBackColor = true;
            this.brwbtn.Click += new System.EventHandler(this.brwbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(777, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 654);
            this.panel1.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(472, 654);
            this.dataGridView1.TabIndex = 0;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(435, 601);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(85, 35);
            this.delBtn.TabIndex = 25;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(324, 601);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(85, 35);
            this.updateBtn.TabIndex = 24;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(212, 601);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(85, 35);
            this.saveBtn.TabIndex = 23;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // toko_BukuDataSet7
            // 
            this.toko_BukuDataSet7.DataSetName = "Toko_BukuDataSet7";
            this.toko_BukuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buktiPembayaranBindingSource
            // 
            this.buktiPembayaranBindingSource.DataMember = "Bukti_Pembayaran";
            this.buktiPembayaranBindingSource.DataSource = this.toko_BukuDataSet7;
            // 
            // bukti_PembayaranTableAdapter
            // 
            this.bukti_PembayaranTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(600, 337);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 26);
            this.textBox1.TabIndex = 26;
            // 
            // Bukti_Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 678);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.brwbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtBukti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.bayartxt);
            this.Controls.Add(this.idPembtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bukti_Pembayaran";
            this.Text = "Bukti_Pembayaran";
            this.Load += new System.EventHandler(this.Bukti_Pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toko_BukuDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buktiPembayaranBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.TextBox bayartxt;
        private System.Windows.Forms.TextBox idPembtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtBukti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button brwbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button saveBtn;
        private Toko_BukuDataSet7 toko_BukuDataSet7;
        private System.Windows.Forms.BindingSource buktiPembayaranBindingSource;
        private Toko_BukuDataSet7TableAdapters.Bukti_PembayaranTableAdapter bukti_PembayaranTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}