using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater.Forme
{
    public partial class SefPocetna : Form
    {
        private string username;

        public SefPocetna()
        {
            InitializeComponent();
        }

        public SefPocetna(string username)
        {
            this.username = username;
            InitializeComponent();
            this.usernameLabel.Text = username;
        }

        private void SefPocetna_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void odjava_button_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void distributorsButton_Click(object sender, EventArgs e)
        {
            Distributeri distributeri = new Distributeri(this);
            distributeri.Show();
            this.Hide();
        }

        private void filmoviButton_Click(object sender, EventArgs e)
        {
            Filmovi filmovi = new Filmovi(this);
            filmovi.Show();
            this.Hide();
        }

        private void projekcijeButton_Click(object sender, EventArgs e)
        {
            Projekcije projekcije= new Projekcije(this);
            projekcije.Show();
            this.Hide();
        }

        private void tipoviFilmovaButton_Click(object sender, EventArgs e)
        {
            Zanrovi zanrovi = new Zanrovi(this);
            zanrovi.Show();
            this.Hide();
        }

        private void posloviButton_Click(object sender, EventArgs e)
        {
            Poslovi poslovi = new Poslovi(this);
            poslovi.Show();
            this.Hide();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale(this);
            sale.Show();
            this.Hide();
        }

        private void mjestaButton_Click(object sender, EventArgs e)
        {
            Mjesta mjesta = new Mjesta(this);
            mjesta.Show();
            this.Hide();
        }

        private void uposleniciButton_Click(object sender, EventArgs e)
        {
            Uposlenici uposlenici = new Uposlenici(this);
            uposlenici.Show();
            this.Hide();
        }
    }
}
