using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TugasAkhir
{
    public partial class Pembayaran : Form
    {
        private string stringConnection = "data source=DESKTOP-794RG4I\\PRIMA06;" + "database=Toko_Buku; User ID = sa; Password = 123";
        private SqlConnection conn;
        public Pembayaran()
        {
            InitializeComponent();
            cbPelanggan();
        }
        private void refreshform()
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
                cbxNama.Items.Add(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
        }
        private void Pembayaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_BukuDataSet6.Pembayaran' table. You can move, or remove it, as needed.
            this.pembayaranTableAdapter.Fill(this.toko_BukuDataSet6.Pembayaran);

        }

        private void cbxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(stringConnection);
            conn.Open();
            string str = "select ID_Pelanggan from dbo.Pelanggan where Nama_Pelanggan = @Nama_Pelanggan";
            SqlCommand cm = new SqlCommand(str, conn);
            string selectItem = cbxNama.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@Nama_Pelanggan", selectItem);
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                string nk = dr.GetString(0);
                idLabel.Text = nk;
            }
            else
                idLabel.Text = "";
            dr.Close();
            conn.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idPembtxt.Text == "")
            {
                MessageBox.Show("Masukan ID Pembayaran!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Pembayaran values(@ID_Pembayaran, @ID_Pelanggan, @Total_Pembayaran, @Metode_Pembayaran)", conn);
                cmd.Parameters.AddWithValue("@ID_Pembayaran", idPembtxt.Text);
                cmd.Parameters.AddWithValue("@ID_Pelanggan", idLabel.Text);
                cmd.Parameters.AddWithValue("@Total_Pembayaran", decimal.Parse(bayartxt.Text));
                cmd.Parameters.AddWithValue("@Metode_Pembayaran", cbxmetode.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Pembayaran set ID_Pembayaran = @ID_Pembayaran, ID_Pelanggan = @ID_Pelanggan, Total_Pembayaran = @Total_Pembayaran, Metode_Pembayaran = @Metode_Pembayaran)", conn);
            cmd.Parameters.AddWithValue("@ID_Pembayaran", idPembtxt.Text);
            cmd.Parameters.AddWithValue("@ID_Pelanggan", idLabel.Text);
            cmd.Parameters.AddWithValue("@Total_Pembayaran", decimal.Parse(bayartxt.Text));
            cmd.Parameters.AddWithValue("@Metode_Pembayaran", cbxmetode.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Pembayaran where ID_Pembayaran = @ID_Pembayaran)", conn);
            cmd.Parameters.AddWithValue("@ID_Pembayaran", idPembtxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }
    }
}
