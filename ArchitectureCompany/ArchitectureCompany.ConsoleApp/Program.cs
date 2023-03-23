using System;
using System.Text;
using ArchitectureCompany.Services;
using ArchitectureCompany.ConsoleApp.Controller;
using System.Collections.Generic;
namespace ArchitectureCompany.ConsoleApp
{
    internal class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Commands();
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        return;
                    case "1":
                        new EmployeeController();
                        break;
                    case "2":
                        new ClientController();
                        break;
                    case "3":
                        new ProjectController();
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
        }
        

        public static void Commands()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Art life menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Employees");
            sb.AppendLine($"\t2: Clients");
            sb.AppendLine($"\t3: Projects");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}