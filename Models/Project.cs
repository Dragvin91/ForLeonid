using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLeonid.Models
{
    class Project
    {
        public string Name { get; set; }
        public string SmallName { get; set; }
        public DateTime Start { get; set; }
        public DateTime DeadLine { get; set; }
        public List<TaskForProject> Tasks { get; set; }
    }
}
