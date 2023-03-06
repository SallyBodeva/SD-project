namespace ArchitectureCompany.Services
{
    using Models;
    using Data;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    using System.Drawing;
    using System.Globalization;
    using System.Net;
    using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

    public class ProjectService
    {
        private AppDbContext context;
        public string AddProject(string name, string builidingType, int capacity, string releaseDate, int totalFloorArea, int numberOfFloors, string address, string town, string url)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine($"Invalid {(nameof(name))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(builidingType))
            {
                message.AppendLine($"Invalid {(nameof(builidingType))}");
                isValid = false;
            }
            if (capacity < 0)
            {
                message.AppendLine("Capacity cannot be less than zero");
                isValid = false;
            }
            if (totalFloorArea < 0)
            {
                message.AppendLine("Floor Area cannot be less than zero");
                isValid = false;
            }
            if (numberOfFloors < 0)
            {
                message.AppendLine("Floor number cannot be less than zero");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                message.AppendLine($"Invalid {(nameof(address))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(builidingType))
            {
                message.AppendLine($"Invalid {(nameof(builidingType))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(url))
            {
                message.AppendLine($"Invalid {(nameof(url))}");
                isValid = false;
            }
            Project p = GetProjectByName(name);
            Address a = null;
            Town t = null;
            BuildingType bt = null;
            Image i = null;
            using (context = new AppDbContext())
            {
                if (p != null)
                {
                    message.AppendLine($"Project {name} already exists!");
                }
                t = context.Towns.FirstOrDefault(x => x.Name == town);
                a = context.Addresses.FirstOrDefault(x => x.Name == address&& x.Town.Name==town);
                bt = context.BuildingTypes.FirstOrDefault(x => x.TypeName == builidingType);
                i = context.Images.FirstOrDefault(x => x.Url == url);
                if (t == null)
                {
                    t = new Town() { Name = town };
                }
                if (a == null)
                {
                    a = new Address() { Name = address, Town = t };
                }
                if (bt == null)

                {
                    bt = new BuildingType() { TypeName = builidingType };
                }
                if (i == null)
                {
                    i = new Image() { Url = url };
                }
                if (isValid)
                {
                    DateTime data = new DateTime();
                    bool v =DateTime.TryParseExact(releaseDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
                    p = new Project()
                    {
                        Name = name,
                        BuildingsType = bt,
                        Capacity=capacity,
                        ReleaseDate = data,
                        TotalFloorArea = totalFloorArea,
                        NumberOfFloors = numberOfFloors,
                        Address = a,
                        ImageId = i.Id
                    };
                    this.context.Projects.Add(p);
                    context.SaveChanges();
                    message.AppendLine($"Project {name} is added");

                }
            }
            return message.ToString().TrimEnd();
        }
        public string DeleteProjectById(int id)
        {
            Project project = GetProjectById(id);
            if (project == null)
            {
                return $"Project not found!";
            }
            context.Projects.Remove(project);
            context.SaveChanges();
            return "Project is suspended!";
        }
        public Project GetProjectById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Invalid Project id!");
            }
            Project project = this.context.Projects.FirstOrDefault(x => x.Id == (id));
            return project;
        }
        public Project GetProjectByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid project name...");
            }
            using (context = new AppDbContext())
            {
                Project p = this.context.Projects.FirstOrDefault(x => x.Name == name);
                return p;
            }
        }
        public Project GetProjectByReleaseDate(string date)
        {
            DateTime releaseDate = new DateTime();
            bool isValid = DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDate);
            if (!isValid)
            {
                throw new ArgumentException("Invalid date time format... ");
            }
            using (context = new AppDbContext())
            {
                Project project = this.context.Projects.FirstOrDefault(x => x.ReleaseDate == releaseDate);
                return project;
            }
        }


        public List<Project> GetFinishedProjects(int id)
        {
            using (context = new AppDbContext())
            {
                Project p = GetProjectById(id);
                List<Project> finishedProjects = new List<Project>();
                bool isFinished = p.ReleaseDate < DateTime.UtcNow;
                if (isFinished)
                {
                    finishedProjects.Add(p);
                }
                return finishedProjects;
            }
        }
        public List<Project> GetUnfinishedProjects(int id)
        {
            using (context = new AppDbContext())
            {
                Project p = GetProjectById(id);
                List<Project> unfinishedProjects = new List<Project>();
                bool isFinished = p.ReleaseDate < DateTime.UtcNow;
                if (!isFinished)
                {
                    unfinishedProjects.Add(p);
                }
                return unfinishedProjects;
            }
        }
        public string GetProjectInfo()
        {
            Project project = null;
            using (context = new AppDbContext())
            {
                project = context.Projects.Find(project);
            }
            if (project != null)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine($"{nameof(project)} info: ");
                message.AppendLine($"\tId: {project.Id}");
                message.AppendLine($"\tName: {project.Name}");
                message.AppendLine($"\tBuildingTypeId id: {project.BuildingTypeId}");
                message.AppendLine($"\tCapacity: {project.Capacity}");
                message.AppendLine($"\tRelease date: {project.ReleaseDate}");
                message.AppendLine($"\tTotal floor area: {project.TotalFloorArea}");
                message.AppendLine($"\tNumber of floors: {project.NumberOfFloors}");
                message.AppendLine($"\tAddres id: {project.AddressId}");
                return message.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Project)} not found!";
            }
        }
        public string GetAllProjectsInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"Name",-12} | {"Building Type Id: ",-4} | {"Capacity",-5} | {"Release date",-10} | {"Total Floor area",-9} | {"Number of Floors",-3} | {"Address id",-3}|";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Project> projects = context.Projects.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var c in projects)
                {
                    string info = $"| {"Id",-4} | {"Name",-12} | {"Building Type Id: ",-4} | {"Capacity",-5} | {"Release date",-10} | {"Total Floor area",-9} | {"Number of Floors",-3} | {"Address id",-3}|";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Projects.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();
        }
        
        public string AddImageToProject(int projectId, string url)
        {
            using (context = new AppDbContext())
            {
                Project p = context.Projects.Find(projectId);
                if (p == null)
                {
                    return "Project not found";
                }
                Image i = new Image() { Url = url, Project = p };
                context.Images.Add(i);
                context.SaveChanges();
                return "Image added successfully!";
            }
        }
        public string DeleteImageToProject(int projectId, string url)
        {
            using (context = new AppDbContext())
            {
                Project p = context.Projects.Find(projectId);
                Image i = context.Images.FirstOrDefault(x => x.Url == url);
                if (p == null)
                {
                    return "Project not found";
                }
                if (i==null)
                {
                    return "Image not found!";
                }
                context.Images.Remove(i);
                context.SaveChanges();
                return "Image added successfully!";
            }
        }
    }
}
