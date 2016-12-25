using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class HomePage : Form
    {
        string home = Directory.GetCurrentDirectory().ToString();
        public string GetHomeDirectory()
        {
            return home;
        }
        public HomePage()
        {
            InitializeComponent();
            SqlCeConnection Connection = DBConnection.Instance.Connection;
        }
    }
}
