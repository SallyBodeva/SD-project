using ArchitectureCompany.Data;
using System;

namespace ArchitectureCompany.Services
{
    using ArchitectureCompany.Data;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DepartmentService
    {
        private AppDbContext context;

        public Department GetDepartmentById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Department id is not found!");
            }
            if (!int.TryParse(id, out _))
            {
                throw new ArgumentException("Invalid department id!");
            }
            if (int.Parse(id)<0)
            {
                throw new ArgumentException("Invalid department id!");
            }
            using (context = new AppDbContext())
            {
                Department d = context.Departments.Find(id);
                return d;
            }
        }
    }
}