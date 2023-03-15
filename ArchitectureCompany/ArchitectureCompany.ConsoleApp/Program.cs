namespace ArchitectureCompany.ConsoleApp
{
    using System;
    using System.Text;
    using Services;
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
                        new EmployeeService();
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
            sb.AppendLine($"Pilots menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Employees");
            sb.AppendLine($"\t2: ");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}