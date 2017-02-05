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
    public partial class Zanrovi : Form
    {
        private SefPocetna sefPocetna;
        public Zanrovi(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sefPocetna.Show();
            this.Close();
        }

        private void Zanrovi_Load(object sender, EventArgs e)
        {
            ucitajZanroveUgridView();
        }

        private void ucitajZanroveUgridView()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Types", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Types> list = new List<Types>();

            while (Reader.Read())
            {
                list.Add(new Types((int)Reader["Id"], Reader["Name"].ToString(), Reader["Description"].ToString()));

            }

            var bindingList = new BindingList<Types>(list);
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
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Types(Name, Description) VALUES(@name, @description)", Connection);

                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@description", description);
                
                Command.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";

                ucitajZanroveUgridView();

            }
        }
    }
}
