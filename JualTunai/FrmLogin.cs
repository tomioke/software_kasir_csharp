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
    public partial class FrmLogin : Form
    {
        MySqlDataReader dr;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dr = H.openTable("tb_user", "user='" + txtNama.Text + "' AND pass='" + txtPass.Text + "' AND status=1");
            if (dr.Read())
            {
                H.strOperator = dr["user"].ToString();
                this.Hide();
                FrmUtama frm = new FrmUtama();
                frm.ShowDialog();
                this.Dispose();
            }
            else
            {
                H.msgError("Salah kombinasi username dan password!");
            }
        }

        private void FrmLgn_Load(object sender, EventArgs e)
        {
            dr = H.OpenDr("SELECT * FROM tb_user");
            while (dr.Read())
            {
                txtNama.Items.Add(dr["user"].ToString());
            }
            if (txtNama.Items.Count > 0) txtNama.SelectedIndex = 0;
           
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) btnLogin_Click(null, null);
            if (e.KeyChar == (char)Keys.Back && txtPass.TextLength == 0) txtNama.Focus();
        }

        private void FrmLgn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnKeluar_Click(null, null);
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) txtPass.Focus();            
        }        
    }
}
