using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Projections
    {
      
        

        public int Id { get; set; }
        public string Film { get; set; }
        public string Room { get; set; }
        public string Time_of_projection { get; set; }
        public float Price { get; set; }

        public Projections(int v1, string v2, string v3, string v4, float v5)
        {
            this.Id = v1;
            this.Film = v2;
            this.Room = v3;
            this.Time_of_projection = v4;
            this.Price = v5;
        }

    }
}
