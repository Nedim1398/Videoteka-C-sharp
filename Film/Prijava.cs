using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
            tBoxUsername.Focus();
        }


        private void Prijava_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            String Username = tBoxUsername.Text;
            String Password = tBoxPassword.Text;
            MyGlobals.Logged = Username;
            
            var conn = Program.GetConnection();
            try
            {
                var sp = new SqlCommand();
                sp.CommandText = "SELECT TOP 1 * FROM tblRadnici WHERE Username = '" + Username + "' AND Password = '" + Password + "'";
                conn.Open();
                sp.Connection = conn;
                var rdr = sp.ExecuteReader();
                if (rdr.HasRows)
                {
                    this.Visible = false;
                    MainMenu meni = new MainMenu();
                    meni.Show();
                    
                }
                
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void tBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                tBoxPassword.Focus();

        }

        private void tBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnPrijava.Focus();
        }
    }
}
