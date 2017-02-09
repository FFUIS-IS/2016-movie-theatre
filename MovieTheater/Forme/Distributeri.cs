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
    public partial class Distributeri : Form
    {
        private SefPocetna sefPocetna;
        
        public Distributeri(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Distributeri_Load(object sender, EventArgs e)
        {
            ucitajDistributereUgridView();
        }

        private void ucitajDistributereUgridView()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Distributors", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Distributors> list = new List<Distributors>();

            while (Reader.Read())
            {
                list.Add(new Distributors((int)Reader["Id"], Reader["Name"].ToString(), Reader["Phone"].ToString(), Reader["Address"].ToString()));

            }

            var bindingList = new BindingList<Distributors>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            string address = textBox3.Text;

            if (name == "" || phone == "" || address == "") MessageBox.Show("Morate unijeti podatke o distributeru!");

            else
            {
                SqlCeConnection Connection = DBConnection.Instance.Connection;
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Distributors(Name, Phone, Address) VALUES(@name, @phone, @address)", Connection);
               
                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@phone", phone);
                Command.Parameters.AddWithValue("@address", address);

                Command.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

                ucitajDistributereUgridView();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sefPocetna.Show();
            this.Close();

        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Odaberite jedan slog!");
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int value = (int) row.Cells[0].Value;

            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"DELETE FROM Distributors WHERE Id = @Id", Connection);

            Command.Parameters.AddWithValue("@Id", value);

            Command.ExecuteNonQuery();

            ucitajDistributereUgridView();

        }
    }
}
