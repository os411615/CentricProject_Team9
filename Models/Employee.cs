using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject_Team9.Models
{
    public class Employee
    {
        public int employeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime employeeSince { get; set; }

        public ICollection<Recognition> Recognition { get; set; }
    }
}