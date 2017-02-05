using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Jobs
    {
        public int jobId { get; set; }
        public string jobName { get; set; }
        public string jobDescription { get; set; }

        public Jobs(int jobId, string jobName)
        {
            this.jobId = jobId;
            this.jobName = jobName;
        }

        public Jobs(int id, string name, string description)
        {
            this.jobId = id;
            this.jobName = name;
            this.jobDescription = description;
        }

    }
}
