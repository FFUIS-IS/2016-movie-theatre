using MovieTheater.ViewModels;
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

        private void UposlenikPocetna_Load(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT p.Id, f.Name, r.Name Room, p.Time_of_projection Time, p.price FROM Projections p,Films f, Rooms r WHERE p.FilmsId = f.Id AND p.RoomsId = r.Id", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            //System.Diagnostics.Debug.WriteLine("Redova " + jobsReader.HasRows);

            List<Projections> projections = new List<Projections>();
            while (Reader.Read())
            {
                System.Diagnostics.Debug.WriteLine(Reader["Name"] + " " + Reader["Room"]);
                projections.Add(new Projections((int)Reader["Id"], Reader["Name"].ToString(), Reader["Room"].ToString(), Reader["Time"].ToString(), (float)(double)Reader["price"]));

            }

            var bindingList = new BindingList<Projections>(projections);
            var source = new BindingSource(bindingList, null);
            projekcijeDataGridView.DataSource = source;

        }
    }
}
