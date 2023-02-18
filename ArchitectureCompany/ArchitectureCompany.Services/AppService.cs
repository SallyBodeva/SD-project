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
    using System.Drawing;

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
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid department name ......");

            }
            Department department = this.context.Departments.FirstOrDefault(x=>x.Name == name);
            return department;
        }
        public Employee GetEmployeeById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Invalid employee id ......");
            }
            Employee employee = this.context.Employees.FirstOrDefault(x => x.Id == (int.Parse(id)));
            return employee;

        }
        public Client GetClientByFullName(string firstName,string lastName)
        {
            string fullName = firstName + " " + lastName;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException("Invalid client full name...");

            }
            Client client = this.context.Clients.FirstOrDefault(x => x.FirstName+" " + lastName == fullName);
            return client;

        }
        public Project GetProjectByReleaseDate(DateTime releaseDate)
        {
            // За довършване
            Project project = this.context.Projects.FirstOrDefault(x => x.ReleaseDate == releaseDate);
            return project;
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
        public void DeleteProject(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
             throw new AggregateException("Invalid project name..!");

            }
            Project project = GetProjectByName(name);
            context.Projects.Remove(project);
            context.SaveChanges();

        }
        public void DeleteEmployee(string refId)
        {
            if (string.IsNullOrWhiteSpace(refId))
            {
                throw new AggregateException("Invalid employee id..!");

            }
            Employee employee = GetEmployeeById(refId);
            context.Employees.Remove(employee);
            context.SaveChanges();

        }
       public void AddAddress(string name, strinf townId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid address");
            }
            if(string.IsNullOrWhiteSpace(townId))
            {
                throw new AggregateException("Invalid town id..!");

            }
            Address ad = this.context.Addresses.FirstOrDefault(x => x.Name == name);
            if (t ad= null)
            {
                return "Address is already registered...";
            }
            ad = new Address() { Name = name };

            ad = new Address()
            {
                Name = name,
                // Трябва да се довърши
                // TownId = townId,

            };
            this.context.Addresses.Add(ad);
            context.SaveChanges();       
            return $"New address is registered successfully ";
                          
       }
        public void AddDepartment(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Department doesn't exist");
            }
            Department d = this.context.Departments.FirstOrDefault(x => x.Name == name);
            if (t != null)
            {
                return "Address already exists";
            }
            d = new Department() { Name = name };
            this.context.Department.Add(d);
            context.SaveChanges();
            return $"New address is added successfully ";
        }
        public void AddBuildingType()
        {

        }

    }
}
