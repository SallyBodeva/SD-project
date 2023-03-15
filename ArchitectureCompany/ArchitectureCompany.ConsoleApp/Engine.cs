namespace ArchitectureCompany.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using ArchitectureCompany.Data;
    using ArchitectureCompany.Services;
    using Microsoft.EntityFrameworkCore.Internal;

    public class Engine
    {
        private static AppDbContext context = new AppDbContext();
        EmployeeService es = new EmployeeService();
        ClientService cs = new ClientService();
        DepartmentService ds = new DepartmentService();
        AdditionalService ads = new AdditionalService();
        ProjectService ps = new ProjectService();
        public Engine()
        {
            Run();
        }
        public void Run()
        {
            while (true)
            {
                Commands();
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        PrintEmployeesInfo();
                        break;
                    case "1.1":
                        PrintClientsInfo();
                        break;
                    case "1.2":
                        PrintProjectsInfo();
                        break;
                    case "2":
                        HireNewEmployee();
                        break;
                    case "2.1":
                        AddNewClient();
                        break;
                    case "2.2":
                        AddNewProject();
                        break;
                    case "3":
                        UpdateEmployeePhoneNumber();
                        break;
                    case "5.1":
                        GetExactEmployeeInfo();
                        break;
                    case "5.2":
                        GetExactClientInfo();
                        break;
                    case "5.3":
                        GetExactProjectInfo();
                        break;
                    // case "4":
                    //     DeleteEmployee();
                    //     break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
        public void Commands()
        {
            Console.WriteLine("Commands: 1: Print employees' info, 1.1: Print clients' info, 1.2: Print projects info , 2: Hire new employee, 2.1: Add new client, 2.2: Add new project, 3:Update employee's phone number, 4: Delete employee,5.1: Get exact employee info,5.2: Get exact client info,5.3: Get exact project info, 0: Exit");
            Console.Write("> Select command: ");
        }
        public void PrintEmployeesInfo()
        {
            if (context.Employees.Any())
            {
                string result = es.GetAllEmployeesInfo();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The company has no hired employees");
            }
        }
        public void PrintClientsInfo()
        {
            if (context.Clients.Any())
            {
                string result = cs.GetAllClientsInfo();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The company has no clients...");
            }
        }
        public void PrintProjectsInfo()
        {
            if (context.Projects.Any())
            {
                string result = ps.GetAllProjectsInfo();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("The company has no active projects...");
            }
        }
        public void HireNewEmployee()
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
            Console.Write($"> Enter email: ");
            string email = Console.ReadLine();
            string result = es.AddEmployee(name, lastName, address, town, department, number, email);
            Console.WriteLine(result);
        }
        public void AddNewClient()
        {
            Console.Write($"> Enter first name: ");
            string name = Console.ReadLine();
            Console.Write($"> Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write($"> Enter address name: ");
            string address = Console.ReadLine();
            Console.Write($"> Enter town: ");
            string town = Console.ReadLine();
            Console.Write($"> Enter phone number(it has to be 10 digits only): ");
            string number = Console.ReadLine();
            Console.Write($"> Enter email: ");
            string email = Console.ReadLine();
            string result = cs.AddClient(name, lastName, address, town, number, email);
            Console.WriteLine(result);
        }
        public void AddNewProject()
        {
            Console.Write($"> Enter name: ");
            string name = Console.ReadLine();
            Console.Write($"> Enter building type : ");
            string bt = Console.ReadLine();
            Console.Write($"> Enter capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.Write($"> Enter expected released date(the format must be dd-mm-yyyy): ");
            string releasedDate = Console.ReadLine();
            Console.Write($"> Enter total floor area: ");
            int area = int.Parse(Console.ReadLine());
            Console.Write($"> Enter number of Floors: ");
            int nF = int.Parse(Console.ReadLine());
            Console.Write($"> Enter address name: ");
            string address = Console.ReadLine();
            Console.Write($"> Enter town: ");
            string town = Console.ReadLine();
            string result = ps.AddProject(name, bt, capacity, releasedDate, area, nF, address, town);
            Console.WriteLine(result);
        }
        public void UpdateEmployeePhoneNumber()
        {
            Console.Write($"> Enter employee's id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write($"> Enter new phone number : ");
            string pN = Console.ReadLine();
            string result = es.UpdateEmployeePhoneNum(id, pN);
            Console.WriteLine(result);
        }
        // public void DeleteEmployee()
        // {
        //     Console.Write($"> Enter employee's id: ");
        //     int id = int.Parse(Console.ReadLine());
        //     string result = es.DeleteEmployeeById(id);
        //     Console.WriteLine(result);
        // }
        public void GetExactEmployeeInfo()
        {
            Console.Write($"> Enter employee's id: ");
            int id = int.Parse(Console.ReadLine());
            string result = es.GetEmployeeInfo(id);
            Console.WriteLine(result);
        }
        public void GetExactClientInfo()
        {
            Console.Write($"> Enter client's id: ");
            int id = int.Parse(Console.ReadLine());
            string result = cs.GetClientInfoById(id);
            Console.WriteLine(result);
        }
        public void GetExactProjectInfo()
        {
            Console.Write($"> Enter project's id: ");
            int id = int.Parse(Console.ReadLine());
            string result = ps.GetProjectInfo(id);
            Console.WriteLine(result);
        }

    }
}
