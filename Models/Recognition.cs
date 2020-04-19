using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject_Team9.Models
{
    public class Recognition
    {
        public int recognitionID { get; set; }
        public string recognitionTitle { get; set; }
        public string recognitionExplanation { get; set; }

        public ICollection<EmployeeRecognition> OrderDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int employeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}