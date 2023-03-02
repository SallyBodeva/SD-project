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

    public class AppService
    {
        private AppDbContext context = new AppDbContext();

     
        public Department GetDepartmentByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid department name ......");

            }
            Department department = this.context.Departments.FirstOrDefault(x => x.Name == name);
            return department;
        }
        public Employee GetEmployeeById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Invalid employee id ......");
            }
            if (!int.TryParse(id, out _))
            {
                throw new ArgumentException("Invalid employee id!");
            }
            Employee employee = this.context.Employees.FirstOrDefault(x => x.Id == (int.Parse(id)));
            return employee;

        }
        public Client GetClientByFullName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                throw new ArgumentException("Invalid client full name...");

            }
            Client client = this.context.Clients.FirstOrDefault(x => x.FirstName + " " + x.LastName == fullName);
            return client;

        }
      
        public Department GetDepartmentId(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Department id is not found!");
            }
            if (!int.TryParse(id, out _))
            {
                throw new ArgumentException("Invalid department id!");
            }
            Department department = this.context.Departments.FirstOrDefault(x => x.Id == (int.Parse(id)));
            return department;
        }
     
        public Address GetAdressId(string id) 
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Adress id is not found!");

            }
            if (!int.TryParse(id,out _))
            {
                throw new ArgumentException("Invalid adress id!");
            }
            Address address = this.context.Addresses.FirstOrDefault(x => x.Id == (int.Parse(id)));
            return address;
             
        }
        public Image GetImageId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Image id is not found!");

            }
            if (!int.TryParse(id, out _))
            {
                throw new ArgumentException("Invalid image id!");
            }
            Image image = this.context.Images.FirstOrDefault(x => x.Id == (int.Parse(id)));
            return image;

        }
        
        public string AddTown(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Town`s name is invalid");
            }
            Town t = this.context.Towns.FirstOrDefault(x => x.Name == name);
            if (t != null)
            {
                return "Town is already registered...";
            }
            t = new Town() { Name = name };
            this.context.Towns.Add(t);
            context.SaveChanges();
            return $"New town registered successfully ";

        }

        public string AddAddress(string name, string townId)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Invalid address");
            }
            if (string.IsNullOrWhiteSpace(townId))
            {
                throw new ArgumentException("Invalid town id..!");
            }
            if (!int.TryParse(townId, out _))
            {
                throw new ArgumentException("Invalid town id!");
            }
            Address ad = this.context.Addresses.FirstOrDefault(x => x.Name == name);
            if (ad != null)
            {
                return "Address is already registered...";
            }
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
        public string AddDepartment(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Department doesn't exist");
            }
            Department d = this.context.Departments.FirstOrDefault(x => x.Name == name);
            if (d != null)
            {
                return "Address already exists";
            }
            d = new Department() { Name = name };
            this.context.Departments.Add(d);
            context.SaveChanges();
            return $"New address is added successfully ";
        }
        public string AddBuildingType(string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName))
            {
                throw new ArgumentException("Building type doesn't exist");
            }
            BuildingType bt = this.context.BuildingTypes.FirstOrDefault(x => x.TypeName == typeName);
            if (bt != null)
            {
                return "Building type already exists";
            }
            bt = new BuildingType() { TypeName = typeName };
            this.context.BuildingTypes.Add(bt);
            context.SaveChanges();
            return $"New building type is added successfully ";
        }
      
        public void DeleteEmployeeById(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id))
            {
                throw new ArgumentException("Invalid employee id..!");

            }
            Employee employee = GetEmployeeById(Id);
            context.Employees.Remove(employee);
            context.SaveChanges();

        }
     
     
       

        
    }
}
