using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Distributors
    {
       

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Distributors(int v1, string v2, string v3, string v4)
        {
            this.Id = v1;
            this.Name = v2;
            this.Phone = v3;
            this.Address = v4;
        }

    }
}
