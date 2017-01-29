using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Jobs
    {
        private int v;

        public int jobId { get; set; }
        public string jobName { get; set; }

        public Jobs(int jobId, string jobName)
        {
            this.jobId = jobId;
            this.jobName = jobName;
        }

    }
}
