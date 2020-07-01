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
    public partial class FrmBarang : Form
    {
        MySqlDataReader dr;
        public FrmBarang()
        {
            InitializeComponent();
        }

        private void FrmBrg_Load(object sender, EventArgs e)
        {
            isiGrid();
        }

        void isiGrid()
        {
            dr = H.OpenDr("SELECT * FROM tb_barang WHERE kode LIKE '%" + txtCari.Text + "%' OR nama LIKE '%" + txtCari.Text + "%' OR kategori LIKE '%" + txtCari.Text + "%' ORDER BY kode");
            dgv.Rows.Clear();
            int no = 1;
            while (dr.Read())
            {
                dgv.Rows.Add(new Object[] {
                    no,
                    dr["kode"],
                    dr["nama"],
                    dr["kategori"],
                    dr["satuan"],
                    H.toStrC(dr["hargabeli"]),
                    H.toStrC(dr["hargajual"]),
                    dr["jumlah"],
                    H.toStrC(dr["laba"])
                });
                no++;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmBarangTambah frm = new FrmBarangTambah();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                H.msgError("Belum ada data yang dipilih");
                return;
            }

            H.IdEdit = H.GetSelAt(dgv, 1);

            FrmBarangTambah frm = new FrmBarangTambah();
            frm.editState = true;
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                String d = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[1].Value.ToString();
                if (H.msgAsk("Hapus data?") == DialogResult.Yes)
                {
                    if (H.execute("DELETE FROM tb_barang WHERE kode='" + d + "'"))
                    {
                        H.msgInfo("Data dihapus");
                        isiGrid();
                    }
                }
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void FrmBrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (H.isRefresh(e)) btnRefresh_Click(null, null);
            if (H.isAdd(e)) btnTambah_Click(null, null);
            if (H.isEdit(e)) btnUbah_Click(null, null);
            if (H.isDelete(e)) btnHapus_Click(null, null);
            if (H.isClose(e)) btnKeluar_Click(null, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void txtCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (H.isEnter(e)) btnRefresh_Click(null, null);
        }
    }
}
