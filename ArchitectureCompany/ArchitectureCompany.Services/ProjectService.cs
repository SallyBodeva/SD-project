

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
    public class ProjectService
    {
        private AppDbContext context;
        public Project GetProjectById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Project id is not found!");
            }
            if (!int.TryParse(id, out _))
            {
                throw new ArgumentException("Invalid project id!");
            }
            Project project = this.context.Projects.FirstOrDefault(x => x.Id == (int.Parse(id)));
            return project;
        }
        public Project GetProjectByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid project name...");
            }
            Project p = this.context.Projects.FirstOrDefault(x => x.Name == name);
            return p;
        }
        public Project GetProjectByReleaseDate(string date)
        {
            DateTime releaseDate = new DateTime();
            bool isValid = DateTime.TryParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out releaseDate);
            if (!isValid)
            {
                throw new ArgumentException("Invalid date time format... ");
            }
            Project project = this.context.Projects.FirstOrDefault(x => x.ReleaseDate == releaseDate);
            return project;
        }
        public string GetAllEmployeesInfo(int page = 1, int count = 10)
        {
            StringBuilder message = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"Name",-24} | {"BuildingTypeId",-3} | {"BuildingsType",-15} | {"Capacity",-5} | {"ReleaseDate",-15} | {"TotalFloorArea",-10} | {"NumberOfFloors ",-3} | {"AddressId",-5}| {"Address",-15} | {"ImageId ",-3}";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Project> project = context.Projects
                    .Skip((page - 1) * count)
                    .Take(count)
                    .ToList();
                message.AppendLine(firstRow);
                message.AppendLine(line);
                foreach (var e in project)
                {
                    string info = $"| {"Id",-4} | {"Name",-24} | {"BuildingTypeId",-5} | {"BuildingsType",-15} | {"Capacity",-5} | {"ReleaseDate",-15} | {"TotalFloorArea",-10} | {"NumberOfFloors ",-3} | {"AddressId",-20}| {"Address",-15} | {"ImageId ",-5}";
                    message.AppendLine(info);
                    message.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Projects.Count() / (decimal)count);
                message.AppendLine($"Page: {page} / {pageCount}");
            }

            return message.ToString().TrimEnd();
        }

        public ICollection<Project> GetFinishedProjects(string id)
        {
            Project p = GetProjectById(id);
            List<Project> finishedProjects = new List<Project>();
            bool isFinished = p.ReleaseDate < DateTime.Now;
            if (isFinished)
            {
                finishedProjects.Add(p);
            }
            return finishedProjects;
        }
        public ICollection<Project> GetUnfinishedProjects(string id)
        {
            Project p = GetProjectById(id);
            List<Project> unfinishedProjects = new List<Project>();
            bool isFinished = p.ReleaseDate < DateTime.Now;
            if (!isFinished)
            {
                unfinishedProjects.Add(p);
            }
            return unfinishedProjects;
        }
        public string AddProject(string name, string builidingTypeId, int capacity, DateTime releaseDate, int totalFloorArea, int numberFloors, int addressId, int imageId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid name...");
            }
            if (string.IsNullOrWhiteSpace(builidingTypeId))
            {
                throw new ArgumentException("Invalid building type id...");
            }
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity cannot be less or equal to zero");
            }
            if (totalFloorArea <= 0)
            {
                throw new ArgumentException("Floor Area cannot be less or equal to zero");
            }
            if (numberFloors <= 0)
            {
                throw new ArgumentException("Floor Area cannot be less or equal to zero");
            }
            if (!int.TryParse(builidingTypeId, out _))
            {
                throw new ArgumentException("Invalid size!");
            }
            Project p = GetProjectByName(name);
            if (p != null)
            {
                return $"Project {name} already exists!";
            }
            p = new Project()
            {
                Name = name,
                // Трябва да се довърши
                // BuildingTypeId = builidingTypeId,
                ReleaseDate = releaseDate,
                TotalFloorArea = totalFloorArea,
                NumberOfFloors = numberFloors,
                // Трябва да се довърши
                AddressId = addressId,
                ImageId = imageId
            };
            this.context.Projects.Add(p);
            context.SaveChanges();
            return "Project added successfully";
        }
     public void DeleteProjectById(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid project name..!");
            }
            Project project = GetProjectByName(name);
            context.Projects.Remove(project);
            context.SaveChanges();

        }
    }
}
