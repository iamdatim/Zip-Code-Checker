using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.WriteOrReadJson
{
    public class WriteToJson
    {
        public void CustomerWriteToJsons(List<Customer> Customers)
        {

            string fullPath = GettingPath.GetPath("Customer.json");
            string jsonString = JsonSerializer.Serialize(Customers);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }
        }

        public void SupplierWriteToJsons(List<Supplier> Suppliers)
        {

            string fullPath = GettingPath.GetPath("Supplier.json");
            string jsonString = JsonSerializer.Serialize(Suppliers);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }
          
        }

        public void EmployeeWriteToJsons(List<Employee> Employees)
        {

            string fullPath = GettingPath.GetPath("Employees.json");
            string jsonString = JsonSerializer.Serialize(Employees);
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(jsonString);
            }
           
        }
    }
}
