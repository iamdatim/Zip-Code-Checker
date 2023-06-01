using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Supplier : User
    {
        public bool IsActive { get; set; }
        public List<ContactDetails> SupplierContactDetails { get; set; } = new List<ContactDetails>();
    }
}
