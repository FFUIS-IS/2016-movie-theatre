using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Tickets2
    {
        public int Id { get; set; }
        public string filmName { get; set; }
        public string seat { get; set; }
        public string employeeUserName { get; set; }
        public DateTime dateOfSale { get; set; }

        public Tickets2(int Id, string filmName, string seat, string employeeUserName, DateTime dateOfSale)
        {
            this.Id = Id;
            this.filmName = filmName;
            this.seat = seat;
            this.employeeUserName = employeeUserName;
            this.dateOfSale = dateOfSale;
        }
    }
}
