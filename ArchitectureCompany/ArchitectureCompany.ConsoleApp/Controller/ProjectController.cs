﻿using System;
using System.Collections.Generic;
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
            string result = ps.GetAllProjectsInfo();
            Console.WriteLine(result);
            WaitPressKey();
        }
        public void AddNewProject()
        {
            Console.Write($"> Enter the phone number of the client: ");
            string clientPN = Console.ReadLine();
            int clientId = cs.GetClientIdByPhoneNum(clientPN);
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
            int projectId = ps.GetProjectIdByName(name);
            Console.WriteLine(cs.MatchClientToProject(clientId,projectId));
            WaitPressKey();
        }
        public void GetExactProjectInfo()
        {
            Console.Write($"> Enter project's id: ");
            int id = int.Parse(Console.ReadLine());
            string result = ps.GetProjectInfo(id);
            Console.WriteLine(result);
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
            sb.AppendLine($"\t3: Get exact client info");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
