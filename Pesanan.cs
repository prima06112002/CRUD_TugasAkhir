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
    public partial class Pesanan : Form
    {
        private string stringConnection = "data source=DESKTOP-794RG4I\\PRIMA06;" + "database=Toko_Buku; User ID = sa; Password = 123";
        private SqlConnection conn;
        public Pesanan()
        {
            InitializeComponent();
            cbPelanggan();
            cbEkspedisi();
        }
        private void Refresh()
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Close();
        }
        private void cbPelanggan()
        {
            conn = new SqlConnection(stringConnection);
            conn.Open();
            string strs = "Select Nama_Pelanggan From Pelanggan";
            SqlCommand cm = new SqlCommand(strs, conn);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbxPelanggan.Items.Add(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
        }
        private void cbEkspedisi()
        {
            conn = new SqlConnection(stringConnection);
            conn.Open();
            string strs = "Select Nama_Ekspedisi From Ekspedisi";
            SqlCommand cm = new SqlCommand(strs, conn);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbxEkspedisi.Items.Add(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
        }

        private void Pesanan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_BukuDataSet4.Pesanan' table. You can move, or remove it, as needed.
            this.pesananTableAdapter.Fill(this.toko_BukuDataSet4.Pesanan);

        }

        private void cbxPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string str = "select ID_Pelanggan from dbo.Pelanggan where Nama_Pelanggan = @Nama_Pelanggan";
            SqlCommand cm = new SqlCommand(str, conn);
            string selectItem = cbxPelanggan.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@Nama_Pelanggan", selectItem);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string iniVariabel = dr.GetString(0);
                IDPeltxt.Text = iniVariabel;
            }
            else
                IDPeltxt.Text = "";
            dr.Close();
            conn.Close();
        }

        private void cbxEkspedisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            string str = "select ID_Ekspedisi from dbo.Ekspedisi where Nama_Ekspedisi = @Nama_Ekspedisi";
            SqlCommand cm = new SqlCommand(str, conn);
            string selectItem = cbxEkspedisi.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@Nama_Ekspedisi", selectItem);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string iniVariabel = dr.GetString(0);
                IDEkstxt.Text = iniVariabel;
            }
            else
                IDEkstxt.Text = "";
            dr.Close();
            conn.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idPesanantxt.Text == "")
            {
                MessageBox.Show("Masukan ID Pesanan!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Pesanan values(@ID_Pesanan, @Tanggal_Pesanan, @ID_Pelanggan, @ID_Ekspedisi)", conn);
                cmd.Parameters.AddWithValue("@ID_Pesanan", idPesanantxt.Text);
                cmd.Parameters.AddWithValue("@Tanggal_Pesanan", dtPesanan.Text);
                cmd.Parameters.AddWithValue("@ID_Pelanggan", IDPeltxt.Text);
                cmd.Parameters.AddWithValue("@ID_Ekspedisi", IDEkstxt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Pesanan set ID_Pesanan = @ID_Pesanan, Tanggal_Pesanan = @Tanggal_Pesanan, ID_Pelanggan = @ID_Pelanggan, ID_Ekspedisi = @ID_Ekspedisi)", conn);
            cmd.Parameters.AddWithValue("@ID_Pesanan", idPesanantxt.Text);
            cmd.Parameters.AddWithValue("@Tanggal_Pesanan", dtPesanan.Text);
            cmd.Parameters.AddWithValue("@ID_Pelanggan", IDPeltxt.Text);
            cmd.Parameters.AddWithValue("@ID_Ekspedisi", IDEkstxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Pesanan where ID_Pesanan = @ID_Pesanan", conn);
            cmd.Parameters.AddWithValue("@ID_Pesanan", idPesanantxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh();
        }
    }
}
