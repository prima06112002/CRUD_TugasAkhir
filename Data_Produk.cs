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
    public partial class Data_Produk : Form
    {
        private string stringConnection = "data source=DESKTOP-794RG4I\\PRIMA06;" + "database=Toko_Buku; User ID = sa; Password = 123";
        private SqlConnection conn;
        public Data_Produk()
        {
            InitializeComponent();
            cbKategori();
        }
        private void refresh()
        {
            this.Close();
            DashBoard db = new DashBoard();
            db.Show();
        }

        private void cbKategori()
        {
            conn = new SqlConnection(stringConnection);
            conn.Open();
            string strs = "Select Nama_Kategori From Kategori";
            SqlCommand cm = new SqlCommand(strs, conn);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbxKategori.Items.Add(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
        }

        private void Data_Produk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_BukuDataSet2.Produk' table. You can move, or remove it, as needed.
            this.produkTableAdapter.Fill(this.toko_BukuDataSet2.Produk);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (idProduktxt.Text == "")
            {
                MessageBox.Show("Masukan ID Produk!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Produk values(@ID_Produk, @Nama_Produk, @Deskripsi, @Harga, @Stok, @ID_Kategori)", conn);
                cmd.Parameters.AddWithValue("@ID_Produk", idProduktxt.Text);
                cmd.Parameters.AddWithValue("@Nama_Produk", namaProtxt.Text);
                cmd.Parameters.AddWithValue("@Deskripsi", desktxt.Text);
                cmd.Parameters.AddWithValue("@Harga", decimal.Parse(hargatxt.Text));
                cmd.Parameters.AddWithValue("@Stok", int.Parse(stoktxt.Text));
                cmd.Parameters.AddWithValue("@ID_Kategori", idKategoritxt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string str = "select ID_Kategori from dbo.Kategori where Nama_Kategori = @Nama_Kategori";
            SqlCommand cm = new SqlCommand(str, conn);
            string selectItem = cbxKategori.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@Nama_Kategori", selectItem);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nk = dr.GetString(0);
                idKategoritxt.Text = nk;
            }
            else
                idKategoritxt.Text = "";
            dr.Close();
            conn.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Produk set Nama_Produk = @Nama_Produk, Deskripsi = @Deskripsi, Harga = @Harga, Stok = @Stok, ID_Kategori = @ID_Kategori where ID_Produk = @ID_Produk)", conn);
            cmd.Parameters.AddWithValue("@ID_Produk", idProduktxt.Text);
            cmd.Parameters.AddWithValue("@Nama_Produk", namaProtxt.Text);
            cmd.Parameters.AddWithValue("@Deskripsi", desktxt.Text);
            cmd.Parameters.AddWithValue("@Harga", decimal.Parse(hargatxt.Text));
            cmd.Parameters.AddWithValue("@Stok", int.Parse(stoktxt.Text));
            cmd.Parameters.AddWithValue("@ID_Kategori", idKategoritxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Produk where @ID_Produk = ID_Produk", conn);
            cmd.Parameters.AddWithValue("@ID_Produk", idProduktxt.Text);
            conn.Close();

            MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }
    }
}
