using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Text;
using ArchitectureCompany.Services;

namespace ArchitectureCompany.ConsoleApp.Controller
{
    public class ProjectController
    {
        private static ProjectService ps;
        private static ClientService cs;
        public ProjectController()
        {
            ps = new ProjectService();
            cs = new ClientService();
            Run();
        }
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
                            PrintProjectsInfo();
                            break;
                        case "2":
                            AddNewProject();
                            break;
                        case "3":
                            GetExactProjectInfo();
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
        public void PrintProjectsInfo()
        {
            int currentPage = 1;
            int pageCount = ps.GetProjectsPagesCount();
            while (true)
            {
                try
                {


                    Console.Clear();
                    string result = ps.GetAllProjectsInfo(currentPage);
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
        public void AddNewProject()
        {
            try
            {
                Console.Write($"> Enter the id of the client: ");
                int clientId = int.Parse(Console.ReadLine());

                Console.Write($"> Enter project name: ");
                string name = Console.ReadLine();

                Console.Write($"> Enter building type : ");
                string bt = Console.ReadLine();

                Console.Write($"> Enter capacity: ");
                int capacity = int.Parse(Console.ReadLine());

                Console.Write($"> Enter expected released date(the format must be dd-mm-yyyy): ");
                string releasedDate = Console.ReadLine();
                DateTime data = new DateTime();
                bool v = DateTime.TryParseExact(releasedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);

                Console.Write($"> Enter total floor area: ");
                int area = int.Parse(Console.ReadLine());
                Console.Write($"> Enter number of Floors: ");
                int nF = int.Parse(Console.ReadLine());
                Console.Write($"> Enter address name: ");
                string address = Console.ReadLine();
                Console.Write($"> Enter town: ");
                string town = Console.ReadLine();
                string result = ps.AddProject(name, bt, capacity, data, area, nF, address, town);
                Console.WriteLine(result);
                int projectId = ps.GetProjectIdByName(name);
                Console.WriteLine(cs.MatchClientToProject(clientId, projectId));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         
            WaitPressKey();
        }
        public void GetExactProjectInfo()
        {
            try
            {
                Console.Write($"> Enter project's id: ");
                int id = int.Parse(Console.ReadLine());
                string result = ps.GetProjectInfo(id);
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
            sb.AppendLine($"Projects menu:");
            sb.AppendLine($"\t0: Back");
            sb.AppendLine($"\t1: Projects list");
            sb.AppendLine($"\t2: Add new project");
            sb.AppendLine($"\t3: Get exact project info");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
