using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class UposlenikPocetna : Form
    {
        private string username;
        public UposlenikPocetna(string username)
        {
            this.username = username;
            InitializeComponent();
            this.uposlenikUsername_label.Text = username;

        }

        private void odjava_button_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
