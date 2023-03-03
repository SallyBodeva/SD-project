

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
        public string AddProject(string name, string builidingType, int capacity, DateTime releaseDate, int totalFloorArea, int numberFloors, string address,string town, string url)
        {
            StringBuilder message=new StringBuilder();
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
            if (capacity<0)
            {
                message.AppendLine("Capacity cannot be less or equal to zero");
                isValid = false;
            }
            if (totalFloorArea<0)
            {
                message.AppendLine("Floor Area cannot be less or equal to zero");
                isValid = false;
            }
            if (numberFloors<0)
            {
                message.AppendLine("Floor number cannot be less or equal to zero");
            }
            // Да се провери дали е нужно- според мен не, aма да съм сигурна
            //if (!int.TryParse(builidingType, out _))
            //{
            //    message.AppendLine("Invalid size!");
            //    isValid = false;
            //}
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
            using (context=new AppDbContext())
            {
                if (p != null)
                {
                    message.AppendLine( $"Project {name} already exists!");
                }
                a = context.Addresses.FirstOrDefault(a => a.Name == address);
                t=context.Towns.FirstOrDefault(t => t.Name == town);
                bt = context.BuildingTypes.FirstOrDefault(t => t.TypeName == builidingType);
                if (a==null){a = new Address() { Name = address, Town= t };}
                if (t == null) { t = new Town() { Name =town }; }
                if (bt == null) { bt = new BuildingType() { TypeName = builidingType }; }
                
            }
   
            if (isValid)
            {
                using (context = new AppDbContext())
                {
                    p = new Project()
                    {
                        Name = name,                      
                     //  BuildingType = bt,
                        ReleaseDate = releaseDate,
                        TotalFloorArea = totalFloorArea,
                        NumberOfFloors = numberFloors,
                       
                        Address = a,
                      
                    //   ImageId = url
                    };
                    this.context.Projects.Add(p);
                    context.SaveChanges();
                    message.AppendLine($"Project {name} is added");
                }
             }
            return message.ToString().TrimEnd();
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
