﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TSMS.Models
{
    public class Teacher
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int DepartmentID { get; set; }

        public Department Department { get; set; }
    }
}