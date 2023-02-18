namespace ArchitectureCompany.Services
{
    using Models;
    using Data;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Security.Cryptography.X509Certificates;
    using System.Linq;
    using System.Runtime.ExceptionServices;

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
        public Department GetDepartmentByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Invalid department name ......!");

            }
            Department department = this.context.Departments.FirstOrDefault(x=>x.Name == name);
            return department;
        }
        public Employee GetEmployeeById(int id)
        {
            if (id==null)
            {
                throw new ArgumentException("Invalid employee id ......!");
            }
            Employee employee = this.context.Employees.FirstOrDefault(x => x.Id == id);
            return employee;

        }
        public Client GetClientByFullName(string firstName,string lastName)
        {
            string fullName = firstName + " " + lastName;
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("Invalid client  full name...!");

            }
            Client client = this.context.Clients.FirstOrDefault(x => x.FirstName+" " + lastName == fullName);
            return client;

        }
        public Project GetProjectByReleaseDate(DateTime releaseDate)
        {
            if (releaseDate == null)
            {
                throw new ArgumentException("Invalid release date ...!");
            }
            Project project = this.context.Projects.FirstOrDefault(x => x.ReleaseDate == releaseDate);
            return project;
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
        public void DeleteProject( string name)
        {
            if (string.IsNullOrEmpty(name))
            {
             throw new AggregateException("Invalid project name..!");

            }
            var project = GetProjectByName(name);
            context.Projects.Remove(project);
            context.SaveChanges();

        }
        public void DeleteEmployee(int id)
        {
            if (id==null)
            {
                throw new AggregateException("Invalid employee id..!");

            }
            var employee = GetEmployeeById(id);
            context.Employees.Remove(employee);
            context.SaveChanges();

        }
    }
}
