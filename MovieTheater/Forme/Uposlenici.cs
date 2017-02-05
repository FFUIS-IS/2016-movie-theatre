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
    public partial class Uposlenici : Form
    {
        private SefPocetna sefPocetna;

        public Uposlenici()
        {
            InitializeComponent();
        }

        public Uposlenici(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sefPocetna.Show();
            this.Close();
        }

        private void Uposlenici_Load(object sender, EventArgs e)
        {
            ucitajUposlenikeUgridView();
            ucitajVezeUposlenikPosaouGridview();
            ucitajPodatkeUcombobox();
        }

        private void ucitajPodatkeUcombobox()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Employers", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Employers> list = new List<Employers>();

            while (Reader.Read())
            {
                list.Add(new Employers((int)Reader["Id"], Reader["userName"].ToString(), Reader["userPassword"].ToString(), Reader["firstName"].ToString(), Reader["lastName"].ToString(), (DateTime)Reader["birthDate"], Reader["phone"].ToString(), Reader["address"].ToString()));

            }

            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "userName";
            comboBox1.ValueMember = "Id";

            Command = new SqlCeCommand(@"SELECT * FROM Jobs", Connection);
            Reader = Command.ExecuteReader();

            List<Jobs> list2 = new List<Jobs>();

            while (Reader.Read())
            {
                list2.Add(new Jobs((int)Reader["Id"], Reader["Name"].ToString(), Reader["Description"].ToString()));

            }
            comboBox2.DataSource = list2;
            comboBox2.DisplayMember = "jobName";
            comboBox2.ValueMember = "jobId";

        }

        private void ucitajUposlenikeUgridView()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT * FROM Employers", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<Employers> list = new List<Employers>();

            while (Reader.Read())
            {
                list.Add(new Employers((int)Reader["Id"], Reader["userName"].ToString(), Reader["userPassword"].ToString(), Reader["firstName"].ToString(), Reader["lastName"].ToString(), (DateTime)Reader["birthDate"], Reader["phone"].ToString(), Reader["address"].ToString()));

            }

            var bindingList = new BindingList<Employers>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }


        private void ucitajVezeUposlenikPosaouGridview()
        {
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"SELECT ej.Id, ej.Employers_id EmployersId, e.userName EmployersUserName, ej.Jobs_id JobsId, j.Name JobsName FROM Employers_Jobs ej, Employers e, Jobs j WHERE ej.Employers_id = e.Id AND ej.Jobs_Id = j.Id", Connection);
            SqlCeDataReader Reader = Command.ExecuteReader();

            List<EmployersJobs> list = new List<EmployersJobs>();

            while (Reader.Read())
            {
                list.Add(new EmployersJobs((int)Reader["Id"], (int)Reader["EmployersId"] , Reader["EmployersUserName"].ToString(),(int)Reader["JobsId"] ,Reader["JobsName"].ToString()));

            }

            var bindingList = new BindingList<EmployersJobs>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView2.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string userpassword = textBox2.Text;
            string firstname = textBox3.Text;
            string lastname = textBox4.Text;
            string birthdate = dateTimePicker1.Text;
            string phone = textBox5.Text;
            string address = textBox6.Text;

            if (username == "" || userpassword == "" || firstname == "" || lastname == "" || birthdate == "" || phone == "" || address == "") MessageBox.Show("Morate ispravno unijeti podatke!");

            else
            {
                SqlCeConnection Connection = DBConnection.Instance.Connection;
                SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Employers(userName, userPassword, firstName, lastName, birthDate, phone, address) VALUES(@userName, @userPassword, @firstName, @lastName, @birthDate, @phone, @address)", Connection);

                Command.Parameters.AddWithValue("@userName", username);
                Command.Parameters.AddWithValue("@userPassword", userpassword);
                Command.Parameters.AddWithValue("@firstName", firstname);
                Command.Parameters.AddWithValue("@lastName", lastname);
                Command.Parameters.AddWithValue("@birthDate", birthdate);
                Command.Parameters.AddWithValue("@phone", phone);
                Command.Parameters.AddWithValue("@address", address);


                Command.ExecuteNonQuery();
                textBox1.Text = "";
                textBox2.Text = "";

                ucitajUposlenikeUgridView();
                ucitajPodatkeUcombobox();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int employersId = (int) comboBox1.SelectedValue;
            int jobsId = (int) comboBox2.SelectedValue;
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"INSERT INTO Employers_Jobs(Employers_id, Jobs_id) VALUES(@employersId, @jobsId)", Connection);

            Command.Parameters.AddWithValue("@employersId", employersId);
            Command.Parameters.AddWithValue("@jobsId", jobsId);
            
            Command.ExecuteNonQuery();

            ucitajVezeUposlenikPosaouGridview();
        }
    }
}
