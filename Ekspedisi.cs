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
    public partial class Ekspedisi : Form
    {
        private string stringConnection = "data source=DESKTOP-794RG4I\\PRIMA06;" + "database=Toko_Buku; User ID = sa; Password = 123";
        private SqlConnection conn;
        public Ekspedisi()
        {
            InitializeComponent();
        }

        private void refreshForm()
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Close();
        }
        private void Ekspedisi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toko_BukuDataSet5.Ekspedisi' table. You can move, or remove it, as needed.
            this.ekspedisiTableAdapter.Fill(this.toko_BukuDataSet5.Ekspedisi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtxt.Text == "")
            {
                MessageBox.Show("Masukan ID Ekspedisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into Ekspedisi values(@ID_Ekspedisi, @Nama_Ekspedisi, @Tarif)", conn);
                cmd.Parameters.AddWithValue("@ID_Ekspedisi", idtxt.Text);
                cmd.Parameters.AddWithValue("@Nama_Ekspedisi", namatxt.Text);
                cmd.Parameters.AddWithValue("@Tarif", tariftxt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Ekspedisi set ID_Ekspedisi = @ID_Ekspedisi, Nama_Ekspedisi = @Nama_Ekspedisi, Tarif = @Tarif)", conn);
            cmd.Parameters.AddWithValue("@ID_Ekspedisi", idtxt.Text);
            cmd.Parameters.AddWithValue("@Nama_Ekspedisi", namatxt.Text);
            cmd.Parameters.AddWithValue("@Tarif", tariftxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Ekspedisi where @ID_Ekspedisi = ID_Ekspedisi)", conn);
            cmd.Parameters.AddWithValue("@ID_Ekspedisi", idtxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshForm();
        }
    }
}
