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

namespace MovieTheater.Forme
{
    public partial class Prodaja : Form
    {
        private int employeeId;
        public Prodaja(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
        }

        private void Prodaja_Load(object sender, EventArgs e)
        {
            ucitajPodatkeUcombobox();
            comboBox1.SelectedValueChanged += new EventHandler(combobox1_selectionChanged);
        }

        private void combobox1_selectionChanged(object sender, EventArgs e)
        {
            int projectionId = (int)comboBox1.SelectedValue;
            ucitajMjestaUcombobox(projectionId);
        }

        private void ucitajPodatkeUcombobox()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT p.*, f.Name Film, r.Name Room FROM Projections p, Films f, Rooms r WHERE p.FilmsId = f.Id AND p.RoomsId = r.Id", Connection);

            SqlCeDataReader Reader = null;
            try
            {
                Reader = Command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska sa bazom");
                return;
            }
            List<Projections> list = new List<Projections>();
            while (Reader.Read())
            {
                list.Add(new Projections((int)Reader["Id"], Reader["Film"].ToString(), Reader["Room"].ToString(), Reader["Time_of_Projection"].ToString(), (float)(double)Reader["price"]));

            }

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "ProjectionName";
            comboBox1.ValueMember = "Id";
        }

        private void ucitajMjestaUcombobox(int projectionId)
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"select * from seats, rooms, projections where seats.RoomsId = rooms.Id AND projections.RoomsId = rooms.Id AND projections.Id = @projectionId AND seats.Id not in (select SeatsId from Tickets where ProjectionsId = @projectionId)", Connection);
            Command.Parameters.AddWithValue("@projectionId", projectionId);

            SqlCeDataReader Reader = null;
            try
            {
                Reader = Command.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Greska sa bazom");
                return;
            }
            List<Seats> list = new List<Seats>();
            while (Reader.Read())
            {
                list.Add(new Seats((int)Reader["Id"], (int)Reader["Row"], (int)Reader["Number"], (int)Reader["RoomsId"]));
            }

            comboBox2.DataSource = list;
            comboBox2.DisplayMember = "seatsName";
            comboBox2.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int projectionId = (int)comboBox1.SelectedValue;
            int seatsId = (int)comboBox2.SelectedValue;
            DateTime datumIvrijeme = DateTime.Now;
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Tickets(SeatsId, ProjectionsId, EmployersId, dateOfSale) VALUES(@seatsId, @projectionsId, @employersId, @dateOfSale)", Connection);

            Command.Parameters.AddWithValue("@seatsId", seatsId);
            Command.Parameters.AddWithValue("@projectionsId", projectionId);
            Command.Parameters.AddWithValue("@employersId", employeeId);
            Command.Parameters.AddWithValue("@dateOfSale", datumIvrijeme);

            Command.ExecuteNonQuery();

            ucitajMjestaUcombobox(projectionId);

        }
    }
}
