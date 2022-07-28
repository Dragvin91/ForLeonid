using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLeonid.Models
{
    class TaskForProject
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime DeadLine { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
