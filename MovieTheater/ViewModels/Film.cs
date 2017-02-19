using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public bool isShowing { get; set; }
        public string DistributorsName { get; set; }
        public string TypesName { get; set; }

        public Film(int Id, string Name, int Duration, bool isShowing, string DistributorsName, string TypesName)
        {
            this.Id = Id;
            this.Name = Name;
            this.Duration = Duration;
            this.isShowing = isShowing;
            this.DistributorsName = DistributorsName;
            this.TypesName = TypesName;
        }

        public Film(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
