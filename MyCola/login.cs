using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyCola
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlConnection conn = db.connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = db.connection();
            cmd.CommandText = "SELECT * FROM mc_user WHERE name='"+txtUser.Text+"' AND password='"+txtPass.Text+"'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {                
                main_form mf = new main_form();
                mf.Show();
                this.Hide();
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
