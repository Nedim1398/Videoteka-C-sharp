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
    public partial class RegistarZanrova : Form
    {
        string[] sName2 = new string[100];
        

        public RegistarZanrova()
        {
            InitializeComponent();
            fill_listBox1();
        }

        void fill_listBox1()
        {
            listView1.Items.Clear();
            var conn = Program.GetConnection();
            try
            {

                
                var sp = new SqlCommand();
                sp.CommandText = "SELECT Naziv, Opis, ID FROM tblZanrovi";
                conn.Open();
                sp.Connection = conn;
                sp.ExecuteNonQuery();
                var rdr = sp.ExecuteReader();
                while (rdr.Read())
                {
                    string sName = rdr.GetString(0);
                    
                    
                    int id = rdr.GetInt32(2);
                    sName2[id] = rdr.GetString(1);


                    ListViewItem lbi = new ListViewItem();
                    lbi.Text = sName;
                    lbi.Name = id.ToString();
                    //if (lbi.Text.Length > 2)
                    //{
                    //    lbi.Text = lbi.Name.Substring(1, lbi.Text.Length - 2);
                    //}

                    listView1.Items.Add(lbi);
                    /*
                    listBox1.Items.Add(lbi);
                    
                    listBox1.Items.ToString();
                    */
                    //System.Diagnostics.Debug.WriteLine(listBox1.Items.ToString());
                    
                }

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveGenre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxNaziv.Text) && string.IsNullOrEmpty(tBoxOpis.Text))
            {
                MessageBox.Show("Unesite podatke u Naziv i Opis!");
                return;
            }
            var conn = Program.GetConnection();
            try
            {
                String Naziv = tBoxNaziv.Text;
                String Opis = tBoxOpis.Text;
                //Boolean Aktivan = cBoxAktivan.CheckState;
                var sp = new SqlCommand();
                sp.CommandText = "SELECT TOP 1 * FROM tblZanrovi WHERE CONVERT(VARCHAR,Naziv) =  '" + Naziv + "' AND CONVERT(VARCHAR,Opis) = '" + Opis + "'";
                conn.Open();
                sp.Connection = conn;
                var rdr = sp.ExecuteReader();
                if (!rdr.HasRows)
                {
                    rdr.Close();
                    sp.CommandText = "INSERT INTO tblZanrovi (Naziv, Opis) VALUES('" + Naziv + "','" + Opis + "')";
                    sp.ExecuteNonQuery();
                    //sp.BeginExecuteNonQuery();
                }
                fill_listBox1();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }


        private void tBoxZanr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveGenre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxID.Text))
            {
                MessageBox.Show("Unesite ID postojećeg žanra!");
                return;
            }
            int ID = int.Parse(tBoxID.Text);
            String Naziv = tBoxNaziv.Text;
            String Opis = tBoxOpis.Text;
            var conn = Program.GetConnection();
            try
            {
                var sp = new SqlCommand();
                conn.Open();
                sp.Connection = conn;
                sp.CommandText = "DELETE FROM tblZanrovi WHERE ID= '" + ID + "'";
                sp.ExecuteNonQuery();
                //sp.BeginExecuteNonQuery();
                fill_listBox1();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxID.Text))
            {
                MessageBox.Show("Unesite ID postojećeg žanra!");
                return;
            }
            int ID = int.Parse(tBoxID.Text);
            String Naziv = tBoxNaziv.Text;
            String Opis = tBoxOpis.Text;
            var conn = Program.GetConnection();
            try
            {
                System.Diagnostics.Debug.WriteLine(Opis);
                var sp = new SqlCommand();
                conn.Open();
                sp.Connection = conn;
                sp.CommandText = "UPDATE tblZanrovi SET Naziv = '" + Naziv + "', Opis = '" + Opis + "' WHERE ID= '" + ID + "'";
                sp.ExecuteNonQuery();
                //sp.BeginExecuteNonQuery();
                fill_listBox1();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            tBoxID.Text = item.Name;
            tBoxNaziv.Text = item.Text;
            tBoxOpis.Text = sName2[Convert.ToInt32(tBoxID.Text)];
            //textBoxName.Text = item.SubItems[0].Text;
            //textBoxPhone.Text = item.SubItems[1].Text;
            //textBoxLevel.Text = item.SubItems[2].Text;
            //tBoxID.Text = listView1.SelectedItems[0].Text;
            //tBoxID.Text =;
            //tBoxNaziv.Text = ((ListViewItem)listBox1.SelectedItem).Text;
            //int counter = int.Parse(tBoxID.Text);
            //string sName3 = sName2[counter];
            //tBoxOpis.Text = sName3;
        }
    }

}