using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class EmployeeDetail
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int? Salary { get; set; }
    }
}
