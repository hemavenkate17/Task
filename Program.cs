using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using TransportBLLibrary;


namespace TransportFEApplication
{
    class Program
    {
        EmployeeLogin login;
        EmployeeManagement management;
        EmployeeBL bl;
        public Program()
        {
            bl = new EmployeeBL();
            login = new EmployeeLogin(bl);
            management = new EmployeeManagement(bl);
        }
        void PrintMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Print all");
                Console.WriteLine("4. Sort and print all");
                Console.WriteLine("5. Update Password");
                Console.WriteLine("6. Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        login.RegisterEmployee();
                        break;
                    case 2:
                        login.UserLogin();
                        break;
                    case 3:
                        management.PrintAllEmployee();
                        break;
                    case 4:
                        management.PrintEmployeeSortedById();
                        break;
                    case 5:
                        management.ResetPassword();
                        break;
                    case 6:
                        Console.WriteLine("exited ");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice !=7);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program().PrintMenu();
            Console.ReadKey();
        }
    }
}
