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
    public partial class FrmCariBarang : Form
    {
        MySqlDataReader dr;
        public FrmCariBarang()
        {
            InitializeComponent();
        }

        private void frmCariBrg_Load(object sender, EventArgs e)
        {
            isiGrid();
            txtCari.Focus();
        }

        void isiGrid()
        {
            dr = H.OpenDr("SELECT kode, nama, kategori, hargajual, jumlah FROM tb_barang WHERE kode LIKE '%" + txtCari.Text + "%' OR nama LIKE '%" + txtCari.Text + "%' OR kategori LIKE '%" + txtCari.Text + "%' ORDER BY kode");
            dgv.Rows.Clear();
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] { dr[0], dr[1], dr[2], dr[3], dr[4] });
            }
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                H.IdCari = H.GetSelAt(dgv);
            }
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOK_Click(null, null);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                dgv.Focus();
            }
        }

        private void txtCari_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) dgv.Focus();
        }

        private void frmCariBrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKeluar_Click(null, null);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }
    }
}
