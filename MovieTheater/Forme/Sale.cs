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
    public partial class Sale : Form
    {
        private SefPocetna sefPocetna;

        public Sale()
        {
            InitializeComponent();
        }

        public Sale(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sefPocetna.Show();
            this.Close();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            ucitajSaleUgridView();
            dataGridView1.SelectionChanged += new EventHandler(gridView1_selectionChanged);
        }

        private void gridView1_selectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            int roomId = (int)row.Cells["Id"].Value;
            ucitajMjestaUGridView(roomId);
        }

        private void ucitajMjestaUGridView(int roomId)
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Seats Where RoomsId = @roomId", Connection);
            Command.Parameters.AddWithValue("roomId", roomId);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Seats> list = new List<Seats>();

            while (Reader.Read())
            {
                list.Add(new Seats((int)Reader["Id"],(int) Reader["Row"], (int)Reader["Number"], (int)Reader["RoomsId"]));

            }

            var bindingList = new BindingList<Seats>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView2.DataSource = source;
        }
        private void ucitajSaleUgridView()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Rooms", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Rooms> list = new List<Rooms>();

            while (Reader.Read())
            {
                list.Add(new Rooms((int)Reader["Id"], Reader["Name"].ToString(), (int)Reader["NumberOfPlaces"]));

            }

            var bindingList = new BindingList<Rooms>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int numberOfPlaces = Int32.Parse(textBox2.Text);

            if (name == "" || numberOfPlaces == 0) MessageBox.Show("Morate ispravno unijeti podatke!");

            else
            {
                SqlCeConnection Connection = DBConnection.Instance.Connection;
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Rooms(Name, NumberOfPlaces) VALUES(@name, @numberOfPlaces)", Connection);

                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@numberOfPlaces", numberOfPlaces);

                Command.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";

                ucitajSaleUgridView();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int row = Int16.Parse( textBox3.Text);
            int number = Int16.Parse(textBox4.Text);
            DataGridViewRow dataGridRow = this.dataGridView1.SelectedRows[0];
            int roomId = (int)dataGridRow.Cells["Id"].Value;

            if (row <= 0 || number <= 0) MessageBox.Show("Morate ispravno unijeti podatke!");

            else
            {
                SqlCeConnection Connection = DBConnection.Instance.Connection;
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Seats([Row], Number, RoomsId) VALUES(@Row, @Number, @RoomsId)", Connection);

                Command.Parameters.AddWithValue("@Row", row);
                Command.Parameters.AddWithValue("@Number", number);
                Command.Parameters.AddWithValue("@RoomsId", roomId);

                Command.ExecuteNonQuery();
                textBox3.Text = "";
                textBox4.Text = "";

                ucitajMjestaUGridView(roomId);
            }
        }
    }
}
