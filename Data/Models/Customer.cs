using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Customer : User
    {
        public bool IsActive { get; set; }
        public List<ContactDetails> CustomerContactDetails { get; set; } = new List<ContactDetails>();
        
    }
}
