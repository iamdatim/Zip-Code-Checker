using Data.Models;
using Data.WriteOrReadJson;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class RegistrationPage
    {
        public static void CustomerRegistration(List<Customer> Customers)
        {
            Customer newCustomer = new();

            Header.HeaderDisplay("Customer Registration Page");
            Console.WriteLine("Enter your First Name");
            string firstname = Console.ReadLine();
            int firstnamevalue;
            while (Validation.EmptyString(firstname) || !Validation.TryParseInt(firstname, out firstnamevalue))
            {
                if (Validation.EmptyString(firstname))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    firstname = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    firstname = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Customer Registration Page");
            Console.WriteLine("Enter your Last Name");
            string lastname = Console.ReadLine();
            int lastnamevalue;
            while (Validation.EmptyString(lastname) || !Validation.TryParseInt(lastname, out lastnamevalue))
            {
                if (Validation.EmptyString(lastname))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    lastname = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    lastname = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Customer Registration Page");
            Console.WriteLine("Enter your Middle Name");
            string middlename = Console.ReadLine();
            int middlenamevalue;
            while (Validation.EmptyString(middlename) || !Validation.TryParseInt(middlename, out middlenamevalue))
            {
                if (Validation.EmptyString(middlename))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    middlename = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    middlename = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Customer Registration Page");
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            while (Validation.EmptyString(email) || !Validation.IsValidEmail(email) || Customers.Exists(x => x.Email == email))
            {
                if (Validation.EmptyString(email))
                {
                    MenuMessage.DisplayErrorMessage("email Shouldn't not be empty", "Please enter a valid email:");
                    email = Console.ReadLine();
                }

                else if (!Validation.IsValidEmail(email))
                {
                    MenuMessage.DisplayErrorMessage("Not a valid email format", "Please enter a valid email:");
                    email = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Email Already Exist", "Please enter another username:");
                    email = Console.ReadLine();
                }
            }

            Header.HeaderDisplay("Customer Registration Page");
            Console.WriteLine("Enter your Username");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value) || Customers.Exists(x => x.Username == username))
            {
                if (Validation.EmptyString(username))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(username, out value))
                {
                    //.HeaderDisplay("Registration Page");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Username Already Exist", "Please enter another username:");
                    username = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Customer Registration Page");
            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password) || !Validation.IsValidPassword(password))
            {
                if (Validation.EmptyString(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                    password = Console.ReadLine();
                }

                else if (!Validation.IsValidPassword(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Requiremnet not met, Your Password must contain \nat least 1 Uppercase, Lowercase and Number", "Please enter a valid password:");
                    password = Console.ReadLine();
                }
            }


            Register newregistration = new();
            Customer newCus = newregistration.Registration(Customers, firstname, lastname, middlename, email, username, password);


            MenuMessage.DisplaySucessMessage("Registration Sucessful");
        }

        public static void EmployeeRegistration(List<Employee> Employees)
        {
            Employee newEmployee = new();

            Header.HeaderDisplay("Employee Registration Page");
            Console.WriteLine("Enter your First Name");
            string firstname = Console.ReadLine();
            int firstnamevalue;
            while (Validation.EmptyString(firstname) || !Validation.TryParseInt(firstname, out firstnamevalue))
            {
                if (Validation.EmptyString(firstname))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    firstname = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    firstname = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Employee Registration Page");
            Console.WriteLine("Enter your Last Name");
            string lastname = Console.ReadLine();
            int lastnamevalue;
            while (Validation.EmptyString(lastname) || !Validation.TryParseInt(lastname, out lastnamevalue))
            {
                if (Validation.EmptyString(lastname))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    lastname = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    lastname = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Employee Registration Page");
            Console.WriteLine("Enter your Middle Name");
            string middlename = Console.ReadLine();
            int middlenamevalue;
            while (Validation.EmptyString(middlename) || !Validation.TryParseInt(middlename, out middlenamevalue))
            {
                if (Validation.EmptyString(middlename))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    middlename = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    middlename = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Employee Registration Page");
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            while (Validation.EmptyString(email) || !Validation.IsValidEmail(email) || Employees.Exists(x => x.Email == email))
            {
                if (Validation.EmptyString(email))
                {
                    MenuMessage.DisplayErrorMessage("email Shouldn't not be empty", "Please enter a valid email:");
                    email = Console.ReadLine();
                }

                else if (!Validation.IsValidEmail(email))
                {
                    MenuMessage.DisplayErrorMessage("Not a valid email format", "Please enter a valid email:");
                    email = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Email Already Exist", "Please enter another username:");
                    email = Console.ReadLine();
                }
            }

            Header.HeaderDisplay("Employee Registration Page");
            Console.WriteLine("Enter your Username");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value) || Employees.Exists(x => x.Username == username))
            {
                if (Validation.EmptyString(username))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(username, out value))
                {
                    //.HeaderDisplay("Registration Page");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Username Already Exist", "Please enter another username:");
                    username = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Employee Registration Page");
            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password) || !Validation.IsValidPassword(password))
            {
                if (Validation.EmptyString(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                    password = Console.ReadLine();
                }

                else if (!Validation.IsValidPassword(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Requiremnet not met, Your Password must contain \nat least 1 Uppercase, Lowercase and Number", "Please enter a valid password:");
                    password = Console.ReadLine();
                }
            }


            Register newregistration = new();
            Employee newemployee = newregistration.Registration(Employees, firstname, lastname, middlename, email, username, password);
            MenuMessage.DisplaySucessMessage("Registration Sucessful");
        }

        public static void SupplierRegistration(List<Supplier> Suppliers)
        {
            Supplier supplier = new();

            Header.HeaderDisplay("Supplier Registration Page");
            Console.WriteLine("Enter your First Name");
            string firstname = Console.ReadLine();
            int firstnamevalue;
            while (Validation.EmptyString(firstname) || !Validation.TryParseInt(firstname, out firstnamevalue))
            {
                if (Validation.EmptyString(firstname))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    firstname = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    firstname = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Supplier Registration Page");
            Console.WriteLine("Enter your Last Name");
            string lastname = Console.ReadLine();
            int lastnamevalue;
            while (Validation.EmptyString(lastname) || !Validation.TryParseInt(lastname, out lastnamevalue))
            {
                if (Validation.EmptyString(lastname))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    lastname = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    lastname = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Supplier Registration Page");
            Console.WriteLine("Enter your Middle Name");
            string middlename = Console.ReadLine();
            int middlenamevalue;
            while (Validation.EmptyString(middlename) || !Validation.TryParseInt(middlename, out middlenamevalue))
            {
                if (Validation.EmptyString(middlename))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid Full Name:");
                    middlename = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    middlename = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Supplier Registration Page");
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            while (Validation.EmptyString(email) || !Validation.IsValidEmail(email) || Suppliers.Exists(x => x.Email == email))
            {
                if (Validation.EmptyString(email))
                {
                    MenuMessage.DisplayErrorMessage("email Shouldn't not be empty", "Please enter a valid email:");
                    email = Console.ReadLine();
                }

                else if (!Validation.IsValidEmail(email))
                {
                    MenuMessage.DisplayErrorMessage("Not a valid email format", "Please enter a valid email:");
                    email = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Email Already Exist", "Please enter another username:");
                    email = Console.ReadLine();
                }
            }

            Header.HeaderDisplay("Supplier Registration Page");
            Console.WriteLine("Enter your Username");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value) || Suppliers.Exists(x => x.Username == username))
            {
                if (Validation.EmptyString(username))
                {
                    //Header.HeaderDisplay();
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(username, out value))
                {
                    //.HeaderDisplay("Registration Page");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else
                {
                    MenuMessage.DisplayErrorMessage("Username Already Exist", "Please enter another username:");
                    username = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Supplier Registration Page");
            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password) || !Validation.IsValidPassword(password))
            {
                if (Validation.EmptyString(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                    password = Console.ReadLine();
                }

                else if (!Validation.IsValidPassword(password))
                {
                    MenuMessage.DisplayErrorMessage("Password Requiremnet not met, Your Password must contain \nat least 1 Uppercase, Lowercase and Number", "Please enter a valid password:");
                    password = Console.ReadLine();
                }
            }


            Register newregistration = new();
            Supplier NEWSupplier = newregistration.Registration(Suppliers, firstname, lastname, middlename, email, username, password);
            MenuMessage.DisplaySucessMessage("Registration Sucessful");
        }

        public static void AddAdmin()
        {
            Admin newAdmin = new();
            
        }
    }
}
