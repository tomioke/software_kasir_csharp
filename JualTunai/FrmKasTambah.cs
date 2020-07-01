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
    public partial class FrmKasTambah : Form
    {
        public bool editState = false;
        MySqlDataReader dr;
        public FrmKasTambah()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTmbhBrg_Load(object sender, EventArgs e)
        {
            txtTanggal.Value = DateTime.Now;
            txtJenis.Items.Add("Pemasukan");
            txtJenis.Items.Add("Pengeluaran");

            H.DsbControls(txtPemasukan, txtPengeluaran);

            if (editState)
            {
                dr = H.openTable("tb_kas", "faktur='" + H.IdEdit + "'");
                if (dr.Read())
                {
                    txtFaktur.Text = dr["faktur"].ToString();
                    txtTanggal.Value = DateTime.Parse(dr["tanggal"].ToString());                                       
                    string kategori = dr["kategori"].ToString();
                    txtPemasukan.Text = dr["pemasukan"].ToString();
                    txtPengeluaran.Text = dr["pengeluaran"].ToString();
                    txtKeterangan.Text = dr["keterangan"].ToString();
                    txtJenis.Text = dr["jenis"].ToString();
                    txtKategori.Text  = kategori;
                }
                H.DsbControls(txtFaktur);
                btnAuto.Visible = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtFaktur.Text == "" && !editState)
            {
                H.msgError("Faktur tidak boleh kosong!");
                txtFaktur.Focus();
                return;
            }
            if (H.toD(txtPemasukan.Text)==0 && H.toD(txtPengeluaran.Text)==0)
            {
                H.msgError("Pemasukan atau pengeluaran harus diisi!");
                if (txtJenis.Text.ToLower() == "pemasukan") txtPemasukan.Focus();
                if (txtJenis.Text.ToLower() == "pengeluaran") txtPengeluaran.Focus();
                return;
            }

            if (H.isKdExist(txtFaktur.Text) && !editState)
            {
                H.msgError("Faktur sudah ada!");
                txtFaktur.Focus();
                return;
            }

            if (editState)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE tb_kas SET faktur=@faktur, tanggal=@tanggal, jenis=@jenis, kategori=@kategori, pemasukan=@pemasukan, pengeluaran=@pengeluaran, keterangan=@keterangan, operator=@operator WHERE faktur=@faktur", H.getConnection());
                cmd.Parameters.AddWithValue("faktur", txtFaktur.Text);
                cmd.Parameters.AddWithValue("tanggal", txtTanggal.Value);
                cmd.Parameters.AddWithValue("jenis", txtJenis.Text);
                cmd.Parameters.AddWithValue("kategori", txtKategori.Text);
                cmd.Parameters.AddWithValue("pemasukan", H.toD(txtPemasukan.Text));
                cmd.Parameters.AddWithValue("pengeluaran", H.toD(txtPengeluaran.Text));
                cmd.Parameters.AddWithValue("keterangan", txtKeterangan.Text);
                cmd.Parameters.AddWithValue("operator", H.strOperator);
                H.executeCMD(cmd); 
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tb_kas (faktur, tanggal, jenis, kategori, pemasukan, pengeluaran, keterangan, operator) VALUES(@faktur, @tanggal, @jenis, @kategori, @pemasukan, @pengeluaran, @keterangan, @operator)", H.getConnection());
                cmd.Parameters.AddWithValue("faktur", txtFaktur.Text);
                cmd.Parameters.AddWithValue("tanggal", txtTanggal.Value);
                cmd.Parameters.AddWithValue("jenis", txtJenis.Text);
                cmd.Parameters.AddWithValue("kategori", txtKategori.Text);
                cmd.Parameters.AddWithValue("pemasukan", H.toD(txtPemasukan.Text));
                cmd.Parameters.AddWithValue("pengeluaran", H.toD(txtPengeluaran.Text));
                cmd.Parameters.AddWithValue("keterangan", txtKeterangan.Text);
                cmd.Parameters.AddWithValue("operator", H.strOperator);
                H.executeCMD(cmd);
            }
            H.msgInfo("Data tersimpan");
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void txtCariKat_Click(object sender, EventArgs e)
        {
            FrmKategoriKas f = new FrmKategoriKas();

            if (f.ShowDialog() == DialogResult.Yes)
            {
                txtJenis.Text = H.IdCari;
                txtJenis_SelectedIndexChanged(null, null);
                txtKategori.Text = H.NmCari;
            }
        }

        private void txtCariSat_Click(object sender, EventArgs e)
        {
            FrmTerms f = new FrmTerms();
            f.term_taxonomy = "satuan";
            if (f.ShowDialog() == DialogResult.Yes)
            {
                txtKategori.Text = H.IdCari;
            }
        }
        
        private void txtAuto_Click(object sender, EventArgs e)
        {
            txtFaktur.Text = H.kodeOto("tb_kas", "faktur", "KAS-" + DateTime.Now.ToString("yyyyMMdd") + "-", 5);
        }

        private void FrmTmbhBrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKeluar_Click(null, null);
            }
        }

        private void txtJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr = H.OpenDr("SELECT kategori FROM tb_kategorikas WHERE jenis='" + txtJenis.Text + "'");
            txtKategori.Items.Clear();
            H.FillCmb(dr, txtKategori);

            if (txtJenis.Text.ToLower() == "pemasukan")
            {
                H.DsbControls(txtPengeluaran);
                H.EnbControls(txtPemasukan);
                txtPengeluaran.Text = "0";
            }
            else if (txtJenis.Text.ToLower() == "pengeluaran")
            {
                H.DsbControls(txtPemasukan);
                txtPemasukan.Text = "0";
                H.EnbControls(txtPengeluaran);
            }
            else
            {
                H.DsbControls(txtPemasukan, txtPengeluaran);
                txtPengeluaran.Text = "0";
                txtPemasukan.Text = "0";
            }
        }
    }
}
