using System;
using System.Collections;
using System.Collections.Generic;

namespace CrudDotNetCore.Models
{
    public class EmployeeViewModel
    {
        public Employee Employee { get; set; }

        public IList<Department> Departments { get; set; }
    }
}