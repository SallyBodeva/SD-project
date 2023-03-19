using ArchitectureCompany.Data;
using ArchitectureCompany.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchitectureCompany.ConsoleApp.Controller
{
    public class EmployeeController
    {
        private EmployeeService es;
        public EmployeeController()
        {
            es = new EmployeeService();
            Run();
        }
        // test
        private void Run()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Commands();
                    Console.Write("> Enter command:");
                    string cmd = Console.ReadLine();
                    switch (cmd)
                    {
                        case "0":
                            return;
                        case "1":
                            PrintEmployeesInfo();
                            break;
                        case "2":
                            HireNewEmployee();
                            break;
                        case "3":
                            DeleteEmployee();
                            break;
                        case "4":
                            UpdateEmployeePhoneNumber();
                            break;
                        case "5":
                            GetExactEmployeeInfo();
                            break;
                        default:
                            Console.WriteLine("Invalid command!");
                            WaitPressKey();

                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    WaitPressKey();
                }
            }
        }
        public void PrintEmployeesInfo()
        {
            int currentPage = 1;
            int pageCount = es.GetEmployeePagesCount();
            while (true)
            {
                try
                {
                    Console.Clear();
                    string result = es.GetAllEmployeesInfo(currentPage);
                    Console.WriteLine(result);
                    Console.WriteLine("Commands: 0:Back, 1:Previous page, 2:Next page ");
                    Console.Write("Enter command: ");
                    string cmd = Console.ReadLine();
                    switch (cmd)
                    {
                        case "0":
                            return;
                        case "1":
                            if (currentPage > 1) { currentPage--; }
                            break;
                        case "2":
                            if (currentPage < pageCount) { currentPage++; }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        public void HireNewEmployee()
        {
            try
            {
                Console.Write($"> Enter first name: ");
                string name = Console.ReadLine();
                Console.Write($"> Enter last name: ");
                string lastName = Console.ReadLine();
                Console.Write($"> Enter address name: ");
                string address = Console.ReadLine();
                Console.Write($"> Enter town: ");
                string town = Console.ReadLine();
                Console.Write($"> Enter department: ");
                string department = Console.ReadLine();
                Console.Write($"> Enter phone number(it has to be 10 digits only): ");
                string number = Console.ReadLine();
                if (number.Count() != 10)
                {
                    Console.WriteLine("Invalid phone number!");
                    WaitPressKey();
                    return;
                }
                Console.Write($"> Enter email: ");
                string email = Console.ReadLine();

                string result = es.AddEmployee(name, lastName, address, town, department, number, email);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            WaitPressKey();
        }
        public void DeleteEmployee()
        {
            try
            {
                Console.Write($"> Enter employee's id: ");
                int id = int.Parse(Console.ReadLine());
                string result = es.DeleteEmployeeById(id);
                Console.WriteLine(result);
                WaitPressKey();
            }
            catch (Exception)
            {
                Console.WriteLine("This employee cannot be discharge, his projects are still remainig...");
                WaitPressKey();
            }

        }
        public void UpdateEmployeePhoneNumber()
        {
            Console.Write($"> Enter employee's id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"> Enter new phone number : ");
            string pN = Console.ReadLine();
            if (pN.Count() != 10)
            {
                Console.WriteLine("Invalid phone number!");
                WaitPressKey();
                return;
            }
            string result = es.UpdateEmployeePhoneNum(id, pN);
            Console.WriteLine(result);
            WaitPressKey();
        }
        public void GetExactEmployeeInfo()
        {
            Console.Write($"> Enter employee's id: ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                string result = es.GetEmployeeInfo(id);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            WaitPressKey();
        }
        private static void WaitPressKey()
        {
            Console.WriteLine($"Press any key to continue...");
            Console.ReadKey();
        }
        public void Commands()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Employees list");
            sb.AppendLine($"\t2: Hire new employee");
            sb.AppendLine($"\t3: Discharge employee");
            sb.AppendLine($"\t4: Update employee phone number");
            sb.AppendLine($"\t5: Get exact employee info");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
