﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DEMOCRUD.Models
{
    public class Employee
    {
        public int Sr_no { get; set; } = 0;
        public string Emp_name { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string Country { get; set; } = "";
        public string Department { get; set; } = "";
        public string flag { get; set; } = "";
    }
}
