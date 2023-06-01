using Data.Models;
using Data.WriteOrReadJson;

namespace Services
{
    public class Register
    {
        public Customer Registration(List<Customer> Customers, string firstname, string lastname, 
            string middlename, string username, string email, string password)
        {
            Customer newCustomer = new()
            { 
                FirstName = firstname, 
                LastName = lastname, 
                MiddleName = middlename,
                Email = email,
                Username = username,
                Password = password
            };

            Customers.Add(newCustomer);
            WriteToJson writeToJson = new WriteToJson();
            writeToJson.CustomerWriteToJsons(Customers);
            return newCustomer;
        }

        public Employee Registration(List<Employee> Employees, string firstname, string lastname, 
            string middlename, string username, string email, string password)
        {
            Employee newEmployee = new()
            {
                FirstName = firstname,
                LastName = lastname,
                MiddleName = middlename,
                Username = username,
                Email = email,
                Password = password
            };
            Employees.Add(newEmployee);
            WriteToJson writeToJson = new WriteToJson();
            writeToJson.EmployeeWriteToJsons(Employees);
            return newEmployee;
        }

        public Supplier Registration(List<Supplier> Suppliers, string firstname, string lastname,
            string middlename, string username, string email, string password)
        {
            Supplier newSupplier = new()
            {
                FirstName = firstname,
                LastName = lastname,
                MiddleName = middlename,
                Username = username,
                Email = email,
                Password = password
            };
            Suppliers.Add(newSupplier);
            WriteToJson writeToJson = new WriteToJson();
            writeToJson.SupplierWriteToJsons(Suppliers);
            return newSupplier;
        }
    }
}