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
    public partial class FrmJual : Form
    {
        double hargabeli = 0, laba = 0;
        MySqlDataReader dr;
        public FrmJual()
        {
            InitializeComponent();
        }

        private void frmJual_Load(object sender, EventArgs e)
        {
            H.DsbControls(txtNama, txtSatuan, txtHargaJual, txtTotal, txtKembali);         
            newTrans();          
        }

        string fakturBaru()
        {
            return H.kodeOto("tb_jual", "Faktur", "TR-" + DateTime.Now.ToString("yyyyMMdd") + "-", 4);
        }

        void newTrans()
        {
            txtKet.Text = fakturBaru();

            txtKode.Text = "";
            emptyBrg();

            dgv.Rows.Clear();

            txtTunai.Text = "";
            txtKembali.Text = "";
            txtKode.Focus();
        }

        private void txtKode_TextChanged(object sender, EventArgs e)
        {
            dr = H.openTable("tb_barang", "kode='" + txtKode.Text + "'");
            if (dr.Read())
            {
                txtKode.Text = dr["kode"].ToString();
                txtJumlah.Text = "1";
                txtNama.Text = dr["nama"].ToString();
                txtHargaJual.Text = dr["hargajual"].ToString();
                txtSatuan.Text = dr["satuan"].ToString();
                hargabeli = H.toD(dr["hargabeli"].ToString());
                hitungSubtotal();
                txtJumlah.Focus();
            }
            else
            {
                txtKet.Text = hitungTotal().ToString();
                emptyBrg();
            }

        }

        double hitungTotal()
        {
            double hasil = 0;
            for (int a = 0; a < dgv.Rows.Count; a++ )
            {
                hasil = hasil + H.toD(dgv.Rows[a].Cells[5].Value);
            }
            return hasil;
        }
        double hitungLaba()
        {
            double hasil = 0;
            for (int a = 0; a < dgv.Rows.Count; a++)
            {
                hasil = hasil + H.toD(dgv.Rows[a].Cells[6].Value);
            }
            return hasil;
        }

        void hitungSubtotal()
        {            
            double a = 0;
            a = H.toD(txtHargaJual.Text) * H.toD(txtJumlah.Text);
            txtTotal.Text = a.ToString();
            txtKet.Text = a.ToString();
        }
        
        void emptyBrg()
        {
            txtJumlah.Text = "";
            txtNama.Text = "";
            txtHargaJual.Text = "";
            txtSatuan.Text = "";
            txtTotal.Text = "";
            laba = 0;
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            hitungSubtotal();
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (H.toD(txtJumlah.Text) > 0)
                {
                    dgv.Rows.Add(new object[] {
                        txtKode.Text,
                        txtNama.Text,
                        txtJumlah.Text,
                        txtSatuan.Text,
                        txtHargaJual.Text,
                        txtTotal.Text,
                        laba = (H.toD(txtHargaJual.Text) - hargabeli) * H.toD(txtJumlah.Text) 
                    });
                    txtKet.Text = hitungTotal().ToString();
                    emptyBrg();
                    txtKode.Text = "";
                    txtKode.Focus();
                }
                else
                {
                    H.msgError("Jumlah harus lebih dari 0");
                }
            }
        }

        private void frmJual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                cariData();
            }
            else if (e.KeyCode == Keys.F4)
            {
                txtTunai.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                newTrans();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtTunai_TextChanged(object sender, EventArgs e)
        {
            double k = 0;
            k = H.toD(txtTunai.Text) - hitungTotal();
            txtKembali.Text = k.ToString();
            txtKet.Text = txtTunai.Text;
        }

        private void txtTunai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (H.toD(txtKembali.Text) < 0)
                {
                    H.msgError("Tunai kurang!");
                    txtTunai.Focus();
                    return;
                }

                if (dgv.Rows.Count == 0)
                {
                    H.msgError("Belum ada barang yang dibeli!");
                    txtKode.Focus();
                    return;
                }
                txtKet.Text = txtKembali.Text;
                simpanData();
            }
        }

        void simpanData()
        {
            MySqlCommand cmd;
            string faktur = fakturBaru();

            cmd = new MySqlCommand("INSERT INTO tb_jual (faktur, tanggal, jam, grandtotal, tunai, kembali, operator, laba) VALUES (@faktur, @tanggal, @jam, @grandtotal, @tunai, @kembali, @operator, @laba)", H.getConnection());
            cmd.Parameters.AddWithValue("faktur", faktur);
            cmd.Parameters.AddWithValue("tanggal", DateTime.Now);
            cmd.Parameters.AddWithValue("jam", DateTime.Now);
            cmd.Parameters.AddWithValue("grandtotal", hitungTotal());
            cmd.Parameters.AddWithValue("tunai", txtTunai.Text);
            cmd.Parameters.AddWithValue("kembali", txtKembali.Text);
            cmd.Parameters.AddWithValue("laba", hitungLaba());
            cmd.Parameters.AddWithValue("operator", H.strOperator);

            H.executeCMD(cmd);

            for (int a = 0; a < dgv.Rows.Count; a++)
            {
                cmd = new MySqlCommand("INSERT INTO tb_detailjual (faktur, tanggal, kode, nama, jumlah, satuan, hargajual, total, laba, operator) " +
                    "VALUES (@faktur, @tanggal, @kode, @nama, @jumlah, @satuan, @hargajual, @total, @laba, @operator)", H.getConnection());
                DataGridViewRow r = dgv.Rows[a];
                cmd.Parameters.AddWithValue("faktur", faktur);
                cmd.Parameters.AddWithValue("tanggal", DateTime.Now);
                cmd.Parameters.AddWithValue("kode", r.Cells[0].Value);
                cmd.Parameters.AddWithValue("nama", r.Cells[1].Value);
                cmd.Parameters.AddWithValue("jumlah", r.Cells[2].Value);
                cmd.Parameters.AddWithValue("satuan", r.Cells[3].Value);
                cmd.Parameters.AddWithValue("hargajual", r.Cells[4].Value);
                cmd.Parameters.AddWithValue("total", r.Cells[5].Value);
                cmd.Parameters.AddWithValue("laba", r.Cells[6].Value);
                cmd.Parameters.AddWithValue("operator", H.strOperator);
                H.executeCMD(cmd);

                H.execute("UPDATE tb_barang SET jumlah=jumlah-" + H.toD(r.Cells[2].Value) + " WHERE kode='" + r.Cells[0].Value + "'");
            }

            cmd = new MySqlCommand("INSERT INTO tb_kas (faktur, tanggal, jenis, kategori, pemasukan, pengeluaran, keterangan, operator) VALUES (@faktur, @tanggal, @jenis, @kategori, @pemasukan, @pengeluaran, @keterangan, @operator)", H.getConnection());
            cmd.Parameters.AddWithValue("faktur", faktur);
            cmd.Parameters.AddWithValue("tanggal", DateTime.Now);
            cmd.Parameters.AddWithValue("jenis", "Pemasukan");
            cmd.Parameters.AddWithValue("kategori", "Penjualan");
            cmd.Parameters.AddWithValue("pemasukan", hitungTotal());
            cmd.Parameters.AddWithValue("pengeluaran",0);
            cmd.Parameters.AddWithValue("keterangan", "Penjualan: " + faktur);
            cmd.Parameters.AddWithValue("operator", H.strOperator);
            H.executeCMD(cmd);

            if (H.msgAsk("Transaksi tersimpan! \nCetak Nota?") == DialogResult.Yes)
            {
                string sql = "";
                try
                {
                    string header = H.getOption("header1") + "\n" + H.getOption("header2") + "\n" + H.getOption("header3");

                    string footer = H.getOption("footer1") + "\n" + H.getOption("footer2") + "\n" + H.getOption("footer3");

                    H.CloseDr();
                    DataSet ds = new DataSet();

                    sql = "select '" + header + "' as header, '" + footer + "' as footer, a.faktur, a.*, b.* from tb_jual a INNER JOIN tb_detailjual b on a.faktur = b.faktur WHERE a.faktur='" + faktur + "'";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, H.getConnection());
                    adapter.Fill(ds);

                    ReportDocument rd = new ReportDocument();
                    rd.Load("../../rptNota.rpt");
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
            newTrans();
        }

        void enableText(bool enb)
        {

        }

        private void frmJual_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (H.msgAsk("Batalkan transaksi?") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void txtKode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                cariData();
            }
        }
        void cariData()
        {
            FrmCariBarang f = new FrmCariBarang();
            if (f.ShowDialog() == DialogResult.Yes)
            {
                txtKode.Text = H.IdCari;
                txtKode_TextChanged(null, null);
            }
        }
    }
}
