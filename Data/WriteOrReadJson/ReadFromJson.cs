using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.WriteOrReadJson
{
    public class ReadFromJson
    {
        public List<Customer> ReadFromJsons(string fullPath)
        {
            fullPath = GettingPath.GetPath("Customer.json");
            string jsonContent = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<List<Customer>>(jsonContent);
        }

        public List<Supplier> SupplierReadFromJsons(string fullPath)
        {
            fullPath = GettingPath.GetPath("Supplier.json");
            string jsonContent = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<List<Supplier>>(jsonContent);
        }

        public List<Employee> EmployeeReadFromJsons(string fullPath)
        {
            fullPath = GettingPath.GetPath("Employees.json");
            string jsonContent = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<List<Employee>>(jsonContent);
        }
    }
}
