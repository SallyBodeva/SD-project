namespace ArchitectureCompany.Services
{
    using Models;
    using Data;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Security.Cryptography.X509Certificates;
    using System.Linq;

    public class AppService
    {
        private AppDbContext context = new AppDbContext();

        public Project GetProjectByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid project name...");
            }
            Project p = this.context.Projects.FirstOrDefault(x => x.Name == name);
            return p;
        }
        public string AddProject(string name, int builidingTypeId, int capacity, DateTime releaseDate, int totalFloorArea, int numberFloors, int addressId, int imageId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid name...");
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
            Project p = GetProjectByName(name);
            if (p != null)
            {
                return $"Project {name} already exists!";
            }
            p = new Project()
            {
                Name = name,
                BuildingTypeId = builidingTypeId,
                ReleaseDate = releaseDate,
                TotalFloorArea = totalFloorArea,
                NumberOfFloors = numberFloors,
                AddressId = addressId,
                ImageId = imageId
            };
            this.context.Projects.Add(p);
            context.SaveChanges();
            return "Project added successfully";
        }
        public string AddTown(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Town`s name is invalid");
            }
            Town t = this.context.Towns.FirstOrDefault(x => x.Name == name);
            if (t!=null)
            {
                return "Town is already registered...";
            }
            t = new Town() { Name = name };
            this.context.Towns.Add(t);
            context.SaveChanges();
            return $"New town registered successfully ";

        }
    }
}
