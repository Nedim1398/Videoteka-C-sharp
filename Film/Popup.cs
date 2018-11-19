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
    public partial class Popup : Form
    {
        SqlDataAdapter SDA;
        DataTable dt;
        public Popup()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Popup_Load(object sender, EventArgs e)
        {
            var conn = Program.GetConnection();
            try
            {



                String sp3 = "SELECT tblKorisnici.Ime, tblKorisnici.Prezime, tblFilmovi.Naziv, tblIznajmljivanje.DatumIzn, tblIznajmljivanje.DatumVrac, tblIznajmljivanje.Dug, tblFilmovi.Broj, tblIznajmljivanje.Korisnik,  tblKorisnici.ID, tblIznajmljivanje.Film, tblFilmovi.Tip FROM tblIznajmljivanje INNER JOIN tblKorisnici ON tblIznajmljivanje.Korisnik = tblKorisnici.ID INNER JOIN tblFIlmovi ON tblIznajmljivanje.Film = tblFilmovi.UID WHERE Broj = '" + MyGlobals.PopupGlobal + "' AND tblIznajmljivanje.DatumVrac IS NULL ORDER BY DatumVrac ASC";
                
                SDA = new SqlDataAdapter(sp3, conn);
                dt = new DataTable();
                SDA.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["Film"].Visible = false;
                    dataGridView1.Columns["Korisnik"].Visible = false;
                    dataGridView1.Columns["Broj"].Visible = false;
                    dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["Tip"].Visible = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
