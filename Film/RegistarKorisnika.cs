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
    public partial class RegistarKorisnika : Form
    {

        public RegistarKorisnika()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {



            var conn = Program.GetConnection();
            try
            {
                tBoxID.Text= "";
                String Ime = tBoxIme.Text;
                String Prezime = tBoxPrezime.Text;
                String JMBG = tBoxJMBG.Text;
                String Adresa = tBoxAdresa.Text;
                String Telefon = tBoxTelefon.Text;
                String eMail = tBoxEmail.Text;
                int Aktivan = 0;
                if (cBoxAktivan.Checked)
                { Aktivan = 1; }
                var sp = new SqlCommand();
                if (string.IsNullOrEmpty(Ime) || string.IsNullOrEmpty(Prezime) || string.IsNullOrEmpty(JMBG) || string.IsNullOrEmpty(Adresa) || string.IsNullOrEmpty(Telefon))
                    MessageBox.Show("Unesite podatke u sva obavezna polja!");
                else
                {
                    sp.CommandText = "SELECT TOP 1 * FROM tblKorisnici WHERE Ime = '" + Ime + "' AND Prezime = '" + Prezime + "' AND JMBG = '" + JMBG + "' AND Adresa = '" + Adresa + "' AND Telefon = '" + Telefon + "' AND eMail = '" + eMail + "' AND Aktivan = '" + Aktivan + "'";
                    conn.Open();
                    sp.Connection = conn;
                    var rdr = sp.ExecuteReader();
                    if (!rdr.HasRows)
                    {
                        rdr.Close();
                        sp.CommandText = "INSERT INTO tblKorisnici (Ime, Prezime, JMBG, Adresa, Telefon, eMail, Dug, Aktivan) VALUES('" + Ime + "','" + Prezime + "','" + JMBG + "','" + Adresa + "','" + Telefon + "','" + eMail + "','0','" + Aktivan + "')";
                        sp.ExecuteNonQuery();
                        //sp.BeginExecuteNonQuery();
                    }
                }
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxIme.Text) || string.IsNullOrEmpty(tBoxPrezime.Text) || string.IsNullOrEmpty(tBoxJMBG.Text) || string.IsNullOrEmpty(tBoxAdresa.Text) || string.IsNullOrEmpty(tBoxTelefon.Text))
            {
                MessageBox.Show("Unesite podatke u sva obavezna polja!");
                return;
            }
            if (string.IsNullOrEmpty(tBoxID.Text))
            {
                MessageBox.Show("Učitajte postojećeg user-a.");
                return;
            }
            var conn = Program.GetConnection();
            try
            {
                
                int ID = int.Parse(tBoxID.Text);
                String Ime = tBoxIme.Text;
                String Prezime = tBoxPrezime.Text;
                String JMBG = tBoxJMBG.Text;
                String Adresa = tBoxAdresa.Text;
                String Telefon = tBoxTelefon.Text;
                String eMail = tBoxEmail.Text;
                double Dug = double.Parse(tBoxDug.Text);
                int Aktivan = 0;
                if (cBoxAktivan.Checked)
                { Aktivan = 1; }
                var sp = new SqlCommand();
                conn.Open();
                sp.Connection = conn;
                    sp.CommandText = "UPDATE tblKorisnici SET Ime = '" + Ime + "', Prezime = '" + Prezime + "', JMBG = '" + JMBG + "', Adresa = '" + Adresa + "', Telefon = '" + Telefon + "' , eMail = '" + eMail + "', Dug = '" + Dug + "', Aktivan = '" + Aktivan + "' WHERE ID = '" + ID + "'";
                    sp.ExecuteNonQuery();
                    //sp.BeginExecuteNonQuery();

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }


        private void tBoxDug_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            ListaKorisnika users = new ListaKorisnika();
            users.Show(this);
            users.FormClosing += new FormClosingEventHandler(ListaKorisnika_FormClosing);
            //users.DoubleClick()
        }

        private void tBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxJMBG_TextChanged(object sender, EventArgs e)
        {

        }


        private void ListaKorisnika_FormClosing(object sender, EventArgs e)
        {
            tBoxID.Text = ((ListaKorisnika)sender).tID;
            tBoxIme.Text = ((ListaKorisnika)sender).tIme;
            tBoxPrezime.Text = ((ListaKorisnika)sender).tPrezime;
            tBoxJMBG.Text = ((ListaKorisnika)sender).tJMBG;
            tBoxAdresa.Text = ((ListaKorisnika)sender).tAdresa;
            tBoxTelefon.Text = ((ListaKorisnika)sender).tTelefon;
            tBoxEmail.Text = ((ListaKorisnika)sender).teMail;
            tBoxDug.Text = ((ListaKorisnika)sender).tDug;
            tBoxFilmova.Text = ((ListaKorisnika)sender).tFilmova;
            if (((ListaKorisnika)sender).tAktivan == "1")
                cBoxAktivan.Checked = true;
            else { cBoxAktivan.Checked = false; }
        }

        private void cBoxAktivan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tBoxID.Text= "";
            tBoxIme.Text = "";
            tBoxPrezime.Text = "";
            tBoxJMBG.Text = "";
            tBoxAdresa.Text = "";
            tBoxTelefon.Text = "";
            tBoxEmail.Text = "";
            tBoxDug.Text = "";
            cBoxAktivan.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxFilmova_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxID.Text))
            {
                MessageBox.Show("Učitajte postojećeg user-a.");
                return;
            }
            var conn = Program.GetConnection();
            try
            {
                int ID = int.Parse(tBoxID.Text);
                String Ime = tBoxIme.Text;
                String Prezime = tBoxPrezime.Text;
                String JMBG = tBoxJMBG.Text;
                String Adresa = tBoxAdresa.Text;
                String Telefon = tBoxTelefon.Text;
                String eMail = tBoxEmail.Text;
                double Dug = double.Parse(tBoxDug.Text);
                int Aktivan = 0;
                if (cBoxAktivan.Checked)
                { Aktivan = 1; }
                var sp = new SqlCommand();
                conn.Open();
                sp.Connection = conn;
                sp.CommandText = "DELETE FROM tblKorisnici WHERE Ime = '" + Ime + "'AND Prezime = '" + Prezime + "'AND JMBG = '" + JMBG + "'AND Adresa = '" + Adresa + "'AND Telefon = '" + Telefon + "' AND eMail = '" + eMail + "'AND Dug = '" + Dug + "'AND Aktivan = '" + Aktivan + "'AND ID = '" + ID + "'";
                sp.ExecuteNonQuery();
                //sp.BeginExecuteNonQuery();

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

    }
}
