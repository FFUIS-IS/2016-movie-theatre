using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class EmployersJobs
    {
        public int Id { get; set; }
        public int EmployersId { get; set; }
        public string EmployersUserName { get; set; }
        public int JobsId { get; set; }
        public string JobsName { get; set; }

        public EmployersJobs(int Id, int EmployersId, string EmployersUserName, int JobsId, string JobsName)
        {
            this.Id = Id;
            this.EmployersId = EmployersId;
            this.EmployersUserName = EmployersUserName;
            this.JobsId = JobsId;
            this.JobsName = JobsName;
        }
    }
}
