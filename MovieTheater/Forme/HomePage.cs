using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class HomePage : Form
    {
        
        public HomePage()
        {
            InitializeComponent();
        }

        public string GetHomeDirectory()
        {
            return Directory.GetCurrentDirectory().ToString(); ;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void closeAppButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        
    }
}
