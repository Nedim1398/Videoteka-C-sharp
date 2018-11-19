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
    public partial class ListaKorisnika : Form
    {
        SqlDataAdapter SDA;
        DataTable dt;
        public string tIme = "";
        public string tPrezime = "";
        public string tJMBG = "";
        public string tAdresa = "";
        public string tTelefon = "";
        public string teMail = "";
        public string tDug = "";
        public string tAktivan;
        public string tFilmova = "";
        public string tID = "";
        TextBox poljeKorisnika;

        public ListaKorisnika()
        {
            InitializeComponent();
        }

        public ListaKorisnika(TextBox poljeKorisnika)
        {
            InitializeComponent();
            this.poljeKorisnika = poljeKorisnika;
        }

        public void filter()
        {
            var conn = Program.GetConnection();
            
            int value;
            int value2;
            try
            {
                conn.Open();

                string doFilter = "SELECT ID, Ime, Prezime, JMBG, Adresa, Telefon, eMail, Dug, CASE(Aktivan) WHEN 0 THEN 'NE' WHEN 1 THEN 'DA' END AS 'Aktivan' FROM tblKorisnici WHERE 1=1";
                if (!(string.IsNullOrWhiteSpace(textBox1.Text)) && int.TryParse(textBox1.Text, out value))
                    doFilter += " AND ID = " + textBox1.Text + "";
                if (!(string.IsNullOrWhiteSpace(textBox2.Text)))
                    doFilter += " AND Ime Like '%" + textBox2.Text + "%'";
                if (!(string.IsNullOrWhiteSpace(textBox3.Text)))
                    doFilter += " AND Prezime Like '%" + textBox3.Text + "%'";
                if (!(string.IsNullOrWhiteSpace(textBox4.Text)))
                    doFilter += " AND JMBG Like '%" + textBox4.Text + "%'";
                if (!(string.IsNullOrWhiteSpace(textBox5.Text)))
                    doFilter += " AND Adresa Like '%" + textBox5.Text + "%'";
                if (!(string.IsNullOrWhiteSpace(textBox6.Text)))
                    doFilter += " AND Telefon Like '%" + textBox6.Text + "%'";
                if (!(string.IsNullOrWhiteSpace(textBox7.Text)))
                    doFilter += " AND eMail Like '%" + textBox7.Text + "%'";
                if (!(string.IsNullOrWhiteSpace(textBox8.Text)) && int.TryParse(textBox8.Text, out value2))
                    doFilter += "  AND Dug = " + textBox8.Text;

                SDA = new SqlDataAdapter(doFilter, conn);
                dt = new DataTable();
                SDA.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListaKorisnika_Load(object sender, EventArgs e)
        {
            var conn = Program.GetConnection();
            try
            {

                conn.Open();
                String sp = "SELECT ID, Ime, Prezime, JMBG, Adresa, Telefon, eMail, Dug, CASE(Aktivan) WHEN 0 THEN 'NE' WHEN 1 THEN 'DA' END AS 'Aktivan' FROM tblKorisnici";

                SDA = new SqlDataAdapter(sp, conn);
                dt = new DataTable();
                SDA.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;

                dataGridView1.Columns[0].Width = 55;
                dataGridView1.Columns[1].Width = 105;
                dataGridView1.Columns[2].Width = 105;
                dataGridView1.Columns[3].Width = 105;
                dataGridView1.Columns[4].Width = 105;
                dataGridView1.Columns[5].Width = 105;
                dataGridView1.Columns[6].Width = 105;
                dataGridView1.Columns[7].Width = 60;
                dataGridView1.Columns[8].Width = 50;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

            private void textBox8_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
            
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            tIme = Convert.ToString(selectedRow.Cells["Ime"].Value);
            tPrezime= Convert.ToString(selectedRow.Cells["Prezime"].Value);
            tJMBG = Convert.ToString(selectedRow.Cells["JMBG"].Value);
            tAdresa = Convert.ToString(selectedRow.Cells["Adresa"].Value);
            tTelefon = Convert.ToString(selectedRow.Cells["Telefon"].Value);
            teMail = Convert.ToString(selectedRow.Cells["eMail"].Value);
            tDug = Convert.ToString(selectedRow.Cells["Dug"].Value);
            tAktivan = Convert.ToString(selectedRow.Cells["Aktivan"].Value);
            if (tAktivan == "DA")
                tAktivan = "1";
            else tAktivan = "0";

            this.Text = Convert.ToString(selectedRow.Cells["ID"].Value); ;

            var conn = Program.GetConnection();
            try
            {

                conn.Open();
                var sp = new SqlCommand();
                sp.CommandText = "SELECT COUNT(Korisnik) FROM tblIznajmljivanje WHERE Korisnik = '" + this.Text + "' AND DatumVrac IS NULL";
                sp.Connection = conn;
                //string a = 
                // System.Diagnostics.Debug.WriteLine(sp.ExecuteScalar());
                
                tFilmova = Convert.ToString(sp.ExecuteScalar());

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            
            this.Close();
            

        }

        private void ListaKorisnika_FormClosing(object sender, FormClosingEventArgs e)
        {
            //poljeKorisnika.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            tIme = Convert.ToString(selectedRow.Cells["Ime"].Value);
            tPrezime = Convert.ToString(selectedRow.Cells["Prezime"].Value);
            tJMBG = Convert.ToString(selectedRow.Cells["JMBG"].Value);
            tAdresa = Convert.ToString(selectedRow.Cells["Adresa"].Value);
            tTelefon = Convert.ToString(selectedRow.Cells["Telefon"].Value);
            teMail = Convert.ToString(selectedRow.Cells["eMail"].Value);
            tDug = Convert.ToString(selectedRow.Cells["Dug"].Value);
            tAktivan = Convert.ToString(selectedRow.Cells["Aktivan"].Value);
            if (tAktivan == "DA")
                tAktivan = "1";
            else tAktivan = "0";

            tID = Convert.ToString(selectedRow.Cells["ID"].Value); ;

            var conn = Program.GetConnection();
            try
            {

                conn.Open();
                var sp = new SqlCommand();
                sp.CommandText = "SELECT COUNT(Korisnik) FROM tblIznajmljivanje WHERE Korisnik = '" + tID + "' AND DatumVrac IS NULL";
                sp.Connection = conn;
                //string a = 
                // System.Diagnostics.Debug.WriteLine(sp.ExecuteScalar());

                tFilmova = Convert.ToString(sp.ExecuteScalar());

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            
            //this.Close();
        }
    }
}
