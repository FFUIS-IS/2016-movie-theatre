using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Tickets
    {
        public int Id { get; set; }
        public int SeatsId { get; set; }
        public int ProjectionsId { get; set; }
        public string ProjectionsName { get; set; }
        public int EmployersId { get; set; }
        public int EmployersName { get; set; }
    }
}
