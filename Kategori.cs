using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TugasAkhir
{
    public partial class KategoriForm : Form
    {
        private string stringConnection = "data source=DESKTOP-794RG4I\\PRIMA06;" + "database=Toko_Buku; User ID = sa; Password = 123";
        private SqlConnection conn;
        public KategoriForm()
        {
            InitializeComponent();
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_BukuDataSet.Kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.toko_BukuDataSet.Kategori);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idKtg = IDKategoritxt.Text;
            string namaKtg = namaKategoritxt.Text;

            if(idKtg == "")
            {
                MessageBox.Show("Masukan ID Kategori!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Kategori values(@ID_Kategori, @Nama_Kategori)", conn);
                cmd.Parameters.AddWithValue("@ID_Kategori", idKtg);
                cmd.Parameters.AddWithValue("@Nama_Kategori", namaKtg);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Kategori set ID_Kategori = @ID_Kategori, Nama_Kategori = @Nama_Kategori", conn);
            cmd.Parameters.AddWithValue("@ID_Kategori", IDKategoritxt.Text);
            cmd.Parameters.AddWithValue("@Nama_Kategori", namaKategoritxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Kategori where ID_Kategori = @ID_Kategori", conn);
            cmd.Parameters.AddWithValue("@ID_Kategori", IDKategoritxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
