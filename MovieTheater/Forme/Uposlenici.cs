using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
