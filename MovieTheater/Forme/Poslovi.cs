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
    public partial class Poslovi : Form
    {
        private SefPocetna sefPocetna;

        public Poslovi()
        {
            InitializeComponent();
        }

        public Poslovi(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sefPocetna.Show();
            this.Close();
        }

        private void Poslovi_Load(object sender, EventArgs e)
        {
            ucitajPosloveUgridView();
        }

        private void ucitajPosloveUgridView()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Jobs", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Jobs> list = new List<Jobs>();

            while (Reader.Read())
            {
                list.Add(new Jobs((int)Reader["Id"], Reader["Name"].ToString(), Reader["Description"].ToString()));

            }

            var bindingList = new BindingList<Jobs>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string description = textBox2.Text;

            if (name == "" || description == "") MessageBox.Show("Morate ispravno unijeti podatke!");

            else
            {
                SqlCeConnection Connection = DBConnection.Instance.Connection;
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Jobs(Name, Description) VALUES(@name, @description)", Connection);

                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@description", description);

                Command.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";

                ucitajPosloveUgridView();
            }
        }
    }

}
