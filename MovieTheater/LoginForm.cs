using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void cancelLoginButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginType = loginTypeComboBox.Text.Trim();
            string username = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if(loginType.Length == 0)
            {
                MessageBox.Show("Odaberite nacin prijave!");
                return;
            }
            if (username.Length == 0)
            {
                MessageBox.Show("Unesite korisnicko ime!");
                return;
            }
            if(password.Length == 0)
            {
                MessageBox.Show("Unesite password!");
                return;
            }

            DBLogin.CheckLogin(username, password, loginType);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand jobCommand = new SqlCeCommand(@"SELECT * FROM Jobs", Connection);
            SqlCeDataReader jobsReader = jobCommand.ExecuteReader();

            if(loginTypeComboBox.Items.Count > 0) loginTypeComboBox.Items.Clear();
            //System.Diagnostics.Debug.WriteLine("Redova " + jobsReader.HasRows);

            while (jobsReader.Read()) 
            {
                System.Diagnostics.Debug.WriteLine(jobsReader["Name"] + " " + jobsReader["Description"]);
                loginTypeComboBox.Items.Add(jobsReader["Name"]);
            }

        }
    }
}
