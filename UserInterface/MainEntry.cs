using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    internal class MainEntry
    {
        public static void Entry()
        {
           
            // List<BankAccount> UsersBankAccount = new List<BankAccount>();

            Header.HeaderDisplay("Store Management System");
            while (true)
            {
                //Header.HeaderDisplay("Store Management System");
                MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Customer\n2. Employee\n3. Supplier\n4. Exit\n \nYour Option: \n");

                string choice = Console.ReadLine();
                Console.Clear();

                int value;
                while (Validation.TryParseInt(choice, out value))
                {
                    Header.HeaderDisplay("Store Management System");
                    MenuMessage.DisplayErrorMessage($"{choice} is an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");

                    MenuMessage.DisplayActionMessage("Please select an option:\n \n1. Customer\n2. Employee\n3. Supplier\n4. Exit\n \nYour Option: \n");
                    choice = Console.ReadLine();
                }


                Console.Clear();

                switch (choice)
                {
                    case "1":
                        SubMenu.Customer();
                        break;

                    case "2":
                        SubMenu.Employee();
                        break;

                    case "3":
                        SubMenu.Supplier();
                        break;

                    case "4":
                        Environment.Exit(0);
                        break;

                    default:
                        Header.HeaderDisplay("Store Management System");
                        MenuMessage.DisplayErrorMessage($"{choice} is an Invalid Input, your option should not contain alphabet or character.", "\nPlease enter a valid option. eg 1,2,3\n");
                        break;
                }
            }
        }
    }
}
