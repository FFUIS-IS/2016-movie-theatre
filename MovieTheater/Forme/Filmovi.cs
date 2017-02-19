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
    public partial class Filmovi : Form
    {
        private SefPocetna sefPocetna;
        public Filmovi(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void Filmovi_Load(object sender, EventArgs e)
        {
            ucitajFilmoveUgridView();
            ucitajDistributereUcombobox();
            ucitajZanroveUcombobox();
        }

        private void ucitajDistributereUcombobox()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Distributors", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Distributors> list = new List<Distributors>();

            while (Reader.Read())
            {
                list.Add(new Distributors((int)Reader["Id"], Reader["Name"].ToString(), Reader["Phone"].ToString(), Reader["Address"].ToString()));
            }

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void ucitajZanroveUcombobox()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Types", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Types> list = new List<Types>();

            while (Reader.Read())
            {
                list.Add(new Types((int)Reader["Id"], Reader["Name"].ToString(), Reader["Description"].ToString()));
            }

            comboBox2.DataSource = list;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
        }

        private void ucitajFilmoveUgridView()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT f.Id, f.Name, f.Duration, f.isShowing, d.Name DistributorsName, t.Name TypesName FROM Films f, Distributors d, Types t WHERE f.DistibutorsId = d.Id and f.TypesId = t.Id", Connection);
            SqlCeDataReader Reader = null;
            try
            {
                 Reader = Command.ExecuteReader();

                
            }
            catch(Exception e)
            {
                MessageBox.Show("Greska sa bazom");
                return;
            }
            List<Film> list = new List<Film>();
            while (Reader.Read())
            {
                list.Add(new Film((int)Reader["Id"], Reader["Name"].ToString(), (int)Reader["Duration"],(bool) Reader["isShowing"], Reader["DistributorsName"].ToString(), Reader["TypesName"].ToString()));

            }

            var bindingList = new BindingList<Film>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int duration = Int32.Parse(textBox2.Text);
            bool isShowing = checkBox1.Checked;
            int distributorsId = (int)comboBox1.SelectedValue;
            int typesId = (int)comboBox2.SelectedValue;

            if (name == "" || duration == 0) MessageBox.Show("Morate unijeti podatke o distributeru!");

            else
            {
                SqlCeConnection Connection = DBConnection.Instance.Connection;
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Films(Name, Duration, isShowing, DistibutorsId, TypesId) VALUES(@name, @duration, @isShowing, @distributorsId, @typesId)", Connection);

                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@duration", duration);
                Command.Parameters.AddWithValue("@isShowing", isShowing);
                Command.Parameters.AddWithValue("@distributorsId", distributorsId);
                Command.Parameters.AddWithValue("@typesId", typesId);

                Command.ExecuteNonQuery();

                textBox1.Text = "";
                textBox2.Text = "";
                checkBox1.Checked = false;

                ucitajFilmoveUgridView();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sefPocetna.Show();
            this.Close();
        }
    }
}
