using System;
using System.Collections.Generic;
using System.Numerics;
using ArchitectureCompany.Models;
using ArchitectureCompany.Services;
namespace Architecture.Company.DataSeeder
{
    public class Program
    {
        private static DepartmentService dService = new DepartmentService();
        private static EmployeeService eService = new EmployeeService();
        private static AdditionalService aService = new AdditionalService();
        static void Main()
        {
            SeedAddress();
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

            for (int i = 0; i < 30; i++)
            {
                string name = t[i];
                Console.WriteLine(aService.AddTown(name));
            }
        }
        public static void SeedAddress()
        {
            List<string> a = new List<string>();
            a.Add("Main Street 23");
            a.Add("Main Street 7");
            a.Add("Park Avenue 9");
            a.Add("Broadway 10");
            a.Add("Oak Street 9");
            a.Add("High Street 7");
            a.Add("Maple Avenue 7");
            a.Add("Market Street 9");
            a.Add("Pine Street 4");
            a.Add("Church Street 3");
            a.Add("King Street 5");
            a.Add("Lombard Street 7");
            a.Add("5th Avenue 9");
            a.Add("Sunset Boulevard 8");
            a.Add("Canal Street 5");
            a.Add("Peachtree Street 23");
            a.Add("Bourbon Street 12");
            a.Add("Rodeo Drive 13");
            a.Add("Mongolia Avenue 14");
            a.Add("Via del Corso 15");
            a.Add("Via dei Fori 16");
            a.Add("Via Vento 8");
            a.Add("Via Appia Antica 10");
            a.Add("Vitosha Boulevard 10");
            a.Add("Graf Ignatiev 10");
            a.Add("Macedonia Street 10");
            a.Add("Varna Boulevard 10");
            for (int i = 0; i < 25; i++)
            {
                Random r = new Random();
                string addressname = a[i];
                List<string> towns = aService.GetTownsNames();
                Console.WriteLine(aService.AddAddress(addressname, towns[i]));
            }
        }
        public static void SeedEmployee()
        {
            List<string> firstName = new List<string>() { "Serkan", "Eda", "Kiraz", "Selin", "Kiara", "Kerem", "Aleph", "Quintessa", "Margarette", "Oscar", "Sebastian", "Zane", "Mabel", "Leo", "Scarlett", "Yasemin", "Caleb" };
            List<string> lastName = new List<string>() { "Bolat", "Yaldiz", "Karadaa", "Smith", "Williams", "Johnson", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson" };
            List<string> phoneNumber = new List<string>() { "08547936248", "0889654785", "0874856921", "0889523652", "0985746985", "0887441563", "0888525252", "0896323235", "0888897562", "0814766666", "0888877456", "0889955555", "08547936240", "08547936247", "08547936245", "08547936278", "085479362948", "08547036248", "09547936248", "09747936248", "09847936248", "09047936248", "09549936248", "09447936248", "09247936248", "09547939248", "0879658758", "0123589745", "0897452122", "0888550000", "0800226547" };
            List<string> addresses = new List<string>() { "Main Street 7", "Park Avenue 9", "Broadway 10", "Oak Street 9", "High Street 7", "Maple Avenue 7", "Market Street 9", "Pine Street 4", "Church Street 3", "King Street 5", "Lombard Street 7", "5th Avenue 9", "Sunset Boulevard 8", "Canal Street 5", "Peachtree Street 23", "Bourbon Street 12", "Rodeo Drive 13", "Mongolia Avenue 14", "Via del Corso 15", "Via dei Fori 16", "Via Vento 8", "Via Appia Antica 10", "Vitosha Boulevard 10", "Graf Ignatiev 10", "Macedonia Street 10", "Varna Boulevard 10" };
            List<string> emails = new List<string>() { "architect_j@gmail.com", "arttLife1@gmail.com", "building_constructor@abv.bg", "architecture_company@gmail.com", "sb_artlife@gmail.com", "ey_architecture@gmail.com", "artlife_kb@abv.bg", "ny_architecture@gmail.com", "bp_architecture@gmail.com", "ct_architecture@gmail.com", "et_architecture@gmail.com", "eda_architecture@gmail.com", "ey_architect@gmail.com", "brr_architecture@gmail.com", "da_architecture@gmail.com", "project_architecture@gmail.com" };
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                int employeeFirstName = random.Next(0, firstName.Count);
                int employeeLastName = random.Next(0, lastName.Count);
                int addrsssIndex = 0;
                string addressname = addresses[addrsssIndex];
                string town = aService.GetTownOfAddressByName(addressname);
                List<string> departments = dService.GetDepartmentName();
                int email = random.Next(0, emails.Count);
                int phoneIndex = 0;
                string phone = phoneNumber[phoneIndex];
                Console.WriteLine(eService.AddEmployee(firstName[employeeFirstName], lastName[employeeLastName], addresses[addrsssIndex], town, departments[i], phone, emails[email]));
                ++phoneIndex;
                ++addrsssIndex;
            }

        }
    }
}
