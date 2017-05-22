using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TSMS.Models;

namespace TSMS.ViewModels
{
    public class TeacherIndexViewModel
    {
        TeacherContext db = new TeacherContext();
        public Teacher Teacher { get; set; }

        private string _Department;
        public string Department
        {
            get
            {
                return _Department;
            }
            set
            {
                int val = int.Parse(value);
                _Department = (from d in db.Departments
                              where d.ID == val
                              select d.Name).First().ToString();
            }
        }
    }
}