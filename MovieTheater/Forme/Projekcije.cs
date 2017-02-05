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
    
    public partial class Projekcije : Form
    {
        private SefPocetna sefPocetna;
        public Projekcije(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void Projekcije_Load(object sender, EventArgs e)
        {
            ucitajPodatkeUcombobox();
            ucitajProjekcijeUgridView();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
        }

        private void ucitajPodatkeUcombobox()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Films", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Film> list = new List<Film>();

            while (Reader.Read())
            {
                System.Diagnostics.Debug.WriteLine(Reader["Name"]);
                list.Add(new Film((int)Reader["Id"], Reader["Name"].ToString()));

            }

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            Command = new SqlCeCommand(@"SELECT * FROM Rooms", Connection);
            Reader = Command.ExecuteReader();

            List<Rooms> list2 = new List<Rooms>();

            while (Reader.Read())
            {
                System.Diagnostics.Debug.WriteLine(Reader["Name"]);
                list2.Add(new Rooms((int)Reader["Id"], Reader["Name"].ToString()));

            }

            comboBox2.DataSource = list2;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";

        }

        private void ucitajProjekcijeUgridView()
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
                list.Add(new Projections((int)Reader["Id"], Reader["Film"].ToString(), Reader["Room"].ToString(), Reader["Time_of_Projection"].ToString(),(float)(double) Reader["price"]));

            }

            var bindingList = new BindingList<Projections>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int filmId = (int) comboBox1.SelectedValue;
            int roomId = (int)comboBox2.SelectedValue;
            string time_of_projection = dateTimePicker1.Text;
            float price = 0;
            try
            {
                 price = (float)Double.Parse(textBox1.Text);
            }
            catch(Exception e2)
            {
                MessageBox.Show("Unesite ispravan iznos.");

            }
            if (price <= 0) MessageBox.Show("Morate unijeti podatke o distributeru!");

            else
            {
                SqlCeConnection Connection = DBConnection.Instance.Connection;
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Projections(FilmsId, RoomsId, price , time_of_projection) VALUES(@filmsID, @roomsId, @price, @time_of_projection)", Connection);

                Command.Parameters.AddWithValue("@filmsId", filmId);
                Command.Parameters.AddWithValue("@roomsId", roomId);
                Command.Parameters.AddWithValue("@time_of_projection", time_of_projection);
                Command.Parameters.AddWithValue("@price", price);

                Command.ExecuteNonQuery();

                textBox1.Text = "";
                

                ucitajProjekcijeUgridView();

            }


        }
    }
}
