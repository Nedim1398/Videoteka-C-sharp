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
    public partial class Iznajmljivanje : Form
    {
        SqlDataAdapter SDA3;
        DataTable dt3;
        String filmBroj;
        String korisnikID;

        public Iznajmljivanje()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void filter()
        {
            var conn = Program.GetConnection();
            try
            {
                String refresh = @"SELECT tblFilmovi.Naziv, tblIznajmljivanje.DatumIzn, tblIznajmljivanje.DatumVrac, tblIznajmljivanje.Dug, tblFilmovi.Broj, tblIznajmljivanje.Korisnik,  tblKorisnici.ID, tblIznajmljivanje.Film, tblFilmovi.Tip
                                FROM tblIznajmljivanje
                                INNER JOIN tblKorisnici ON tblIznajmljivanje.Korisnik = tblKorisnici.ID
                                INNER JOIN tblFIlmovi ON tblIznajmljivanje.Film = tblFilmovi.UID
                                WHERE tblIznajmljivanje.Korisnik = '" + tBoxKorisnik.Text + "' ORDER BY DatumVrac ASC";

                SDA3 = new SqlDataAdapter(refresh, conn);
                dt3 = new DataTable();
                SDA3.Fill(dt3);
                bindingSource3.DataSource = dt3;
                dataGridView3.DataSource = bindingSource3;
                dataGridView3.Columns["Korisnik"].Visible = false;
                dataGridView3.Columns["Film"].Visible = false;
                dataGridView3.Columns["Broj"].Visible = false;
                dataGridView3.Columns["ID"].Visible = false;
                dataGridView3.Columns["Tip"].Visible = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }
            
        private void Iznajmljivanje_Load(object sender, EventArgs e)
        {
            var conn = Program.GetConnection();
            try
            {

                conn.Open();
                /*String sp = "SELECT  Naziv, Stanje, Trajanje, Tip, Broj FROM tblFilmovi";

                SDA = new SqlDataAdapter(sp, conn);
                dt = new DataTable();
                SDA.Fill(dt);
                bindingSource1.DataSource = dt;

                
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["Broj"].Visible = false;
                dataGridView1.Columns["Tip"].Visible = false;
                



                String sp2 = "SELECT Ime, Prezime, ID FROM tblKorisnici";

                SDA2 = new SqlDataAdapter(sp2, conn);
                dt2 = new DataTable();
                SDA2.Fill(dt2);
                bindingSource2.DataSource = dt2;

                dataGridView2.DataSource = bindingSource2;
                dataGridView2.Columns["ID"].Visible = false;*/
                

                String sp3 = @"SELECT tblFilmovi.Naziv, tblIznajmljivanje.DatumIzn, tblIznajmljivanje.DatumVrac, tblIznajmljivanje.Dug, tblFilmovi.Broj, tblIznajmljivanje.Korisnik,  tblKorisnici.ID, tblIznajmljivanje.Film, tblFilmovi.Tip
                                FROM tblIznajmljivanje
                                INNER JOIN tblKorisnici ON tblIznajmljivanje.Korisnik = tblKorisnici.ID
                                INNER JOIN tblFIlmovi ON tblIznajmljivanje.Film = tblFilmovi.UID
                                WHERE tblIznajmljivanje.Korisnik = '"+tBoxKorisnik.Text+"' ORDER BY DatumVrac ASC";


                SDA3 = new SqlDataAdapter(sp3, conn);
                dt3 = new DataTable();
                SDA3.Fill(dt3);
                bindingSource3.DataSource = dt3;

                dataGridView3.DataSource = bindingSource3;
                dataGridView3.Columns["Film"].Visible = false;
                dataGridView3.Columns["Korisnik"].Visible = false;
                dataGridView3.Columns["Broj"].Visible = false;
                dataGridView3.Columns["ID"].Visible = false;
                dataGridView3.Columns["Tip"].Visible = false;
                dataGridView3.Columns[0].Width = 100;
                dataGridView3.Columns[1].Width = 100;
                dataGridView3.Columns[2].Width = 100;
                dataGridView3.Columns[3].Width = 100;
                

                dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void tBoxKorisnik_TextChanged(object sender, EventArgs e)
        {
            filter();
        }


        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxKorisnik.Text)&& string.IsNullOrEmpty(tBoxFilm.Text))
            {
                MessageBox.Show("Unesite podatke u sva polja!");
                return;
            }
            var conn = Program.GetConnection();
            try
            {
                int Broj = int.Parse(tBoxFilm.Text);
                String Korisnik = tBoxKorisnik.Text;
                
                var sp = new SqlCommand();
                //sp.Parameters.Clear();
                sp.CommandText = "prviMatchingKorisnik";
                sp.CommandType = CommandType.StoredProcedure;
                sp.Parameters.Add("@InsertedID", SqlDbType.Int).Value = Korisnik;
                //sp.CommandText = "SELECT TOP 1 * FROM tblKorisnici WHERE ID = '" + Korisnik + "'";
                conn.Open();
                sp.Connection = conn;
                var rdr2 = sp.ExecuteReader();
                if (!rdr2.HasRows)
                {
                    System.Diagnostics.Debug.WriteLine("Procedura!");
                    return;
                }
                rdr2.Close();

                sp.Parameters.Clear();
                sp.CommandText = "prviMatchingBroj";
                sp.CommandType = CommandType.StoredProcedure;
                sp.Parameters.Add("@InsertedBroj", SqlDbType.Int).Value = Broj;
                //sp.CommandText = "SELECT TOP 1 * FROM tblFilmovi WHERE Broj = " + Broj + "";

                sp.Connection = conn;
                var rdr3 = sp.ExecuteReader();
                if (!rdr3.HasRows)
                {
                    System.Diagnostics.Debug.WriteLine("Procedura!");
                    return;
                }
                rdr3.Close();

                sp.Parameters.Clear();
                sp.CommandText = "provjeriStanjeFilma";
                sp.CommandType = CommandType.StoredProcedure;
                sp.Parameters.Add("@InsertedBroj", SqlDbType.Int).Value = Broj;
                //sp.CommandText = "SELECT TOP 1 Stanje FROM tblFilmovi WHERE Broj = " + Broj + "";
                sp.Connection = conn;
                String tester = "";
                var rdr5 = sp.ExecuteReader();
                while (rdr5.Read())
                {
                    tester = rdr5.GetValue(0).ToString();
                    System.Diagnostics.Debug.WriteLine(tester);
                }
                if (tester=="0")
                {
                    return; //Ako nema filma, izbaci 0
                }
                rdr5.Close();

                sp.CommandType = CommandType.Text;
                sp.CommandText = "UPDATE tblFilmovi SET Stanje= 0 WHERE Broj = " + Broj + "";
                sp.ExecuteNonQuery();
                sp.CommandText = "SELECT TOP 1 UID FROM tblFilmovi WHERE Broj = " + Broj + "";
                //sp.ExecuteReader();
                var rdr4 = sp.ExecuteReader();
                String UIDval = "";
                if (rdr4.HasRows)
                {
                    rdr4.Read();
                    UIDval = rdr4.GetValue(0).ToString();
                }
                rdr4.Close();
                DateTime today = DateTime.Now;
                sp.CommandText = "INSERT INTO tblIznajmljivanje(Korisnik, Film, DatumIzn, DatumVrac, Dug, Radnik) VALUES('" + Korisnik + "', CONVERT(uniqueidentifier,'" + UIDval + "'), '" + today + "', null, 0, '"+MyGlobals.Logged+"')";
                sp.ExecuteNonQuery();



                /*String refresh = "SELECT  Naziv, Stanje, Trajanje, Tip, Broj FROM tblFilmovi";

                SDA = new SqlDataAdapter(refresh, conn);
                    dt = new DataTable();
                    SDA.Fill(dt);
                    bindingSource1.DataSource = dt;
                    dataGridView1.DataSource = bindingSource1;
                    dataGridView1.Columns["Broj"].Visible = false;
                    dataGridView1.Columns["Tip"].Visible = false;

                refresh = "SELECT Ime, Prezime, ID FROM tblKorisnici";

                SDA2 = new SqlDataAdapter(refresh, conn);
                dt2 = new DataTable();
                SDA2.Fill(dt2);
                bindingSource2.DataSource = dt2;
                dataGridView2.DataSource = bindingSource2;
                dataGridView2.Columns["ID"].Visible = false;*/

                String refresh = @"SELECT tblFilmovi.Naziv, tblIznajmljivanje.DatumIzn, tblIznajmljivanje.DatumVrac, tblIznajmljivanje.Dug, tblFilmovi.Broj, tblIznajmljivanje.Korisnik,  tblKorisnici.ID, tblIznajmljivanje.Film, tblFilmovi.Tip
                                FROM tblIznajmljivanje
                                INNER JOIN tblKorisnici ON tblIznajmljivanje.Korisnik = tblKorisnici.ID
                                INNER JOIN tblFIlmovi ON tblIznajmljivanje.Film = tblFilmovi.UID
                                WHERE tblIznajmljivanje.Korisnik = '" + tBoxKorisnik.Text + "' ORDER BY DatumVrac ASC";

                SDA3 = new SqlDataAdapter(refresh, conn);
                dt3 = new DataTable();
                SDA3.Fill(dt3);
                bindingSource3.DataSource = dt3;
                dataGridView3.DataSource = bindingSource3;
                dataGridView3.Columns["Korisnik"].Visible = false;
                dataGridView3.Columns["Film"].Visible = false;
                dataGridView3.Columns["Broj"].Visible = false;
                dataGridView3.Columns["ID"].Visible = false;
                dataGridView3.Columns["Tip"].Visible = false;


            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxKorisnik.Text) && string.IsNullOrEmpty(tBoxFilm.Text))
            {
                MessageBox.Show("Unesite podatke u sva polja!");
                return;
            }
            var conn = Program.GetConnection();
            try
            {
                int Broj = int.Parse(tBoxFilm.Text);
                String Korisnik = tBoxKorisnik.Text;
                var sp = new SqlCommand();
                sp.Parameters.Clear();
                sp.CommandText = "prviMatchingKorisnik";
                sp.CommandType = CommandType.StoredProcedure;
                sp.Parameters.Add("@InsertedID", SqlDbType.Int).Value = Korisnik;
                conn.Open();
                sp.Connection = conn;
                var rdr2 = sp.ExecuteReader();
                if (!rdr2.HasRows)
                {
                    return;
                }
                rdr2.Close();


                sp.Parameters.Clear();
                sp.CommandText = "prviMatchingBroj";
                sp.CommandType = CommandType.StoredProcedure;
                sp.Parameters.Add("@InsertedBroj", SqlDbType.Int).Value = Broj;

                sp.Connection = conn;
                var rdr3 = sp.ExecuteReader();
                if (!rdr3.HasRows)
                {
                    return;
                }
                rdr3.Close();

                sp.Parameters.Clear();
                sp.CommandText = "provjeriStanjeFilma";
                sp.CommandType = CommandType.StoredProcedure;
                sp.Parameters.Add("@InsertedBroj", SqlDbType.Int).Value = Broj;
                //sp.CommandText = "SELECT TOP 1 Stanje FROM tblFilmovi WHERE Broj = " + Broj + "";
                sp.Connection = conn;
                String tester = "";
                var rdr5 = sp.ExecuteReader();
                while (rdr5.Read())
                {
                    tester = rdr5.GetValue(0).ToString();
                    System.Diagnostics.Debug.WriteLine(tester);
                }
                if (tester == "1")
                {
                    return; //Ako ima filma, izbaci 1
                }
                rdr5.Close();

                sp.CommandType = CommandType.Text;
                sp.CommandText = "UPDATE tblFilmovi SET Stanje= 1 WHERE Broj = " + Broj + "";
                sp.ExecuteNonQuery();
                sp.CommandText = "SELECT TOP 1 UID FROM tblFilmovi  WHERE Broj = " + Broj + "";
                //sp.ExecuteReader();
                var rdr4 = sp.ExecuteReader();

                String UIDval = "";
                if(rdr4.HasRows){
                    rdr4.Read();
                    UIDval = rdr4.GetValue(0).ToString();
                }
                rdr4.Close();

                DateTime today = DateTime.Now;
                
                sp.CommandText = "WITH iznajmi AS (SELECT TOP 1 Film, DatumVrac, Dug, Radnik FROM tblIznajmljivanje WHERE Korisnik = '" + Korisnik + "' AND DatumVrac IS NULL) " +
                                 "UPDATE iznajmi SET Film = CONVERT(uniqueidentifier,'" + UIDval+"'), DatumVrac = '" + today + "', Dug = 0, Radnik = '" + MyGlobals.Logged + "'";
                sp.ExecuteNonQuery();

                /*String refresh = "SELECT Naziv, Stanje, Trajanje, Tip, Broj FROM tblFilmovi";

                SDA = new SqlDataAdapter(refresh, conn);
                dt = new DataTable();
                SDA.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                dataGridView1.Columns["Broj"].Visible = false;
                dataGridView1.Columns["Tip"].Visible = false;


                refresh = "SELECT Ime, Prezime, ID FROM tblKorisnici";

                SDA2 = new SqlDataAdapter(refresh, conn);
                dt2 = new DataTable();
                SDA2.Fill(dt2);
                bindingSource2.DataSource = dt2;
                dataGridView2.DataSource = bindingSource2;
                dataGridView2.Columns["ID"].Visible = false; */
                

                String refresh = @"SELECT tblFilmovi.Naziv, tblIznajmljivanje.DatumIzn, tblIznajmljivanje.DatumVrac, tblIznajmljivanje.Dug, tblFilmovi.Broj, tblIznajmljivanje.Korisnik,  tblKorisnici.ID, tblIznajmljivanje.Film, tblFilmovi.Tip
                                FROM tblIznajmljivanje
                                INNER JOIN tblKorisnici ON tblIznajmljivanje.Korisnik = tblKorisnici.ID
                                INNER JOIN tblFIlmovi ON tblIznajmljivanje.Film = tblFilmovi.UID
                                WHERE tblIznajmljivanje.Korisnik = '" + tBoxKorisnik.Text + "' ORDER BY DatumVrac ASC";

                SDA3 = new SqlDataAdapter(refresh, conn);
                dt3 = new DataTable();
                SDA3.Fill(dt3);
                bindingSource3.DataSource = dt3;
                dataGridView3.DataSource = bindingSource3;
                dataGridView3.Columns["Korisnik"].Visible = false;
                dataGridView3.Columns["Film"].Visible = false;
                dataGridView3.Columns["Broj"].Visible = false;
                dataGridView3.Columns["ID"].Visible = false;
                dataGridView3.Columns["Tip"].Visible = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];

            korisnikID = Convert.ToString(selectedRow.Cells["Korisnik"].Value);
            filmBroj = Convert.ToString(selectedRow.Cells["Broj"].Value);

            /*
            string a = Convert.ToString(selectedRow.Cells["Ime"].Value);
            a += " ";
            a += Convert.ToString(selectedRow.Cells["Prezime"].Value);

            string b = Convert.ToString(selectedRow.Cells["Naziv"].Value);
            b += " ";
            if (Convert.ToInt16(selectedRow.Cells["Tip"].Value) == 0)
                b += "- DVD";
            else b += "- BlueRay";*/

            tBoxKorisnik.Text = korisnikID;
            tBoxFilm.Text = filmBroj;
        }

        private void ListaKorisnika_FormClosing(object sender, EventArgs e)
        {
            tBoxKorisnik.Text=((ListaKorisnika)sender).tID;
        }
        private void ListaFilmova_FormClosing(object sender, EventArgs e)
        {
            tBoxFilm.Text = ((ListaFilmova)sender).tBroj;
        }

        private void btnSearchFilmove_Click(object sender, EventArgs e)
        {
            ListaFilmova searchF = new ListaFilmova();
            searchF.Show(this);
            searchF.FormClosing += new FormClosingEventHandler(ListaFilmova_FormClosing);
        }

        private void btnSearchKorisnike_Click(object sender, EventArgs e)
        {
            ListaKorisnika searchK = new ListaKorisnika();
            searchK.Show(this);
            searchK.FormClosing += new FormClosingEventHandler(ListaKorisnika_FormClosing);
        }
    }
}
