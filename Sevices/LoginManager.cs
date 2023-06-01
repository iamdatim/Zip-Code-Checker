using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginManager
    {
        public Customer Login(List<Customer> Customers, string email, string password)
        {
            foreach (Customer customer in Customers)
            {
                if (customer.Email == email && customer.Password == password)
                {
                    return customer;
                }

                else
                {
                    return null;
                }
            }

            return Customers.FirstOrDefault(c => c.Email == email && c.Password == password);
        }

        public Employee Login(List<Employee> Employees, string email, string password)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.Email == email && employee.Password == password)
                {
                    return employee;
                }

                else
                {
                    return null;
                }
            }

            return Employees.FirstOrDefault(e => e.Email == email && e.Password == password);
        }

        public Supplier Login(List<Supplier> Suppliers, string email, string password)
        {
            foreach (Supplier supplier in Suppliers)
            {
                if (supplier.Email == email && supplier.Password == password)
                {
                    return supplier;
                }

                else
                {
                    return null;
                }
            }

            return Suppliers.FirstOrDefault(s => s.Email == email && s.Password == password);
        }
    }
}
