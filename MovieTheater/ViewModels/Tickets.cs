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
        public string EmployersName { get; set; }
        public DateTime datumIvrijeme { get; set; }

        public Tickets(int Id, int seatsId, int projectionsId, string projectionsName, int employersId, string employersName, DateTime datumIvrijeme)
        {
            this.Id = Id;
            this.SeatsId = seatsId;
            this.ProjectionsId = projectionsId;
            this.ProjectionsName = projectionsName;
            this.EmployersId = employersId;
            this.EmployersName = employersName;
            this.datumIvrijeme = datumIvrijeme;
        }
    }
}
