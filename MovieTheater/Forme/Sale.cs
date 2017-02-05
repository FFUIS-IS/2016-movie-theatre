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
    }
}
