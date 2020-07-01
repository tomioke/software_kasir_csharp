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
    public partial class FrmPassword : Form
    {
        MySqlDataReader dr;
        string user, pass;
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPass_Load(object sender, EventArgs e)
        {
            dr = H.openTable("tb_user", "user='" + H.strOperator + "'");
            
            if (dr.Read())
            {
                user = dr["user"].ToString();
                pass = dr["pass"].ToString();
                txtNama.Text = user;
            }
            txtPass1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text != pass)
            {
                H.msgError("Password lama salah");
                txtPass1.Focus();
            }
            else if (txtPass2.Text != txtPass3.Text)
            {
                H.msgError("Password dan konfirmasi password tidak sama");
                txtPass2.Focus();
            }
            else
            {
                H.execute("UPDATE tb_user SET pass='" + txtPass2.Text + "' WHERE user='" + user + "'");
                H.msgInfo("Password berhasil diubah!");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                button2_Click(null, null);
            }
        }
    }
}

