using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;

namespace JualTunai
{
    class H
    {
        public static MySqlConnection conn = null;
        public static MySqlCommand cmd;
        private static MySqlDataReader dr = null;

        public static string IdEdit, IdCari, NmCari, strOperator="";

        static void Connect()
        {
            if (conn != null) return;

            string strConn = "server=localhost; user=root; database=db_jualtunai; password=";

            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
            }
            catch (Exception ex)
            {
                msgError(ex.Message);
                Environment.Exit(0);
            }
        }

        public static MySqlDataReader OpenDr(object sql)
        {
            Connect();
            CloseDr();
            try
            {
                cmd = new MySqlCommand(sql.ToString(), conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                msgError(ex.Message + "\n" + sql.ToString());
            }
            cmd.Dispose();
            return dr;
        }

        public static MySqlDataReader openTable(string table = "tb_barang", string where = "")
        {
            string sql = "SELECT * FROM " + table + " WHERE 1=1 ";
            if (where != "")
            {
                sql = sql + " AND " + where;
            }
            return OpenDr(sql);
        }
                
        public static void DsbControls(params Control[] o)
        {
            for (int a = 0; a < o.Length; a++)
            {
                o[a].Enabled = false;
                o[a].BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            }
        }

        public static void EnbControls(params Control[] o)
        {
            for (int a = 0; a < o.Length; a++)
            {
                o[a].Enabled = true;
                o[a].BackColor = System.Drawing.Color.White;
            }
        }

        public static string getOption(string option_name)
        {
            string a = "";
            dr = openTable("tb_option", "option_name='" + option_name + "'");
            if (dr.Read())
            {
                a = dr["option_value"].ToString();
            }
            return a;
        }
        public static void updateOption(string option_name, string option_value)
        {
            execute("UPDATE tb_option SET option_value='" + option_value + "' WHERE option_name='" + option_name + "'");            
        }
        public static void CloseDr()
        {
            try
            {
                dr.Close();
            }
            catch (Exception)
            {

            }
        }
        public static MySqlConnection getConnection()
        {
            Connect();
            return conn;
        }

        public static double toD(object o)
        {
            double hasil;
            try
            {
                hasil = Double.Parse(o.ToString());
            }
            catch (Exception )
            {
                return 0;
            }
            return hasil;
        }

        public static bool execute(string sql)
        {
            Connect();
            CloseDr();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, getConnection());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                msgError(ex.Message);
            }
            return false;
        }

        public static bool executeCMD(MySqlCommand cmd)
        {
            Connect();
            CloseDr();
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ex)
            {
                msgError( ex.Message + "\n" +  cmd.CommandText );
            }
            return false;
        }

        public static object getNextInc(string tb)
        {
            object h = null;
            dr = OpenDr("SELECT information_schema.TABLES.AUTO_INCREMENT FROM information_schema.TABLES WHERE information_schema.tables.TABLE_NAME='" + tb + "'");
            if (dr.Read())
            {
                h = dr[0];
            }
            dr.Close();
            return h;

        }

        public static void msgError(string msg)
        {
            MessageBox.Show(null, msg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void msgInfo(object msg)
        {
            MessageBox.Show(null, msg.ToString(), "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult msgAsk(string msg)
        {
            return MessageBox.Show(null, msg, "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        
        public static void openForm( Form frm, Form parent = null, FormWindowState state = FormWindowState.Maximized)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == frm.GetType())
                {
                    openForm.Select();
                    return;
                }
            }

            frm.MdiParent = parent;
            frm.WindowState = state;
            frm.Show();
        }

        public static string getShift(string shift, int tgl)
        {
            char[] a = shift.ToArray();
            if (tgl < a.Length)
            {
                return a[tgl - 1].ToString();
            }
            else
            {
                return "0";
            }
        }

        public static string replaceShift(string shift, int tgl, int value)
        {
            char[] a = shift.ToArray();
            if (tgl < a.Length)
            {
                a[tgl - 1] = char.Parse(value.ToString());
            }

            string c = "";
            for (int b = 0; b < a.Length; b++)
            {
                string d = a[b].ToString();
                c = c + d;
            }

            return c;
        }

        public static string getCDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        public static string getCDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string getHari()
        {
            String hari = DateTime.Now.DayOfWeek.ToString();
            if (hari == "Saturday" || hari == "Sabtu")
            {
                return "SABTU";
            }
            else if (hari == "Sunday" || hari == "Minggu")
            {
                return "MINGGU";
            }
            else
            {
                return "NORMAL";
            }
        }

        public static string validNull(Object obj)
        {
            if (obj == null || obj.ToString() == "")
            {
                return "-";
            }
            else
            {
                return obj.ToString();
            }
        }

        public static string timeSqltoStr(object tm)
        {

            string a;
            try
            {
                a = tm.ToString();
                a = DateTime.Parse(a).ToString("H:mm");

            }
            catch (Exception)
            {
                a = null;
            }
            return a;
        }
        public static string dateSqltoStr(object tgl, Boolean hari = false)
        {

            string a;
            try
            {
                a = tgl.ToString();
                if (!hari)
                {
                    a = DateTime.Parse(a).ToString("dd MMM yyyy");
                }
                else
                {
                    a = DateTime.Parse(a).ToString("dddd, dd MMM yyyy");
                }

            }
            catch (Exception)
            {
                a = null;
            }
            return a;
        }

        public static DateTime dateSqltoDate(object tgl)
        {

            string a;
            DateTime b;
            try
            {
                a = tgl.ToString();
                b = DateTime.Parse(a);
            }
            catch (Exception)
            {
                b = DateTime.Now;
            }
            return b;
        }

        public static string kodeOto(string table, string field, string start, int length){ 
            string hasil="";
            int panjang;
            double a = 0;

            panjang = start.Length + length;
            dr = H.OpenDr("SELECT " + field + " FROM " + table + " WHERE " + field + " LIKE '%" + start + "%' AND LENGTH(" + field + ")=" + panjang + " ORDER BY " + field + " DESC");
            
            if(dr.Read()){
                a = toD(Right(dr[0].ToString(), length));
                a++;
                hasil = a.ToString();
                hasil = start + new string('0', length - hasil.Length) + hasil;                
            }else{
                hasil = start + new string('0', length - 1) + "1";
            }
            return hasil;
        }

        public static string  Right(string str, int length){
            return str.Substring(str.Length - length, length);
        }

        public static string getMonthIndo(int a)
        {
            switch (a)
            {
                case 1:
                    return "Januari";
                case 2:
                    return "Februari";
                case 3:
                    return "Maret";
                case 4:
                    return "April";
                case 5:
                    return "Mei";
                case 6:
                    return "Juni";
                case 7:
                    return "Juli";
                case 8:
                    return "Agustus";
                case 9:
                    return "September";
                case 10:
                    return "Oktober";
                case 11:
                    return "Nopember";
                case 12:
                    return "Desember";
                default:
                    return "";
            }
        }

        public static bool isKdExist(string kode = "", string table = "tb_barang", string field = "kode", string exclude="")
        {
            dr = OpenDr("SELECT * FROM " + table + " WHERE " + field + " = '" + kode + "' AND " + field + "<>'" + exclude + "'");
            if (dr.Read()) return true;
            return false;
        }

        public static bool isUserCan(string str)
        {
            dr = OpenDr("SELECT * FROm tb_user WHERE user='" + strOperator + "' AND " +  str + "=1");
            if (dr.Read())
            {
                return true;
            }
            return false;
        }
        public static bool isSearch(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F1;
        }
        public static bool isAdd(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F2;
        }
        public static bool isSave(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F3;
        }
        public static bool isPay(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F4;
        }
        public static bool isRefresh(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F5;
        }
        public static bool isPrint(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F6;
        }
        public static bool isEdit(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F7;
        }
        public static bool isDelete(KeyEventArgs e)
        {
            return e.KeyCode == Keys.F8;
        }
        public static bool isClose(KeyEventArgs e)
        {
            return e.KeyCode == Keys.Escape;
        }
        public static bool isEnter(KeyPressEventArgs e)
        {
            return e.KeyChar == (char)Keys.Enter;
        }

        public static string toStrC(Object o)
        {            
            return Double.Parse(o.ToString()).ToString("c2", CultureInfo.CreateSpecificCulture("id-ID"));         
        }

        public static string toStrDate(Object o)
        {
            return DateTime.Parse(o.ToString()).ToString("dd-MMM-yyyy");
        }

        public static string GetSelAt(DataGridView dgv, int col = 0)
        {
            return dgv.Rows[dgv.CurrentCell.RowIndex].Cells[col].Value.ToString();
        }

        public static void FillCmb(MySqlDataReader dr, ComboBox cmb, string selected = "", bool allowEmpty = false)
        {
            int baris = 0;
            while (dr.Read())
            {
                cmb.Items.Add(dr[0].ToString());
                baris++;
            }
            if (!allowEmpty && cmb.Items.Count>0)
            {
                if (selected != "")
                {
                    cmb.Text = selected;
                }
                else
                {
                    cmb.SelectedIndex = 0;
                }
            }
        }

        public static void FillCmbTerm(ComboBox cmb, string termName = "kategori", string selected = "", bool allowEmpty = false)
        {
            dr = OpenDr("SELECT term_name FROM tb_terms WHERE term_taxonomy='" + termName + "' ORDER BY term_name");
            FillCmb(dr, cmb, selected, allowEmpty);
        }
    }
}
