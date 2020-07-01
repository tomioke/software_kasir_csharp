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
    public partial class FrmPengaturan : Form
    {
        MySqlDataReader dr;
        public FrmPengaturan()
        {
            InitializeComponent();
        }

        private void FrmSet_Load(object sender, EventArgs e)
        {
            isiGrid();
            isiOption();
        }

        private void isiOption()
        {
            txth1.Text = H.getOption("header1");
            txth2.Text = H.getOption("header2");
            txth3.Text = H.getOption("header3");

            txtf1.Text = H.getOption("footer1");
            txtf2.Text = H.getOption("footer2");
            txtf3.Text = H.getOption("footer3");
        }

        void isiGrid()
        {
            dr = H.OpenDr("SELECT * FROM tb_user");
            dgv.Rows.Clear();
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] { 
                    dr[0],
                    dr[1],
                    dr[2],
                    dr[3],
                    dr[4],
                    dr[5],
                    dr[6],
                    dr[7],
                    dr[8],
                    dr[9]
                });
            }
        }
        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmTambahUser f = new FrmTambahUser();
            if (f.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                String d = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (H.isKdExist(d, "tb_jual", "operator"))
                {
                    H.msgError("Data tidak bisa terhapus");
                }
                else if (H.msgAsk("Hapus data?") == DialogResult.Yes)
                {
                    if (H.execute("DELETE FROM tb_user WHERE user='" + d + "'"))
                    {
                        H.msgInfo("Data dihapus");
                        isiGrid();
                    }
                }
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                H.msgError("Belum ada data yang dipilih");
                return;
            }

            H.IdEdit = H.GetSelAt(dgv);

            FrmTambahUser frm = new FrmTambahUser();
            frm.editState = true;
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                isiGrid();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            H.updateOption("header1", txth1.Text);
            H.updateOption("header2", txth2.Text);
            H.updateOption("header3", txth3.Text);
            H.updateOption("footer1", txtf1.Text);
            H.updateOption("footer2", txtf2.Text);
            H.updateOption("footer3", txtf3.Text);
            H.msgInfo("Data tersimpan");
            isiOption();
        }

        private void FrmSet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKeluar_Click(null, null);
            }
        }
    }
}
