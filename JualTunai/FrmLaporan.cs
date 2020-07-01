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
    public partial class FrmLaporan : Form
    {
        MySqlDataReader dr;
        public FrmLaporan()
        {
            InitializeComponent();
        }

        private void FrmLaporan_Load(object sender, EventArgs e)
        {
            txtAwal.Value = DateTime.Now;
            txtAkhir.Value = DateTime.Now;

            H.DsbControls(txtGrandtotal, txtLaba);

            txtOperator.Items.Clear();
            txtOperator.Items.Add("SEMUA");
            dr = H.OpenDr("SELECT user FROM tb_user");
            H.FillCmb(dr, txtOperator);
            isiGrid();
        }

        void isiGrid()
        {
            double grandtotal = 0, laba = 0;

            string awal = txtAwal.Value.ToString("yyyy-MM-dd");
            string akhir = txtAkhir.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM tb_jual WHERE tanggal>='" + awal + "' AND tanggal <='" + akhir + "'";
            if (txtOperator.Text != "SEMUA")
            {
                sql += " AND operator='" + txtOperator.Text + "'";
            }
            sql += " ORDER BY Faktur";
            
            dr = H.OpenDr(sql);
            dgv.Rows.Clear();
            int no = 1;
            while (dr.Read())
            {
                dgv.Rows.Add(new object[] {
                    no,
                    dr["Faktur"].ToString(),
                    H.toStrDate(dr["tanggal"]),
                    H.toStrC(dr["grandtotal"]),
                    H.toStrC(dr["laba"]),
                    dr["operator"]
                });
                grandtotal += H.toD(dr["grandtotal"]);
                laba += H.toD(dr["laba"]);
                no++;
            }
            txtGrandtotal.Text = H.toStrC(grandtotal);
            txtLaba.Text = H.toStrC(laba);
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
                    stroperator + "' AS foperator, '" +
                    periode + "' AS periode, faktur, tanggal, grandtotal, laba, operator, '" +
                    cetak + "' AS cetak " +
                    "FROM tb_jual WHERE tanggal>='" + txtAwal.Value.ToString("yyyy-MM-dd") + "' AND tanggal<='" + txtAkhir.Value.ToString("yyyy-MM-dd") + "'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, H.getConnection());
                adapter.Fill(ds);

                ReportDocument rd = new ReportDocument();
                rd.Load("../../rptJual.rpt");
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
    }
}
