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
    public partial class FrmTerms : Form
    {
        public string term_taxonomy = "kategori";
        MySqlDataReader dr;
        public FrmTerms()
        {
            InitializeComponent();
        }

        private void frmKat_Load(object sender, EventArgs e)
        {
            this.Text = term_taxonomy.ToUpper();
            dgv.Columns[0].HeaderText = term_taxonomy.ToUpper();
            isiGrid();
        }

        void isiGrid()
        {
            dr = H.OpenDr("SELECT term_name FROM tb_terms WHERE term_taxonomy='" + term_taxonomy + "' ORDER BY term_name");
            dgv.Rows.Clear();
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] { dr[0].ToString() });
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                H.IdCari = H.GetSelAt(dgv);
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
            dr = H.OpenDr("SELECT * FROM tb_terms WHERE term_taxonomy='" + term_taxonomy + "' AND term_name='" + txtNama.Text + "'");
            if (dr.Read())
            {
                H.msgError("Nama sudah ada");
                txtNama.Focus();
                return;
            }

            H.execute("INSERT INTO tb_terms(term_name, term_taxonomy) VALUES ('" + txtNama.Text + "', '" + term_taxonomy + "')");
            txtNama.Text = "";
            isiGrid();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (H.msgAsk("Hapus data?") == DialogResult.Yes)
            {
                string d = H.GetSelAt(dgv);
                H.execute("DELETE FROM tb_terms WHERE term_name='" + d + "' AND term_taxonomy='" + term_taxonomy + "'");
                isiGrid();
            }
        }

        private void FrmTerms_KeyDown(object sender, KeyEventArgs e)
        {
            if (H.isClose(e)) this.Close();
        }
    }
}
