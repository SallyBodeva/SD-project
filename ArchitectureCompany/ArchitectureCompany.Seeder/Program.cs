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
        private static EmployeeService employeeService = new EmployeeService();
        private static ClientService clientService = new ClientService();

        List<Project> projects = new List<Project>();
        List<BuildingType> buildingTypes = new List<BuildingType>();
        static List<string> d = new List<string>();
        static List<string> t = new List<string>();
        static void Main()
        {

        }
        public static void SeedTowns()
        {
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
                Console.WriteLine(addiotionalService.AddTown(name));
            }
        }
        public static void SeedDepartments()
        {

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
            Random r = new Random();
            for (int i = 0; i < a.Count; i++)
            {
               string name = a[i];
            //   string town = 
          //     Console.WriteLine(addiotionalService.AddAddress(name, town));
            }
            
        }

        public static void SeedEmployee()
        {
            List<string> firstName = new List<string>() { "Jane", "Lenore", "Susy", "Genna", "Viki", "Toni", "Serkan", "Eda", "Kiraz", "Selin", "Engin", "Steven", "Barbara", "Kiara", "Kerem", "Aleph", "Quintessa", "Margarette", "Oscar", "Sebastian", "Zane", "Mabel", "Leo", "Scarlett", "Yasemin", "Caleb" };
            List<string> lastName = new List<string>() { "Stove", "Lobile", "Dykas", "Larne", "Romera", "Borrel", "Bolat", "Yaldiz", "Karadaa", "Smith", "Williams", "Johnson", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson" };

            List<string> phoneNumber = new List<string>() { "08547936248", "0889654785", "0874856921", "0889523652", "0985746985", "0887441563", "0888525252", "0896323235", "0888897562", "0814766666", "0888877456", "0889955555", "08547936240", "08547936247", "08547936245", "08547936278", "085479362948", "08547036248", "09547936248", "09747936248", "09847936248", "09047936248", "09549936248", "09447936248", "09247936248", "09547939248","0879658758","0123589745","0897452122","0888550000","0800226547" };
            List<string> emails = new List<string>() { "architect_j@gmail.com", "arttLife1@gmail.com", "building_constructor@abv.bg", "architecture_company@gmail.com", "sb_artlife@gmail.com", "ey_architecture@gmail.com", "artlife_kb@abv.bg", "ny_architecture@gmail.com", "bp_architecture@gmail.com", "ct_architecture@gmail.com", "et_architecture@gmail.com", "eda_architecture@gmail.com", "ey_architect@gmail.com", "brr_architecture@gmail.com", "da_architecture@gmail.com", "project_architecture@gmail.com" };
            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                int employeeFirstName = random.Next(0, firstName.Count);
                int employeeLastName = random.Next(0, lastName.Count);              
                int address = random.Next(0, firstName.Count);
                int town = random.Next(0, lastName.Count);
                int department = random.Next(0, d.Count);
                int email = random.Next(0, emails.Count);
                for (int j = 0; j < phoneNumber.Count; j++)
                {
                    int pNum = random.Next(0, phoneNumber.Count);
                    string phone = phoneNumber[i];
                 //   Console.WriteLine(employeeService.AddEmployee(firstName[employeeFirstName], lastName[employeeLastName], a[address], t[town], d[department], phone, emails[email]));
                }
            }

        }
        public static void SeedClient()
        {

            List<string> firstName = new List<string>() { "Jane", "Lenore", "Susy", "Genna", "Viki", "Toni", "Serkan", "Eda", "Kiraz", "Selin", "Engin", "Steven", "Barbara", "Kiara", "Kerem", "Aleph", "Quintessa", "Margarette", "Oscar", "Sebastian", "Zane", "Mabel", "Leo", "Scarlett", "Yasemin", "Caleb" };
            List<string> lastName = new List<string>() { "Stove", "Lobile", "Dykas", "Larne", "Romera", "Borrel", "Bolat", "Yaldiz", "Karadaa", "Smith", "Williams", "Johnson", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson" };

            List<string> phoneNumber = new List<string>() { "08547936248", "0889654785", "0874856921", "0889523652", "0985746985", "0887441563", "0888525252", "0896323235", "0888897562", "0814766666", "0888877456", "0889955555" };
            List<string> emails = new List<string>() { "architect_j@gmail.com", "arttLife1@gmail.com", "building_constructor@abv.bg", "architecture_company@gmail.com", "sb_artlife@gmail.com", "ey_architecture@gmail.com", "artlife_kb@abv.bg", "ny_architecture@gmail.com", "bp_architecture@gmail.com", "ct_architecture@gmail.com", "et_architecture@gmail.com", "eda_architecture@gmail.com", "ey_architect@gmail.com", "brr_architecture@gmail.com", "da_architecture@gmail.com", "project_architecture@gmail.com" };
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
               
                int employeeFirstName = random.Next(0, firstName.Count);
                int employeeLastName = random.Next(0, lastName.Count);
               // string address = a[random.Next(1, 20)];
           //     string town = t[random.Next(1, 20)];
                int phoneNum = random.Next(0, phoneNumber.Count);
                int email = random.Next(0, emails.Count);
                // Console.WriteLine(clientService.AddClient(firstName[employeeFirstName], lastName[employeeLastName], address, town, phoneNumber[phoneNum], emails[email]));
            }
        }


        public static void SeedBulidingTypes()
        {
            List<string> bt = new List<string>();
            //bt.Add("Residential Buildings");
            //bt.Add("Commercial Buildings ");
            //bt.Add("Industrial Buildings");
            //bt.Add("Educational Buildings");
            //bt.Add("Institutional Buildings");
            //bt.Add("Religious Buildings ");
            //bt.Add("Recreational Buildings ");
            //bt.Add("Transportation Buildings ");
            //bt.Add("Skyscrapers ");           
            // bt.Add("Hotels");
            //bt.Add("Residential Care Facilities ");

            //for (int i = 0; i < 12; i++)
            //{
            //   string name = bt[i];
            // Console.WriteLine(projectService.AddProject(buildingTypeId));
            //}
        }
        


        //  public static void SeedProjects()
        // {
        //  List<string> p = new List<string>();
        //  p.Add("The Opera house");
        // p.Add("The Lighthouse");
        //p.Add("The National Musem");
        //p.Add("The EcoARK");
        //p.Add("The Fallingwater");
        //p.Add("The National Centetr for the Performings Art");
        // p.Add("The Museum of Islamic Art");
        //p.Add("The Disney Concert Hall");
        // p.Add("The Olimpic Stadium");
        // p.Add("The Stadium");
        // p.Add("The Sky Garden");
        // p.Add("The Floating City");
        // p.Add("The Time Travel Museum");
        // p.Add("The Nexus Tower");
        // p.Add("The Hydrogen House");
        // p.Add("The Oasis");
        // p.Add("The Arcology");
        // p.Add("The Cloud");
        // p.Add("The Eden Project");
        // p.Add("The Kinder Garden");
        // p.Add("The Children's Corner");
        // p.Add("The Beach House");
        // p.Add("The Lake House");
        // p.Add("The Mansion");
        // p.Add("The Farm");
        // p.Add("The Skyscraper");
        // p.Add("The Theater");
        // p.Add("The Kino");
        // p.Add("The Fitness");
        // p.Add("The Hotel");
        // p.Add("The Hospital");
        // p.Add("The Police");
        // p.Add("The Mall");
        // p.Add("The Appartment");
        // p.Add("The Office");
        //p.Add("The Resturant");
        //p.Add("The School");
        //p.Add("The University");
        // p.Add("The Library");
        // p.Add("The Government");
        // p.Add("The Church");
        // p.Add("The Stubway");
        //p.Add("The Rehabilitation Center");




        //for (int i = 0; i < 30; i++)
        //{
        //   string name = p[i];
        //   Console.WriteLine(projectService.AddProject(name));
        //}
    }
}






