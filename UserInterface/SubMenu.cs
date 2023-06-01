using Data.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    internal class SubMenu
    {
        
        
        List<Supplier> Suppliers = new();
        public static void Customer()
        {
            List<Customer> Customers = new();
            Header.HeaderDisplay("Customer Page");
            while (true)
            {
                //Header.HeaderDisplay("Store Management System");
                MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Register\n2. Login\n3. Main Menu\n4. Exit \nYour Option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                int value;
                while (Validation.TryParseInt(choice, out value))
                {
                    Header.HeaderDisplay("Store Management System");
                    MenuMessage.DisplayErrorMessage($"{choice} \nis an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");

                    MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Register\n2. Login\n3. Main Menu\n4. Exit \nYour Option: ");
                    choice = Console.ReadLine();
                }


                Console.Clear();

                switch (choice)
                {
                    case "1":
                        RegistrationPage.CustomerRegistration(Customers);
                        break;

                    case "2":
                       
                        LoginPage customerlogin = new ();
                        customerlogin.CustomerLogin(Customers);
                        break;

                    case "3":
                        MainEntry.Entry();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Header.HeaderDisplay("To do List Application");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public static void Employee()
        {
            List<Employee> Employees = new();
            Header.HeaderDisplay("Employee Page");
            while (true)
            {
               // Header.HeaderDisplay("Store Management System");
                MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Register\n2. Login\n3. Main Menu\n4. Exit \n\nYour Option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                int value;
                while (Validation.TryParseInt(choice, out value))
                {
                    Header.HeaderDisplay("Store Management System");
                    MenuMessage.DisplayErrorMessage($"{choice} is an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");

                    MenuMessage.DisplayActionMessage("\nPlease select an option:\n \n1. Register\n2. Login\n3. Main Menu\n4. Exit \n\nYour Option: ");
                    choice = Console.ReadLine();
                }


                Console.Clear();

                switch (choice)
                {
                    case "1":
                        RegistrationPage.EmployeeRegistration(Employees);
                        break;

                    case "2":
                        LoginPage employeelogin = new();
                        employeelogin.EmployeeLogin(Employees);
                        break;

                    case "3":
                        MainEntry.Entry();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Header.HeaderDisplay("To do List Application");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public static void Supplier()
        {
            List<Supplier> Suppliers = new();
            Header.HeaderDisplay("Employee Page");
            while (true)
            {
                // Header.HeaderDisplay("Store Management System");
                MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Register\n2. Login\n3. Main Menu\n4. Exit \n\nYour Option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                int value;
                while (Validation.TryParseInt(choice, out value))
                {
                    Header.HeaderDisplay("Store Management System");
                    MenuMessage.DisplayErrorMessage($"{choice} is an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");

                    MenuMessage.DisplayActionMessage("\nPlease select an option:\n \n1. Register\n2. Login\n3. Main Menu\n4. Exit \n\nYour Option: ");
                    choice = Console.ReadLine();
                }


                Console.Clear();

                switch (choice)
                {
                    case "1":
                        RegistrationPage.SupplierRegistration(Suppliers);
                        break;

                    case "2":
                        LoginPage supplierlogin = new();
                        supplierlogin.SuplierLogin(Suppliers);
                        break;

                    case "3":
                        MainEntry.Entry();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Header.HeaderDisplay("To do List Application");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{choice} {MenuMessage.IntErrorMessage}");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
