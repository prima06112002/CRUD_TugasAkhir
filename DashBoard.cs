using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_TugasAkhir
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void dataKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriForm kf = new KategoriForm();
            kf.ShowDialog();
            this.Close();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelanggan p = new Pelanggan();
            p.ShowDialog();
            this.Close();
        }

        private void dataProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Produk dp = new Data_Produk();
            dp.ShowDialog();
            this.Close();
        }

        private void dataPesananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pesanan ps = new Pesanan();
            ps.ShowDialog();
            this.Close();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekspedisi es = new Ekspedisi();
            es.ShowDialog();
            this.Close();
        }

        private void dataPembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pembayaran pmb = new Pembayaran();
            pmb.ShowDialog();
            this.Close();
        }

        private void dataBuktiPembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bukti_Pembayaran bkp = new Bukti_Pembayaran();
            bkp.ShowDialog();
            this.Close();
        }
    }
}
