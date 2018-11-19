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
    public partial class RegistarFilmova : Form
    {
        SqlDataAdapter SDA;
        DataTable dt;
        DataGridViewCheckBoxColumn checks = new DataGridViewCheckBoxColumn();



        public RegistarFilmova()
        {
            InitializeComponent();
            checks.TrueValue = true;
            checks.FalseValue = false;
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            
            var conn = Program.GetConnection();
            try
            {
                tBoxBroj.Text = ""; ;
                String Naziv = tBoxNaziv.Text;
                String Stanje = tBoxStanje.Text;
                String Trajanje = tBoxTrajanje.Text;
                String Tip = tBoxTip.Text;
                //Boolean Aktivan = cBoxAktivan.CheckState;
                if (string.IsNullOrEmpty(Naziv) || string.IsNullOrEmpty(Stanje) || string.IsNullOrEmpty(Trajanje) || string.IsNullOrEmpty(Tip))
                    MessageBox.Show("Unesite podatke u sva obavezna polja!");

                else
                {
                    var sp = new SqlCommand();
                    sp.CommandText = "SELECT TOP 1 * FROM tblFilmovi WHERE Naziv = '" + Naziv + "' AND Stanje = '" + Stanje + "' AND Trajanje = '" + Trajanje + "' AND Tip = '" + Tip + "'";
                    conn.Open();
                    sp.Connection = conn;
                    var rdr = sp.ExecuteReader();
                    if (!rdr.HasRows)
                    {
                        rdr.Close();
                        sp.CommandText = "INSERT INTO tblFilmovi (Naziv, Stanje, Trajanje, Tip) VALUES('" + Naziv + "','" + Stanje + "','" + Trajanje + "','" + Tip + "')";
                        sp.ExecuteNonQuery();
                        //sp.BeginExecuteNonQuery();
                    }

                    List<int> zanrovi = new List<int>();
                    var i = dataGridView1.RowCount;
                    while (i > 0)
                    {
                        DataGridViewCheckBoxCell chkchecking = dataGridView1.Rows[i - 1].Cells["Checks"] as DataGridViewCheckBoxCell;

                        if (chkchecking.Value != null)
                            if (chkchecking.Value.ToString().ToLower().Equals("true"))
                            {
                                zanrovi.Add(Convert.ToInt16(dataGridView1.Rows[i - 1].Cells[1].Value));
                            }


                        i--;
                    }
                    rdr.Close();
                    sp.CommandText = "SELECT MAX(Broj) FROM tblFilmovi";
                    sp.ExecuteNonQuery();
                    tBoxBroj.Equals(sp.ExecuteNonQuery());

                    foreach (int a in zanrovi)
                    {
                        sp.CommandText = "INSERT INTO tblZanrFilm (IDFilma, IDZanra) VALUES('" + tBoxBroj + "','" + a + "')";
                        sp.ExecuteNonQuery();
                    }
                }
            }





            finally
            {
                if (conn != null)
                    conn.Close();
            }
        
        
        }

        private void btnSaveMovies_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxNaziv.Text) || string.IsNullOrEmpty(tBoxStanje.Text) || string.IsNullOrEmpty(tBoxTrajanje.Text) || string.IsNullOrEmpty(tBoxTip.Text))
            {
                MessageBox.Show("Unesite podatke u sva obavezna polja!");
                return;
            }
            int Broj = int.Parse(tBoxBroj.Text);
            String Naziv = tBoxNaziv.Text;
            String Stanje = tBoxStanje.Text;
            String Trajanje = tBoxTrajanje.Text;
            String Tip = tBoxTip.Text;
            var conn = Program.GetConnection();
            try
            {
                List<int> zanrovi = new List<int>();
                var i = dataGridView1.RowCount;
                while (i > 0)
                {
                    DataGridViewCheckBoxCell chkchecking = dataGridView1.Rows[i - 1].Cells["Checks"] as DataGridViewCheckBoxCell;

                    if (chkchecking.Value != null)
                        if (chkchecking.Value.ToString().ToLower().Equals("true"))
                        {
                            zanrovi.Add(Convert.ToInt16(dataGridView1.Rows[i - 1].Cells[1].Value));
                        }


                    i--;
                }

                var sp = new SqlCommand();
                conn.Open();
                sp.Connection = conn;
                sp.CommandText = "UPDATE tblFilmovi SET Naziv = '" + Naziv + "', Stanje = '" + Stanje + "', Trajanje = '" + Trajanje + "', Tip = '" + Tip + "' WHERE Broj = '" + Broj + "'";
                sp.ExecuteNonQuery();
                SqlDataReader rdr;

                foreach (int a in zanrovi)
                {
                    sp.CommandText = "SELECT * FROM tblZanrFilm WHERE IDFilma = '" + Broj + "' AND IDZanra = '" + a + "'";
                    rdr = sp.ExecuteReader();
                    if (rdr.HasRows)
                    {
                    }

                    else
                    {
                        rdr.Close();
                        sp.CommandText = "INSERT INTO tblZanrFilm (IDFilma, IDZanra) VALUES('" + Broj + "','" + a + "')";
                        sp.ExecuteNonQuery();
                    }
                    rdr.Close();
                }

                var i2 = dataGridView1.RowCount;
                System.Diagnostics.Debug.WriteLine(i2);
                while (i2 > 0)
                {
                    DataGridViewCheckBoxCell chkchecking2 = dataGridView1.Rows[i2 - 1].Cells["Checks"] as DataGridViewCheckBoxCell;
                    if (chkchecking2.Value != null)
                        if (chkchecking2.Value.ToString().ToLower().Equals("true")) { System.Diagnostics.Debug.WriteLine("Checkbox checked at " + i2); }
                        else
                        {
                            sp.CommandText = "DELETE FROM tblZanrFilm WHERE IDFilma = '" + Broj + "' AND IDZanra = '" + i2 + "'";
                            sp.ExecuteNonQuery();
                            System.Diagnostics.Debug.WriteLine("Izbrisan zanrfilm");
                        }
                    i2--;
                }

            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }



        }

        private void btnListMovies_Click(object sender, EventArgs e)
        {
            ListaFilmova movies = new ListaFilmova();
            movies.Show(this);
            movies.FormClosing += new FormClosingEventHandler(ListaFilmova_FormClosing);
        }
        private void ListaFilmova_FormClosing(object sender, EventArgs e)
        {

            tBoxBroj.Text = ((ListaFilmova)sender).tBroj;
            tBoxNaziv.Text = ((ListaFilmova)sender).tNaziv;
            tBoxStanje.Text = ((ListaFilmova)sender).tStanje;
            tBoxTrajanje.Text = ((ListaFilmova)sender).tTrajanje;
            if (((ListaFilmova)sender).tTip == "DVD") tBoxTip.Text = "0";
            else tBoxTip.Text = "1";

            var conn = Program.GetConnection();
            try
            {


                int i = dataGridView1.RowCount;

                var sp = new SqlCommand();
                conn.Open();
                sp.Connection = conn;
                while (i > 0)
                {
                    //System.Diagnostics.Debug.WriteLine(i);
                    if (!string.IsNullOrEmpty(tBoxBroj.Text))
                    {
                        sp.CommandText = "SELECT * FROM tblZanrFilm WHERE IDFilma = " + tBoxBroj.Text + " AND IDZanra = '" + i + "'";
                        var rdr6 = sp.ExecuteReader();
                        if (rdr6.Read() == true)
                        {
                            DataGridViewCheckBoxCell chkchecking2 = dataGridView1.Rows[i - 1].Cells["Checks"] as DataGridViewCheckBoxCell;
                            chkchecking2.Value = chkchecking2.TrueValue;


                        }
                        else
                        {
                            DataGridViewCheckBoxCell chkchecking2 = dataGridView1.Rows[i - 1].Cells["Checks"] as DataGridViewCheckBoxCell;
                            chkchecking2.Value = chkchecking2.FalseValue;
                        }
                        rdr6.Close();
                    }

                    i--;

                }
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistarFilmova_Load(object sender, EventArgs e)
        {
            var conn = Program.GetConnection();
            try
            {

                conn.Open();
                String sp = "SELECT Naziv,ID FROM tblZanrovi";

                SDA = new SqlDataAdapter(sp, conn);
                dt = new DataTable();
                SDA.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;

                dataGridView1.Columns["ID"].Visible = false;
                checks.Name = "Checks";
                dataGridView1.Columns.Add(checks);

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tBoxBroj.Text = "";
            tBoxNaziv.Text = "";
            tBoxStanje.Text = "";
            tBoxTrajanje.Text = "";
            tBoxTip.Text = "";

            var conn = Program.GetConnection();
            try
            {
                int i = dataGridView1.RowCount;

                var sp = new SqlCommand();
                conn.Open();
                sp.Connection = conn;
                while (i > 0)
                {
                    DataGridViewCheckBoxCell chkchecking2 = dataGridView1.Rows[i - 1].Cells["Checks"] as DataGridViewCheckBoxCell;
                    chkchecking2.Value = chkchecking2.FalseValue;
                    i--;

                }
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
    

