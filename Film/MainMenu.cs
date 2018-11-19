using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film 
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosed += MainMenu_FormClosed;
            textBox1.Text = MyGlobals.Logged;
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnIznajmljivanje_Click(object sender, EventArgs e)
        {
            Iznajmljivanje iznajmi = new Iznajmljivanje();
            iznajmi.Show(this);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            RegistarKorisnika users = new RegistarKorisnika();
            users.Show(this);
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            RegistarFilmova movies = new RegistarFilmova();
            movies.Show(this);
        }

        private void btnGenres_Click(object sender, EventArgs e)
        {
            RegistarZanrova genres = new RegistarZanrova();
            genres.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Prijava prijava = new Prijava();
            prijava.Show();
        }


    }
}
