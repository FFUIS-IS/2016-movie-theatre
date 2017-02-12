using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Seats
    {
        public Seats(int Id, int Row, int Number, int RoomsId)
        {
            this.Id = Id;
            this.Row = Row;
            this.Number = Number;
            this.RoomsId = RoomsId;
        }

        public int Id { get; set; }
        public int Row { get; set; }
        public int Number { get; set; }
        public int RoomsId { get; set; }
        public string RoomsName { get; set; }

        public string seatsName
        {
            get
            {
                return "Row: " + Row + ", Number: " + Number;
            }
        }
    }
}
