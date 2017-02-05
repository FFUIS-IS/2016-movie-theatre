using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Rooms
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Rooms (int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
    
}
