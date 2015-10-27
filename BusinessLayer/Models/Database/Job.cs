using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models.Database {
    public class Job {
        public int JobId { get; set; }
        public string Name { get; set; }
        public bool Applicant { get; set; }
    }
}
