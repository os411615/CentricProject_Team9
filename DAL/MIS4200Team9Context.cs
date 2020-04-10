using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CentricProject_Team9.Models; // This is needed to access the models
using System.Data.Entity;

namespace CentricProject_Team9.DAL
{
    public class MIS4200Team9Context : DbContext
    {
        public MIS4200Team9Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Recognition> Recognitions { get; set; }
        public DbSet<EmployeeRecognition> EmployeeRecognitions { get; set; }

        private MIS4200Team9Context db = new MIS4200Team9Context();
        // GET: Users
       
    }
}