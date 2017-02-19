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
    public partial class ListaProdaje : Form
    {
        private SefPocetna sefPocetna;

        public ListaProdaje()
        {
            InitializeComponent();
        }

        public ListaProdaje(SefPocetna sefPocetna)
        {
            this.sefPocetna = sefPocetna;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sefPocetna.Show();
            this.Close();
        }

        private void ListaProdaje_Load(object sender, EventArgs e)
        {
            ucitajProdaju();
        }

        private void ucitajProdaju()
        {
            string query = "@select t.Id, f.Name filmName, s.[Row], s.Number, e.userName, t.dateOfSale from tickets t, seats s, projections p, employers e, films f WHERE t.SeatsId = s.Id AND t.ProjectionsId = p.Id AND t.EmployersId = e.Id AND p.FilmsId = f.Id";
            SqlCeConnection Connection = DBConnection.Instance.Connection;
            SqlCeCommand Command = new SqlCeCommand(@"select t.Id, f.Name filmName, s.[Row], s.Number, e.userName, t.dateOfSale from tickets t, seats s, projections p, employers e, films f WHERE t.SeatsId = s.Id AND t.ProjectionsId = p.Id AND t.EmployersId = e.Id AND p.FilmsId = f.Id", Connection);
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
            List<Tickets2> list = new List<Tickets2>();
            while (Reader.Read())
            {
                list.Add(new Tickets2((int)Reader["Id"], Reader["filmName"].ToString(), (int)Reader["Row"] + " " + (int)Reader["Number"], Reader["userName"].ToString(), (DateTime)Reader["dateOfSale"]));

            }

            var bindingList = new BindingList<Tickets2>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
