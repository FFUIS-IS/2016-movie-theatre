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
        public int DistributorsId { get; set; }
        public string DistributorsName { get; set; }

        public Film(int Id, string Name, int Duration, bool isShowing, int DistributorsId, string DistributorsName)
        {
            this.Id = Id;
            this.Name = Name;
            this.Duration = Duration;
            this.isShowing = isShowing;
            this.DistributorsId = DistributorsId;
            this.DistributorsName = DistributorsName;
        }

        public Film(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
