using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentricProject_Team9.Models
{
    public class EmployeeRecognition
    {
        public int employeerecognitionID { get; set; }
        //public int qtyOrdered { get; set; }
        //public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int employeeID { get; set; }
        public virtual Employee Employee { get; set; }
        // the next two properties link the orderDetail to the Product
        public int recognitionID { get; set; }
        public virtual Recognition Recognition { get; set; }
    }
}