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
    public partial class ListaFilmova : Form
    {
        TextBox poljeFilmova;
        SqlDataAdapter SDA;
        DataTable dt;
        public string tBroj = "";
        public string tNaziv = "";
        public string tStanje = "";
        public string tTrajanje = "";
        public string tTip = "";

        public ListaFilmova()
        {
            InitializeComponent();
        }

        public ListaFilmova(TextBox poljeFilmova)
        {
        InitializeComponent();
            this.poljeFilmova = poljeFilmova;
        }

        public void filter()
        {
            var conn = Program.GetConnection();
            int value;
            int value2;
            int value3;
            int value4;
            try
            {
                conn.Open();
                string doFilter = "SELECT Broj,Naziv,Stanje,Trajanje,CASE(Tip) WHEN 0 THEN 'DVD' WHEN 1 THEN 'BlueRay' END AS 'Tip' FROM tblFilmovi WHERE 1=1";
                if (!(string.IsNullOrWhiteSpace(textBox1.Text)) && int.TryParse(textBox1.Text, out value))
                    doFilter += " AND Broj = " + textBox1.Text;
                if (!(string.IsNullOrWhiteSpace(textBox2.Text)))
                    doFilter += " AND Naziv Like '%" + textBox2.Text + "%'";
                if (!(string.IsNullOrWhiteSpace(textBox3.Text)) && int.TryParse(textBox3.Text, out value2))
                    doFilter += " AND Stanje = " + textBox3.Text + "";
                if (!(string.IsNullOrWhiteSpace(textBox4.Text)) && int.TryParse(textBox4.Text, out value3))
                    doFilter += " AND Trajanje = " + textBox4.Text + "";
                if (Convert.ToBoolean(checkBox1.Checked.ToString()) == true && Convert.ToBoolean(checkBox2.Checked.ToString()) == true)
                { }
                else
                {
                    if (Convert.ToBoolean(checkBox1.Checked.ToString()) == true)
                        doFilter += " AND Tip = 0";
                    if (Convert.ToBoolean(checkBox2.Checked.ToString()) == true)
                        doFilter += " AND Tip = 1";
                }

                SDA = new SqlDataAdapter(doFilter, conn);
                dt = new DataTable();
                SDA.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                System.Diagnostics.Debug.WriteLine(checkBox1.Checked.ToString());
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


        private void ListaFilmova_Load(object sender, EventArgs e)
        {
            var conn = Program.GetConnection();
            
            try
            {

                conn.Open();
                String sp = "SELECT Broj,Naziv,Stanje,Trajanje,CASE(Tip) WHEN 0 THEN 'DVD' WHEN 1 THEN 'BlueRay' END AS 'Tip' FROM tblFilmovi";

                SDA = new SqlDataAdapter(sp, conn);
                dt = new DataTable();
                SDA.Fill(dt);
                bindingSource1.DataSource = dt;

                dataGridView1.DataSource = bindingSource1;

                dataGridView1.RowHeadersVisible = false;

                dataGridView1.Columns[0].Width = 55;
                dataGridView1.Columns[1].Width = 205;
                dataGridView1.Columns[2].Width = 60;
                dataGridView1.Columns[3].Width = 80;
                dataGridView1.Columns[4].Width = 120;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            tBroj = Convert.ToString(selectedRow.Cells["Broj"].Value);
            tNaziv = Convert.ToString(selectedRow.Cells["Naziv"].Value);
            tStanje = Convert.ToString(selectedRow.Cells["Stanje"].Value);
            tTrajanje = Convert.ToString(selectedRow.Cells["Trajanje"].Value);
            tTip = Convert.ToString(selectedRow.Cells["Tip"].Value);

            this.Close();
            
        }

        private void ListaFilmova_FormClosing(object sender, FormClosingEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            tBroj = Convert.ToString(selectedRow.Cells["Broj"].Value);
            tNaziv = Convert.ToString(selectedRow.Cells["Naziv"].Value);
            tStanje = Convert.ToString(selectedRow.Cells["Stanje"].Value);
            tTrajanje = Convert.ToString(selectedRow.Cells["Trajanje"].Value);
            tTip = Convert.ToString(selectedRow.Cells["Tip"].Value);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnProvjeraIznajmljenih_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            MyGlobals.PopupGlobal = Convert.ToString(selectedRow.Cells["Broj"].Value);

            Popup popup = new Popup();
            popup.Show(this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }
    }
}
