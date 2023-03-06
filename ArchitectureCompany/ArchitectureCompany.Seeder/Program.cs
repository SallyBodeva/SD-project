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
            List<string> firstName = new List<string>() { "Jane", "Lenore", "Susy", "Genna", "Viki", "Toni","Serkan","Eda","Kiraz","Selin","Engin","Steven","Barbara","Kiara","Kerem","Aleph","Quintessa","Margarette","Oscar","Sebastian","Zane","Mabel","Leo","Scarlett","Yasemin","Caleb" };
            List<string> lastName = new List<string>() { "Stove", "Lobile", "Dykas", "Larne", "Romera", "Borrel","Bolat","Yaldiz","Karadaa", "Smith", "Williams", "Johnson", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson" };
            
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
            t.Add("Ruse" );
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

            for (int i = 0; i < 30; i++)
            {
                string name = t[i];
                Console.WriteLine(addiotionalService.AddTown(name));
            }
        }
        // projects.Add(new Project() { Id = 1, Name = "Museum design" });
        // projects.Add(new Project() { Id = 2, Name = "Theater design" });
        // projects.Add(new Project() { Id = 3, Name = "Kino design" });
        // projects.Add(new Project() { Id = 4, Name = "Renovation of old buildings" });
        // projects.Add(new Project() { Id = 5, Name = "Modern office" });
        // projects.Add(new Project() { Id = 6, Name = "Modern house" });
        // projects.Add(new Project() { Id = 7, Name = "Old house" });
        // projects.Add(new Project() { Id = 8, Name = "Restaurant renovation" });
        // projects.Add(new Project() { Id = 9, Name = "Renovation of a residential complex" });
        // projects.Add(new Project() { Id = 10, Name = "Mansion design" });
        // projects.Add(new Project() { Id = 11, Name = " Leaf fall" });
        // projects.Add(new Project() { Id = 12, Name = " Oasis" });
        // projects.Add(new Project() { Id = 13, Name = "Cristal city" });
        // projects.Add(new Project() { Id = 14, Name = "Golden river" });
        // projects.Add(new Project() { Id = 15, Name = "Golden street" });
        // projects.Add(new Project() { Id = 16, Name = "Dream land" });
        // projects.Add(new Project() { Id = 17, Name = "Children's corner " });
        // projects.Add(new Project() { Id = 18, Name = "A beaytifull park" });
        // projects.Add(new Project() { Id = 19, Name = "Subway" });
        // projects.Add(new Project() { Id = 20, Name = "Bus station" });
        // projects.Add(new Project() { Id = 21, Name = "Renovation of an old church" });
        //
        // buildingTypes.Add(new BuildingType() {TypeName = "house" });
        // buildingTypes.Add(new BuildingType() {TypeName = "appartmant" });
        // buildingTypes.Add(new BuildingType() {TypeName = "mansion" });
        //
        // buildingTypes.Add(new BuildingType() {TypeName = "farm" });
        // buildingTypes.Add(new BuildingType() {TypeName = "skyscaper" });
        // buildingTypes.Add(new BuildingType() {TypeName = "compani" });
        //
        // buildingTypes.Add(new BuildingType() {TypeName = "office" });
        // buildingTypes.Add(new BuildingType() {TypeName = "restaurant" });
        // buildingTypes.Add(new BuildingType() {TypeName = "kino" });
        // buildingTypes.Add(new BuildingType() {TypeName = "theater" });

    }
}
