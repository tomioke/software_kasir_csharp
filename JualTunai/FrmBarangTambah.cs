using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JualTunai
{
    public partial class FrmBarangTambah : Form
    {
        public bool editState = false;
        MySqlDataReader dr;
        public FrmBarangTambah()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTmbhBrg_Load(object sender, EventArgs e)
        {
            txtKategori.Items.Clear();
            H.FillCmbTerm(txtKategori);

            txtSatuan.Items.Clear();
            H.FillCmbTerm(txtSatuan, "satuan");
            H.DsbControls(txtLaba);
            if (editState)
            {
                dr = H.openTable("tb_barang", "kode='" + H.IdEdit + "'");
                if (dr.Read())
                {
                    txtKode.Text = dr["kode"].ToString();
                    txtNama.Text = dr["nama"].ToString();
                    txtKategori.Text = dr["kategori"].ToString();
                    txtSatuan.Text = dr["satuan"].ToString();
                    txtHargaBeli.Text = dr["hargabeli"].ToString();
                    txtHargaJual.Text = dr["hargajual"].ToString();
                    txtJumlah.Text = dr["jumlah"].ToString();
                    txtNama.Focus();
                }

                H.DsbControls(txtKode);
                btnAuto.Visible = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtKode.Text == "" && !editState)
            {
                H.msgError("Kode tidak boleh kosong!");
                txtKode.Focus();
                return;
            }
            if (txtNama.Text == "")
            {
                H.msgError("Nama tidak boleh kosong!");
                txtNama.Focus();
                return;
            }

            if (H.isKdExist(txtKode.Text) && !editState)
            {
                H.msgError("Kode sudah ada!");
                txtKode.Focus();
                return;
            }

            if (editState)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE tb_barang SET nama=@nama, kategori=@kategori, satuan=@satuan, hargabeli=@hargabeli, hargajual=@hargajual, jumlah=@jumlah, laba=@laba WHERE kode=@kode", H.getConnection());
                cmd.Parameters.AddWithValue("kode", txtKode.Text);
                cmd.Parameters.AddWithValue("nama", txtNama.Text.ToString());
                cmd.Parameters.AddWithValue("kategori", txtKategori.Text.ToString());
                cmd.Parameters.AddWithValue("satuan", txtSatuan.Text.ToString());
                cmd.Parameters.AddWithValue("hargabeli", H.toD(txtHargaBeli.Text));
                cmd.Parameters.AddWithValue("hargajual", H.toD(txtHargaJual.Text));
                cmd.Parameters.AddWithValue("jumlah", H.toD(txtJumlah.Text));
                cmd.Parameters.AddWithValue("laba", H.toD(txtHargaJual.Text) - H.toD(txtHargaBeli.Text));
                H.executeCMD(cmd); 
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_barang (kode, nama, kategori, satuan, hargabeli, hargajual, jumlah, laba) VALUES(@kode, @nama, @kategori, @satuan, @hargabeli, @hargajual, @jumlah, @laba)", H.getConnection());
                cmd.Parameters.AddWithValue("kode", txtKode.Text.ToString());
                cmd.Parameters.AddWithValue("nama", txtNama.Text.ToString());
                cmd.Parameters.AddWithValue("kategori", txtKategori.Text.ToString());
                cmd.Parameters.AddWithValue("satuan", txtSatuan.Text.ToString());
                cmd.Parameters.AddWithValue("hargabeli", H.toD(txtHargaBeli.Text));
                cmd.Parameters.AddWithValue("hargajual", H.toD(txtHargaJual.Text));
                cmd.Parameters.AddWithValue("jumlah", H.toD(txtJumlah.Text));
                cmd.Parameters.AddWithValue("laba", H.toD(txtHargaJual.Text) - H.toD(txtHargaBeli.Text));
                H.executeCMD(cmd);
            }
            H.msgInfo("Data tersimpan");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void txtCariKat_Click(object sender, EventArgs e)
        {
            FrmTerms f = new FrmTerms();

            if (f.ShowDialog() == DialogResult.Yes)
            {
                txtKategori.Text = H.IdCari;
            }
        }

        private void txtCariSat_Click(object sender, EventArgs e)
        {
            FrmTerms f = new FrmTerms();
            f.term_taxonomy = "satuan";
            if (f.ShowDialog() == DialogResult.Yes)
            {
                txtSatuan.Text = H.IdCari;
            }
        }

        private void txtHargaBeli_TextChanged(object sender, EventArgs e)
        {
            getLaba();
        }

        void getLaba()
        {
            double laba = 0;

            double hb = H.toD(txtHargaBeli.Text);
            double hj = H.toD(txtHargaJual.Text);
            if (hj > 0 && hb > 0)
            {
                laba = (hj - hb) / hb * 100;
            }
            txtLaba.Text = laba.ToString();
        }

        private void txtHargaJual_TextChanged(object sender, EventArgs e)
        {
            getLaba();
        }

        private void txtAuto_Click(object sender, EventArgs e)
        {
            txtKode.Text = H.kodeOto("tb_barang", "kode", "BR", 5);
        }

        private void FrmTmbhBrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKeluar_Click(null, null);
            }
        }
    }
}
