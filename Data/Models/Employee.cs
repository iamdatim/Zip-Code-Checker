using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Employee : User
    {
        public DateTime DateOfBirth { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }
        public List<ContactDetails> EmployeeContactDetails { get; set; } = new List<ContactDetails>();
    }
}
