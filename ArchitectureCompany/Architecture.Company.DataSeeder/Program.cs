using System;
using System.Collections.Generic;
using ArchitectureCompany.Services;
namespace Architecture.Company.DataSeeder
{
    public class Program
    {
        private static DepartmentService dService = new DepartmentService();
        static void Main()
        {
           
        }
        public static void SeedDepartments()
        {
            List<string> d = new List<string>();
            d.Add("Residential Architecture");
            d.Add("Commercial Architecture");
            d.Add("Interior Design");
            d.Add("Green Design Architecture");
            d.Add("Landscape Architecture");
            d.Add("Urban Design");
            d.Add("Industrial Architecture");
            d.Add("PR management");

            for (int i = 0; i < 8; i++)
            {
                string name = d[i];
                Console.WriteLine(dService.AddDepartment(name));
            }

        }
    }
}
