using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace TSMS.Models
{
    public class TeacherContext : DbContext
    {
        public TeacherContext()
            : base("TSMS")
        {

        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}