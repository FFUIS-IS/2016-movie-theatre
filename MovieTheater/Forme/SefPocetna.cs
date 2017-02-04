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
    }
}
