using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JualTunai
{
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
        }

        private void mnBarang_Click(object sender, EventArgs e)
        {
            H.openForm(new FrmBarang(), this);    
        }

        private void FrmUtm_Load(object sender, EventArgs e)
        {
            sb1.Text = "Tanggal: " + DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
            sb2.Text = "Operator: " + H.strOperator;
             
            mnBarang.Enabled = tbBarang.Enabled = H.isUserCan("frmbrg");
            mnKategori.Enabled = tbKategori.Enabled = H.isUserCan("frmkat");
            mnSatuan.Enabled = tbSatuan.Enabled = H.isUserCan("frmsat");

            mnJual.Enabled = tbJual.Enabled = H.isUserCan("frmjual");
            mnLap.Enabled = tbLap.Enabled = H.isUserCan("frmlap");
            mnKas.Enabled = tbKas.Enabled = H.isUserCan("frmkas");

            mnPassword.Enabled = tbPassword.Enabled = H.isUserCan("frmpass");
            mnSetting.Enabled = tbSetting.Enabled = H.isUserCan("frmset");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sb1.Text = "Tanggal: " + DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
        }
        
        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbBarang_Click(object sender, EventArgs e)
        {
            mnBarang_Click(sender, e);
        }

        private void tbKategori_Click(object sender, EventArgs e)
        {
            mnKategori_Click(sender, e);
        }

        private void mnKategori_Click(object sender, EventArgs e)
        {
            FrmTerms f = new FrmTerms();
            f.ShowDialog();
        }

        private void mnSatuan_Click(object sender, EventArgs e)
        {
            FrmTerms f = new FrmTerms();
            f.term_taxonomy = "satuan";
            f.ShowDialog();
        }

        private void tbSatuan_Click(object sender, EventArgs e)
        {
            mnSatuan_Click(sender, e);
        }

        private void mnJual_Click(object sender, EventArgs e)
        {
            H.openForm(new FrmJual(), this);                        
        }

        private void tbJual_Click(object sender, EventArgs e)
        {
            mnJual_Click(sender, e);
        }

        private void mnLap_Click(object sender, EventArgs e)
        {
            H.openForm(new FrmLaporan(), this);  
        }

        private void tbLap_Click(object sender, EventArgs e)
        {
            mnLap_Click(sender, e);
        }

        private void mnSetting_Click(object sender, EventArgs e)
        {
            H.openForm(new FrmPengaturan(), this);  
        }

        private void mnPassword_Click(object sender, EventArgs e)
        {
            FrmPassword f = new FrmPassword();
            f.ShowDialog();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            mnPassword_Click(sender, e);
        }

        private void tbSetting_Click(object sender, EventArgs e)
        {
            mnSetting_Click(sender, e);
        }

        private void tbKalkulator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void tbKas_Click(object sender, EventArgs e)
        {
            mnKas_Click(null, null);
        }

        private void mnKas_Click(object sender, EventArgs e)
        {
            H.openForm(new FrmKas(), this);
        }
    }
}
