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

            for (int i = 0; i < 65; i++)
            {
                string name = t[i];
                Console.WriteLine(addiotionalService.AddTown(name));
            }
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
                Console.WriteLine(departmentService.AddDepartment(name));
            }

        }
       
        public static void SeedAddresses()
        {
            List<string> a = new List<string>();

            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                string name = a[i];

                // a problem with foreign key- the collection(e.g. "t" )is not found)
                //string town = t[r.Next(1, 20)];
             //   Console.WriteLine(addiotionalService.AddAddress(name,town));
            }
        }
        
        public static void SeedEmployee()
        {
            List<string> firstName = new List<string>() { "Jane", "Lenore", "Susy", "Genna", "Viki", "Toni", "Serkan", "Eda", "Kiraz", "Selin", "Engin", "Steven", "Barbara", "Kiara", "Kerem", "Aleph", "Quintessa", "Margarette", "Oscar", "Sebastian", "Zane", "Mabel", "Leo", "Scarlett", "Yasemin", "Caleb" };
            List<string> lastName = new List<string>() { "Stove", "Lobile", "Dykas", "Larne", "Romera", "Borrel", "Bolat", "Yaldiz", "Karadaa", "Smith", "Williams", "Johnson", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson" };

            List<string> phoneNumber = new List<string>() { "08547936248","0889654785","0874856921","0889523652","0985746985","0887441563","0888525252","0896323235","0888897562","0814766666","0888877456","0889955555"};
            List<string> emails = new List<string>() { "architect_j@gmail.com", "arttLife1@gmail.com", "building_constructor@abv.bg", "architecture_company@gmail.com", "sb_artlife@gmail.com", "ey_architecture@gmail.com", "artlife_kb@abv.bg", "ny_architecture@gmail.com", "bp_architecture@gmail.com", "ct_architecture@gmail.com", "et_architecture@gmail.com", "eda_architecture@gmail.com", "ey_architect@gmail.com", "brr_architecture@gmail.com", "da_architecture@gmail.com", "project_architecture@gmail.com" };
            Random random = new Random();

            for (int i = 0; i < 50; i++)
            {
                int employeeFirstName = random.Next(0, firstName.Count);
                int employeeLastName = random.Next(0, lastName.Count);
                // a problem with foreign key- the collection(e.g. "a" )is not found)
               // string address = a[random.Next(1, 20)];
                //string town = t[random.Next(1, 20)];
                //string department = d[random.Next(1, 20)];
                int phoneNum=random.Next(0,phoneNumber.Count);
                int email = random.Next(0, emails.Count);
                //  Console.WriteLine(EmployeeService.AddEmployee(firstName[employeeFirstName], lastName[employeeLastName],address ,town,department,phoneNumber[phoneNum],emails[emial]));
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
                // a problem with foreign key- the collection(e.g. "a" )is not found)
                int employeeFirstName = random.Next(0, firstName.Count);
                int employeeLastName = random.Next(0, lastName.Count);
                //string address = a[random.Next(1, 20)];
                //string town = t[random.Next(1, 20)];             
                int phoneNum = random.Next(0, phoneNumber.Count);
                int email = random.Next(0, emails.Count);
                //  Console.WriteLine(EmployeeService.AddEmployee(firstName[employeeFirstName], lastName[employeeLastName],address ,town,phoneNumber[phoneNum],emails[emial]));
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
        // public static void SeedAdresses()
        // {
        //   List<string> a = new List<string>();
        // a.Add("Main Street");
        //a.Add("Main Street");
        // a.Add("Park Avenue");
        // a.Add("Broadway");
        // a.Add("Oak Street");
        // a.Add("High Street");
        //a.Add("Maple Avenue");
        //a.Add("Market Street");
        //a.Add("Pine Street");
        //a.Add("Church Street");
        //a.Add("King Street");
        //a.Add("Lombard Street");
        //a.Add("5th Avenue");
        //a.Add("Sunset Boulevard");
        //a.Add("Canal Street");
        //a.Add("Peachtree Street");
        //a.Add("Bourbon Street");
        //a.Add("Rodeo Drive");
        //a.Add("Mongolia Avenue");
        //a.Add("Via del Corso");
        //a.Add("Via dei Fori");
        //a.Add("Via Vento");
        //a.Add("Via Appia Antica");
        // a.Add("Vitosha Boulevard");
        //a.Add("Graf Ignatiev");
        //a.Add("Macedonia Street");
        // a.Add("Varna Boulevard");

        //  for (int i = 0; i < 27; i++)
        // {
        //     string name = a[i];
        //    Console.WriteLine(addiotionalService.AddAddress(name));
        // }
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




   
 
