using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TugasAkhir
{
    public partial class Bukti_Pembayaran : Form
    {
        private string stringConnection = "data source=DESKTOP-794RG4I\\PRIMA06;" + "database=Toko_Buku; User ID = sa; Password = 123";
        private SqlConnection conn;
        String curFileName;
        String savedImageName = "";
        Image curImage;

        public Bukti_Pembayaran()
        {
            InitializeComponent();
            cbPembayaran();
        }
        private void cbPembayaran()
        {
            conn = new SqlConnection(stringConnection);
            conn.Open();
            string strs = "Select Nama_Pelanggan From Pelanggan";
            SqlCommand cm = new SqlCommand(strs, conn);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                cbxID.Items.Add(dr.GetString(0));
            }
            dr.Close();
            conn.Close();
        }

        private void brwbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                curFileName = ofd.FileName;
                textBox1.Text = curFileName;

            }
        }

        private void Bukti_Pembayaran_Load(object sender, EventArgs e)
        {
            /*LoadData();*/

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (idPembtxt.Text == "")
            {
                MessageBox.Show("Masukan ID Bukti Pembayaran!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileStream file = new FileStream(curFileName, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] rawdata = new byte [file.Length];
                file.Read(rawdata, 0, System.Convert.ToInt32(file.Length));
                file.Close();
                string sql = "Select * From Bukti_Pembayaran";


                SqlConnection conn = new SqlConnection(stringConnection);
                conn.Open();

                SqlDataAdapter adpt = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adpt);
                DataSet ds = new DataSet("Bukti_Pembayaran");

                adpt.Fill(ds, "Bukti_Pembayaran");
                DataRow dtr = ds.Tables["Bukti_Pembayaran"].NewRow();
                dtr["ID_Bukti_Pembayaran"] = idPembtxt.Text;
                dtr["ID_Pembayaran"] = idLabel.Text;
                dtr["Tanggal_Pembayaran"] = dtBukti.Text;
                dtr["Total_Pembayaran"] = bayartxt.Text;
                dtr["Foto_Bukti_Pembayaran"] = rawdata;

                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*SqlCommand cmd = new SqlCommand("insert into Bukti_Pembayaran values(@ID_Bukti_Pembayaran, @ID_Pembayaran, @Tanggal_Pembayaran, @Total_Pembayaran, @Foto_Bukti_Pembayaran)", conn);
                cmd.Parameters.AddWithValue("@ID_Bukti_Pembayaran", idPembtxt.Text);
                cmd.Parameters.AddWithValue("@ID_Pembayaran", idLabel.Text);
                cmd.Parameters.AddWithValue("@Tanggal_Pembayaran", dtBukti.Text);
                cmd.Parameters.AddWithValue("@Total_Pembayaran", bayartxt.Text);
                MemoryStream memstr = new MemoryStream();
                pictureBox1.Image.Save(memstr, pictureBox1.Image.RawFormat);
                cmd.Parameters.AddWithValue("@Foto_Bukti_Pembayaran", memstr.ToArray());
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();*/
            }
        }

        private void LoadData()
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select*from Bukti_Pembayaran", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.RowTemplate.Height = 75;
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn pic1 = new DataGridViewImageColumn();
            pic1 = (DataGridViewImageColumn)dataGridView1.Columns[2];
            pic1.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Bukti_Pembayaran set ID_Pembayaran = @ID_Pembayaran, Tanggal_Pembayaran = @Tanggal_Pembayaran, Total_Pembayaran = @Total_Pembayaran, Foto_Bukti_Pembayaran = @Foto_Bukti_Pembayaran, where ID_Bukti_Pembayaran = @ID_Bukti_Pembayaran)", conn);
            cmd.Parameters.AddWithValue("@ID_Bukti_Pembayaran", idPembtxt.Text);
            cmd.Parameters.AddWithValue("@ID_Pembayaran", idLabel.Text);
            cmd.Parameters.AddWithValue("@Tanggal_Pembayaran", dtBukti.Text);
            cmd.Parameters.AddWithValue("@Total_Pembayaran", bayartxt.Text);
          /*  cmd.Parameters.AddWithValue("@Foto_Bukti_Pembayaran", );*/
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(stringConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete Bukti_Pembayaran where ID_Bukti_Pembayaran = @ID_Bukti_Pembayaran)", conn);
            cmd.Parameters.AddWithValue("@ID_Bukti_Pembayaran", idPembtxt.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Berhasil Ditambah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(stringConnection);
            conn.Open();
            string str = "select ID_Pembayaran from dbo.Pembayaran where ID_Pelanggan = @ID_Pelanggan";
            SqlCommand cm = new SqlCommand(str, conn);
            string selectItem = cbxID.SelectedItem.ToString();
            cm.Parameters.AddWithValue("@ID_Pelanggan", selectItem);
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
    }
}
