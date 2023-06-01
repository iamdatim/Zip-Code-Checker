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
    internal class LoginPage
    {
        private LoginManager loginManager = new LoginManager();
        public void CustomerLogin(List<Customer> Customers)
        {
            Header.HeaderDisplay("Customer Login Page");

            MenuMessage.DisplayActionMessage("Please enter your username: ");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value))
            {
                if (Validation.EmptyString(username))
                {
                    Header.HeaderDisplay("To do List Application");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(username, out value))
                {
                    Header.HeaderDisplay("To do List Application");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    username = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Customer Login Page");
            MenuMessage.DisplayActionMessage("Please enter your Password: ");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password))
            {

                MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                password = Console.ReadLine();

            }

            // User currentUser = users.FirstOrDefault(x => x.Username == loginUsername && x.Password == loginPassword);
           /// Customer currentCustomer = loginManager.Login(Customers, username, password);
            ReadFromJson readFromJson = new ReadFromJson();
            List<Customer> result = readFromJson.ReadFromJsons("Customer.json");

            Customer currentCustomer = result.FirstOrDefault(x => x.Password == password && x.Username == username);

            // Header.HeaderDisplay("Login Page");
            if (currentCustomer != null)
            {
                Animation.LoginLoading();
                Header.HeaderDisplay("Customer Page");

                bool isChoice = true;
                while (isChoice)
                {
                    // Header.HeaderDisplay("Datim Bank Plc");
                    MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Profile\n2. Logout\n \nYour Option: \n");

                    string choice = Console.ReadLine();
                    Console.Clear();

                    int type;
                    while (Validation.TryParseInt(choice, out type))
                    {
                        Header.HeaderDisplay("Store Management System");
                        MenuMessage.DisplayErrorMessage($"{choice} is an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");

                        MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Profile\n2. Logout\n \nYour Option: \n");
                        choice = Console.ReadLine();
                    }


                    // Console.Clear();

                    switch (choice)
                    {

                        case "1":
                            Console.Clear();
                            //ViewYourProfile(registeredUsers);
                            Header.HeaderDisplay("Your Profile");
                            Console.WriteLine($"First Name: \t{currentCustomer.FirstName}");
                            Console.WriteLine($"Last Name: \t {currentCustomer.LastName}");
                            Console.WriteLine($"Middle Name: \t {currentCustomer.MiddleName}");
                            Console.WriteLine($"Email Address: \t {currentCustomer.Email}");
                            Console.WriteLine($"Username: \t {currentCustomer.Username}");
                            Console.WriteLine(new string(Header.headerLine, Header.headerLineWidth));
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.Clear();
                            isChoice = false;
                            Console.WriteLine();
                            Console.WriteLine("You've Logged out successfully.");
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;

                            //default:
                            //    Header.HeaderDisplay("To do List Application");
                            //    Console.ForegroundColor = ConsoleColor.Red;
                            //    Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                            //    Console.ResetColor();
                            //    break;
                    }
                }


            }

            else
            {
                MenuMessage.DisplayErrorMessage("User Does not exist", "Kindly register an account to be able to login");
            }


        }

        public void EmployeeLogin(List<Employee> Employees)
        {
            Header.HeaderDisplay("Employee Login Page");

            MenuMessage.DisplayActionMessage("Please enter your username: ");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value))
            {
                if (Validation.EmptyString(username))
                {
                    Header.HeaderDisplay("To do List Application");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(username, out value))
                {
                    Header.HeaderDisplay("To do List Application");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    username = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Employee Login Page");
            MenuMessage.DisplayActionMessage("Please enter your Password: ");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password))
            {

                MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                password = Console.ReadLine();

            }

            //Employee currentEmployee = loginManager.Login(Employees, username, password);
            ReadFromJson readFromJson = new ReadFromJson();
            List<Employee> result = readFromJson.EmployeeReadFromJsons("Employees.json");

            Employee currentEmployee = result.FirstOrDefault(x => x.Username == username && x.Password == password);

            // Header.HeaderDisplay("Login Page");
            if (currentEmployee != null)
            {
                Animation.LoginLoading();
                Header.HeaderDisplay("Employee Page");

                bool isChoice = true;
                while (isChoice)
                {
                    // Header.HeaderDisplay("Datim Bank Plc");
                    MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Profile\n2. Logout\n \nYour Option: \n");

                    string choice = Console.ReadLine();
                    Console.Clear();

                    int type;
                    while (Validation.TryParseInt(choice, out type))
                    {
                        Header.HeaderDisplay("Store Management System");
                        MenuMessage.DisplayErrorMessage($"{choice} is an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");

                        MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Profile\n2. Logout\n \nYour Option: \n");
                        choice = Console.ReadLine();
                    }


                    // Console.Clear();

                    switch (choice)
                    {

                        case "1":
                            Console.Clear();
                            //ViewYourProfile(registeredUsers);
                            Header.HeaderDisplay("Your Profile");
                            Console.WriteLine($"First Name: \t{currentEmployee.FirstName}");
                            Console.WriteLine($"Last Name: \t {currentEmployee.LastName}");
                            Console.WriteLine($"Middle Name: \t {currentEmployee.MiddleName}");
                            Console.WriteLine($"Email Address: \t {currentEmployee.Email}");
                            Console.WriteLine($"Username: \t {currentEmployee.Username}");
                            Console.WriteLine(new string(Header.headerLine, Header.headerLineWidth));
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.Clear();
                            isChoice = false;
                            Console.WriteLine();
                            Console.WriteLine("You've Logged out successfully.");
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;

                            //default:
                            //    Header.HeaderDisplay("To do List Application");
                            //    Console.ForegroundColor = ConsoleColor.Red;
                            //    Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                            //    Console.ResetColor();
                            //    break;
                    }
                }
            }

            else
            {
                MenuMessage.DisplayErrorMessage("User Does not exist", "Kindly register an account to be able to login");
            }


        }

        public void SuplierLogin(List<Supplier> Suppliers)
        {
            Header.HeaderDisplay("Supplier Login Page");

            MenuMessage.DisplayActionMessage("Please enter your username: ");
            string username = Console.ReadLine();
            int value;
            while (Validation.EmptyString(username) || !Validation.TryParseInt(username, out value))
            {
                if (Validation.EmptyString(username))
                {
                    Header.HeaderDisplay("To do List Application");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not be empty", "Please enter a valid username:");
                    username = Console.ReadLine();
                }

                else if (!Validation.TryParseInt(username, out value))
                {
                    Header.HeaderDisplay("To do List Application");
                    MenuMessage.DisplayErrorMessage("Name Shouldn't not contain number", "Please enter a valid username:");
                    username = Console.ReadLine();
                }
            }
            Console.Clear();

            Header.HeaderDisplay("Login Page");
            MenuMessage.DisplayActionMessage("Please enter your Password: ");
            string password = Console.ReadLine();
            while (Validation.EmptyString(password))
            {

                MenuMessage.DisplayErrorMessage("Password Shouldn't not be empty", "Please enter a valid password:");
                password = Console.ReadLine();

            }

            // User currentUser = users.FirstOrDefault(x => x.Username == loginUsername && x.Password == loginPassword);
            //Supplier currentSupplier = loginManager.Login(Suppliers, username, password);

            ReadFromJson readFromJson = new ReadFromJson();
            List<Supplier> result = readFromJson.SupplierReadFromJsons("Supplier.json");

            Supplier currentSupplier = result.FirstOrDefault(x => x.Username == username && x.Password == password);

            // Header.HeaderDisplay("Login Page");
            if (currentSupplier != null)
            {
                Animation.LoginLoading();
                Header.HeaderDisplay("Supplier Page");

                bool isChoice = true;
                while (isChoice)
                {
                    // Header.HeaderDisplay("Datim Bank Plc");
                    MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Profile\n2. Logout\n \nYour Option: \n");

                    string choice = Console.ReadLine();
                    Console.Clear();

                    int type;
                    while (Validation.TryParseInt(choice, out type))
                    {
                        Header.HeaderDisplay("Store Management System");
                        MenuMessage.DisplayErrorMessage($"{choice} is an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");

                        MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Profile\n2. Logout\n \nYour Option: \n");
                        choice = Console.ReadLine();
                    }


                    // Console.Clear();

                    switch (choice)
                    {

                        case "1":
                            Console.Clear();
                            //ViewYourProfile(registeredUsers);
                            Header.HeaderDisplay("Your Profile");
                            Console.WriteLine($"First Name: \t{currentSupplier.FirstName}");
                            Console.WriteLine($"Last Name: \t {currentSupplier.LastName}");
                            Console.WriteLine($"Middle Name: \t {currentSupplier.MiddleName}");
                            Console.WriteLine($"Email Address: \t {currentSupplier.Email}");
                            Console.WriteLine($"Username: \t {currentSupplier.Username}");
                            Console.WriteLine(new string(Header.headerLine, Header.headerLineWidth));
                            Console.WriteLine();
                            break;

                        case "2":
                            Console.Clear();
                            isChoice = false;
                            Console.WriteLine();
                            Console.WriteLine("You've Logged out successfully.");
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;

                            //default:
                            //    Header.HeaderDisplay("To do List Application");
                            //    Console.ForegroundColor = ConsoleColor.Red;
                            //    Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                            //    Console.ResetColor();
                            //    break;
                    }
                }
            }

            else
            {
                MenuMessage.DisplayErrorMessage("\n\nUser Does not exist", "Kindly register an account to be able to login\n");
            }


        }
    }
}
