using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TugasAkhir
{
    public partial class Pelanggan : Form
    {
        private string stringConnection = "data source=DESKTOP-794RG4I\\PRIMA06;" + "database=Toko_Buku; User ID = sa; Password = 123";
        private SqlConnection conn;
        public Pelanggan()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            this.Close();
            DashBoard db = new DashBoard();
            db.Show();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (IDPelanggantxt.Text == "")
            {
                MessageBox.Show("Masukan ID Kategori!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Pelanggan values(@ID_Pelanggan, @Nama_Pelanggan, @Alamat, @Nomor_Telepon, @Email)", conn);
                cmd.Parameters.AddWithValue("@ID_Pelanggan", IDPelanggantxt.Text);
                cmd.Parameters.AddWithValue("@Nama_Pelanggan", namaPelanggantxt.Text);
                cmd.Parameters.AddWithValue("@Alamat", alamatPelanggantxt.Text);
                cmd.Parameters.AddWithValue("@Nomor_Telepon", hpPelanggantxt.Text);
                cmd.Parameters.AddWithValue("@Email", emailPelanggantxt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Pelanggan set Nama_Pelanggan = @Nama_Pelanggan, Alamat = @Alamat, Nomor_Telepon = @Nomor_Telepon, Email = @Email where ID_Pelanggan = @ID_Pelanggan", conn);
            cmd.Parameters.AddWithValue("@ID_Pelanggan", IDPelanggantxt.Text);
            cmd.Parameters.AddWithValue("@Nama_Pelanggan", namaPelanggantxt.Text);
            cmd.Parameters.AddWithValue("@Alamat", alamatPelanggantxt.Text);
            cmd.Parameters.AddWithValue("@Nomor_Telepon", hpPelanggantxt.Text);
            cmd.Parameters.AddWithValue("@Email", emailPelanggantxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Pelanggan where ID_Pelanggan = @ID_Pelanggan", conn);
            cmd.Parameters.AddWithValue("@ID_Pelanggan", IDPelanggantxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refresh();
        }

        private void Pelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_BukuDataSet1.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.toko_BukuDataSet1.Pelanggan);

        }
    }
}
