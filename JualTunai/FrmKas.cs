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
using CrystalDecisions.CrystalReports.Engine;

namespace JualTunai
{
    public partial class FrmKas : Form
    {
        double masuk = 0, keluar = 0, selisih=0;
        MySqlDataReader dr;
        public FrmKas()
        {
            InitializeComponent();
        }

        private void FrmLaporan_Load(object sender, EventArgs e)
        {
            txtAwal.Value = DateTime.Now;
            txtAkhir.Value = DateTime.Now;

            txtOperator.Items.Clear();
            txtOperator.Items.Add("SEMUA");
            dr = H.OpenDr("SELECT user FROM tb_user");
            H.FillCmb(dr, txtOperator);

            cmbArah.Items.Add("SEMUA");
            cmbArah.Items.Add("Pemasukan");
            cmbArah.Items.Add("Pengeluaran");
            cmbArah.SelectedIndex = 0;

            isiGrid();
        }

        void isiGrid()
        {

            string awal = txtAwal.Value.ToString("yyyy-MM-dd");
            string akhir = txtAkhir.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM tb_kas WHERE tanggal>='" + awal + "' AND tanggal <='" + akhir + "'";

            if (txtOperator.Text != "SEMUA")
                sql += " AND operator='" + txtOperator.Text + "'";
            
            if (cmbArah.Text != "SEMUA")
                sql += " AND jenis='" + cmbArah.Text.ToLower() + "'";
            
            sql += " ORDER BY Tanggal, Faktur";
            
            dr = H.OpenDr(sql);
            dgv.Rows.Clear();
            int no = 1;
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] {
                    no,
                    dr["Faktur"].ToString(),
                    H.toStrDate(dr["tanggal"]),
                    dr["jenis"],
                    dr["kategori"],
                    H.toStrC(dr["pemasukan"]),
                    H.toStrC(dr["pengeluaran"]),
                    dr["keterangan"],
                    dr["operator"]
                });
                masuk += H.toD(dr["pemasukan"]);
                keluar += H.toD(dr["pengeluaran"]);
                no++;
            }
            lblPemasukan.Text = H.toStrC(masuk);
            lblPengeluaran.Text = H.toStrC(keluar);
            selisih = masuk - keluar;
            lblSelisih.Text = H.toStrC(selisih);
        }

        private void txtOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void txtAwal_ValueChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void txtAkhir_ValueChanged(object sender, EventArgs e)
        {
            isiGrid();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count == 0)
            {
                H.msgError("Data tidak ada!");
                return;
            }
            string sql = "";
            try
            {
                string header1 = H.getOption("header1");
                string header2 = H.getOption("header2");
                string header3 = H.getOption("header3");

                string periode = "Periode: " + txtAwal.Value.ToString("dd-MMM-yyyy") + " s/d " + txtAkhir.Value.ToString("dd-MMM-yyyy");
                string stroperator = "Operator: " + txtOperator.Text;
                string cetak = "Cetak: " + DateTime.Now.ToShortDateString() + " Oleh: " + H.strOperator;

                H.CloseDr();
                DataSet ds = new DataSet();

                sql = "SELECT '" +
                    header1 + "' AS header1, '" +
                    header2 + "' AS header2, '" +
                    header3 + "' AS header3, '" +
                    txtOperator.Text + "' AS operator, '" +
                    periode + "' AS periode, faktur, tanggal, pemasukan, pengeluaran, keterangan, operator, '" +
                    cetak + "' AS cetak, " +
                    masuk + " AS masuk, " +
                    keluar + " AS keluar, '" +
                    selisih + "' AS selisih" +
                    " FROM tb_kas WHERE tanggal>='" + txtAwal.Value.ToString("yyyy-MM-dd") + "' AND tanggal<='" + txtAkhir.Value.ToString("yyyy-MM-dd") + "'";
                
                if (txtOperator.Text != "SEMUA")
                    sql += " AND operator='" + txtOperator.Text + "'";

                if (cmbArah.Text != "SEMUA")
                    sql += " AND jenis='" + cmbArah.Text.ToLower() + "'";

                sql += " ORDER BY Tanggal, Faktur";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, H.getConnection());
                adapter.Fill(ds);

                ReportDocument rd = new ReportDocument();
                rd.Load("../../rptKas.rpt");
                rd.Database.Tables[0].SetDataSource(ds.Tables[0]);

                //pakai perintah ini untuk langsung print dan hapus 5 baris perintah di bawahnya
                //rd.PrintToPrinter;

                FrmCetak l = new FrmCetak();
                l.MdiParent = this.MdiParent;
                l.WindowState = FormWindowState.Maximized;
                l.crystalReportViewer1.ReportSource = rd;
                l.Show();
            }
            catch (Exception ex)
            {
                H.msgError(ex.Message + sql);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLap_KeyDown(object sender, KeyEventArgs e)
        {
            if (H.isPrint(e)) btnCetak_Click(null, null);
            if (H.isClose(e)) btnKeluar_Click(null, null);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmKasTambah frm = new FrmKasTambah();
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

            FrmKasTambah frm = new FrmKasTambah();
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
                String d = H.GetSelAt(dgv, 1);
                if (H.msgAsk("Hapus data?") == DialogResult.Yes)
                {
                    if (H.execute("DELETE FROM tb_kas WHERE faktur='" + d + "'"))
                    {
                        H.msgInfo("Data dihapus");
                        isiGrid();
                    }
                }
            }
        }

        private void cmbArah_SelectedIndexChanged(object sender, EventArgs e)
        {
            isiGrid();
        }
    }
}
