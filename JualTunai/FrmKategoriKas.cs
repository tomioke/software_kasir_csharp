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
    public partial class FrmKategoriKas : Form
    {
        public string term_taxonomy = "kategori";
        MySqlDataReader dr;
        public FrmKategoriKas()
        {
            InitializeComponent();
        }

        private void frmKat_Load(object sender, EventArgs e)
        {
            H.NmCari = ""; H.IdCari = "";
            isiGrid();
        }

        void isiGrid()
        {
            dr = H.OpenDr("SELECT kategori FROM tb_kategorikas WHERE jenis='pemasukan' ORDER BY kategori");
            dgv.Rows.Clear();
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] { dr[0].ToString() });
            }

            dr = H.OpenDr("SELECT kategori FROM tb_kategorikas WHERE jenis='pengeluaran' ORDER BY kategori");
            dgv2.Rows.Clear();
            while (dr.Read())
            {
                dgv2.Rows.Add(new object[] { dr[0].ToString() });
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                H.IdCari = "Pemasukan";
                H.NmCari = H.GetSelAt(dgv);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                H.msgError("Nama tidak boleh kosong");
                txtNama.Focus();
                return;
            }
            dr = H.OpenDr("SELECT * FROM tb_kategorikas WHERE jenis='pemasukan' AND kategori='" + txtNama.Text + "'");
            if (dr.Read())
            {
                H.msgError("Nama sudah ada");
                txtNama.Focus();
                return;
            }

            H.execute("INSERT INTO tb_kategorikas(jenis, kategori) VALUES ('pemasukan', '" + txtNama.Text + "')");
            txtNama.Text = "";
            isiGrid();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (H.msgAsk("Hapus data?") == DialogResult.Yes)
            {
                string d = H.GetSelAt(dgv);
                H.execute("DELETE FROM tb_kategorikas WHERE kategori='" + d  + "' AND jenis='pemasukan'");
                isiGrid();
            }
        }

        private void FrmTerms_KeyDown(object sender, KeyEventArgs e)
        {
            if (H.isClose(e)) this.Close();
        }

        private void dgv2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                H.IdCari = "Pengeluaran";
                H.NmCari = H.GetSelAt(dgv2);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            if (txtNama2.Text == "")
            {
                H.msgError("Nama tidak boleh kosong");
                txtNama2.Focus();
                return;
            }
            dr = H.OpenDr("SELECT * FROM tb_kategorikas WHERE jenis='pengeluaran' AND kategori='" + txtNama2.Text + "'");
            if (dr.Read())
            {
                H.msgError("Nama sudah ada");
                txtNama2.Focus();
                return;
            }

            H.execute("INSERT INTO tb_kategorikas(jenis, kategori) VALUES ('pengeluaran', '" + txtNama2.Text + "')");
            txtNama2.Text = "";
            isiGrid();
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            if (H.msgAsk("Hapus data?") == DialogResult.Yes)
            {
                string d = H.GetSelAt(dgv2);
                H.execute("DELETE FROM tb_kategorikas WHERE kategori='" + d + "' AND jenis='pengeluaran'");
                isiGrid();
            }
        }
    }
}
