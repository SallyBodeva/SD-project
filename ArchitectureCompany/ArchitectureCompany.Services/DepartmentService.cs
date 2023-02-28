using ArchitectureCompany.Data;
using System;

namespace ArchitectureCompany.Services
{
    using ArchitectureCompany.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class DepartmentService
    {
        private AppDbContext context;
        public string AddDepartment(string name)
        {
            StringBuilder msg = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                msg.AppendLine($"Invalid department name");
                isValid = false;
            }
            if (isValid)
            {
                Department d = new Department() { Name = name };
                using (context = new AppDbContext())
                {
                    context.Add(d);
                    context.SaveChanges();
                    msg.AppendLine($"{nameof(Department)} {name} is created");
                }
            }
            return msg.ToString().TrimEnd();
        }
        public Department GetDepartmentById(int id)
        {
            using (context = new AppDbContext())
            {
                Department d = context.Departments.FirstOrDefault(x => x.Id == id);
                return d;
            }
        }
        public string DeleteDepartment(int id)
        {
            Department d = GetDepartmentById(id);
            using (context = new AppDbContext())
            {
                if (d == null)
                {
                    return $"Department is not found!";
                }
                context.Remove(d);
                context.SaveChanges();
                return $"Department {d.Name} is closed!";
            }
        }
    }
}