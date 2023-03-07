using ArchitectureCompany.Data;
using ArchitectureCompany.Models;
using ArchitectureCompany.Services;
using System;
using System.Collections.Generic;

namespace ArchitectureCompany.Seeder
{
    public class Program
    {
        private static AdditionalService addiotionalService = new AdditionalService();
        private static DepartmentService departmentService = new DepartmentService();
        private static ProjectService projectService = new ProjectService();
        static void Main()
        {
            SeedTowns();
        }

        List<Project> projects = new List<Project>();
        List<BuildingType> buildingTypes = new List<BuildingType>();

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
                Console.WriteLine(departmentService.AddDepartment(name));
            }

        }
        public static void SeedAddresses()
        {
            List<string> a = new List<string>();

        }
        public static void SeedEmployee()
        {
            List<string> firstName = new List<string>() { "Jane", "Lenore", "Susy", "Genna", "Viki", "Toni", "Serkan", "Eda", "Kiraz", "Selin", "Engin", "Steven", "Barbara", "Kiara", "Kerem", "Aleph", "Quintessa", "Margarette", "Oscar", "Sebastian", "Zane", "Mabel", "Leo", "Scarlett", "Yasemin", "Caleb" };
            List<string> lastName = new List<string>() { "Stove", "Lobile", "Dykas", "Larne", "Romera", "Borrel", "Bolat", "Yaldiz", "Karadaa", "Smith", "Williams", "Johnson", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson" };

            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                //int employeeFirstName = random.Next(0, firstName.Count);
                //int employeeLastName = random.Next(0, lastName.Count);

                //Console.WriteLine(EmployeeService.AddEmployee(firstName[employeeFirstName], lastName [employeeLastName]));
            }
        }
        public static void SeedClient()
        {

        }

        public static void SeedTowns()
        {
            List<string> t = new List<string>();
            t.Add("Plovdiv");
            t.Add("Pazardzhik");
            t.Add("Sofia");
            t.Add("Varna");
            t.Add("Ruse");
            t.Add("Blagoevgrad");
            t.Add("Burgas");
            t.Add("Bansko");
            t.Add("London");
            t.Add("Rome");
            t.Add("Paris");
            t.Add("Helzinki");
            t.Add("Otawa");
            t.Add("New York");
            t.Add("Washington");
            t.Add("Pernik");
            t.Add("Dubai");
            t.Add("Ciro");
            t.Add("Buenos Aires");
            t.Add("Montevideo");
            t.Add("Monaco");
            t.Add("Normandy");
            t.Add("Berlin");
            t.Add("Vienna");
            t.Add("Munchen");
            t.Add("Limasol");
            t.Add("Madrid");
            t.Add("Lisbon");
            t.Add("Barcelona");
            t.Add("Porto");
            t.Add("Kabul");
            t.Add("Tirana");
            t.Add("Algiers");
            t.Add("Luanda");
            t.Add("Yerevan");
            t.Add("Cambera");
            t.Add("Baku");
            t.Add("Bridgetown");
            t.Add("Minsk");
            t.Add("Sarajevo");
            t.Add("Zagreb");
            t.Add("Havana");
            t.Add("New Delhi");
            t.Add("Jakarta");
            t.Add("Kingston");
            t.Add("Tokyo");
            t.Add("Pristina");
            t.Add("Valleta");
            t.Add("Wellington");
            t.Add("Belfast");
            t.Add("Oslo");
            t.Add("Warsaw");
            t.Add("Bern");
            t.Add("Ankara");
            t.Add("Puerto Rico");
            t.Add("Liverpool");
            t.Add("Santorini");
            t.Add("Oia");
            t.Add("Ronda");
            t.Add("Dobrovnik");
            t.Add("Sintra");
            t.Add("New Orleans");
            t.Add("Coventry");
            t.Add("Oxford");
            t.Add("York");


            for (int i = 0; i < 65; i++)
            {
                string name = t[i];
                Console.WriteLine(addiotionalService.AddTown(name));
            }
        }
        



    }
}
