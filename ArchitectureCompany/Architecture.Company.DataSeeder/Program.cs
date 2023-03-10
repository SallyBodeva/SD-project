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
        public static void SeedEmployeeFail()
        {
            List<string> a = new List<string>();
            List<string> firstName = new List<string>() {  "Zane", "Mabel", "Leo", "Scarlett", "Yasemin", "Caleb" };
            List<string> lastName = new List<string>() {   "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson" };
            List<string> phoneNumber = new List<string>() {  "0889523652", "0985746985", "0887441563", "0888525252", "0896323235", "0888897562", "0814766666", "0888877456", "0889955555", "08547936240", "08547936247", "08547936245", "08547936278", "085479362948", "08547036248", "09547936248", "09747936248", "09847936248", "09047936248", "09549936248", "09447936248", "09247936248", "09547939248", "0879658758", "0123589745", "0897452122", "0888550000", "0800226547" };
            List<string> addresses = new List<string>() { "Main Street 7", "Park Avenue 9", "Broadway 10", "Oak Street 9", "High Street 7", "Maple Avenue 7", "Market Street 9", "Pine Street 4", "Church Street 3", "King Street 5", "Lombard Street 7", "5th Avenue 9", "Sunset Boulevard 8", "Canal Street 5", "Peachtree Street 23", "Bourbon Street 12", "Rodeo Drive 13", "Mongolia Avenue 14", "Via del Corso 15", "Via dei Fori 16", "Via Vento 8", "Via Appia Antica 10", "Vitosha Boulevard 10", "Graf Ignatiev 10", "Macedonia Street 10", "Varna Boulevard 10" };
            List<string> emails = new List<string>() {  "architecture_company@gmail.com", "sb_artlife@gmail.com", "ey_architecture@gmail.com", "artlife_kb@abv.bg", "ny_architecture@gmail.com", "bp_architecture@gmail.com", "ct_architecture@gmail.com", "et_architecture@gmail.com", "eda_architecture@gmail.com", "ey_architect@gmail.com", "brr_architecture@gmail.com", "da_architecture@gmail.com", "project_architecture@gmail.com" };
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
        public static void SeedEmployee()
        {
            Console.WriteLine(eService.AddEmployee("Serkan","Bolat", "Rodeo Drive 13","New York", "Industrial Architecture", "0054703620", "architect_ceo@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Eda", "Yildiz", "Main Street 23", "Bansko", "Landscape Architecture", "0829654785", "arttLife1@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Kiraz", "Karadaa", "Main Street 7", "Barcelona", "Green Design Architecture", "0874856921", "building_constructor@abv.bg"));
            Console.WriteLine(eService.AddEmployee( "Kiara", " Smith", "Park Avenue 9", "Berlin", "Urban Design", "0874793624", "architect_jb@gmail.com"));
            Console.WriteLine(eService.AddEmployee( "Joan",   "Williams", "Broadway 10" , "Blagoevgrad", "PR management", "0857936241", "architecture_j@gmail.com"));
            Console.WriteLine(eService.AddEmployee( "Aleph", "Cansli", "Oak Street 9", "Buenos Aires", "Commercial Architecture", "0147936248", "aarchitect_j@gmail.com"));
            Console.WriteLine(eService.AddEmployee( "Quintessa", "Johnson", "Maple Avenue 7", "Ciro", "Residential Architecture", "0547936248", "architect_johnson@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Margarette", "Brown", "Market Street 9", "Dubai", "Industrial Architecture", "3547936248", "architect_brown@gmail.com"));
            Console.WriteLine(eService.AddEmployee(" Oscar", "Jones",  "Pine Street 4",  "Helzinki", "Industrial Architecture", "55547936248", "architect_odcar@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Sebastian","Garcia", "Church Street 3", "Limasol", "Residential Architecture", "8547936111", "architect_garcia@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Zane", "Miller", "King Street 5",  "Lisbon", "Interior Design", "085479388", "architect_miller@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Mabel",   "Davis", "Lombard Street 7", "London", "Urban Design", "0854553624", "architect_davis@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Leo", "Rodriguez",  "5th Avenue 9",   "Madrid", "PR management", "0877798824", "architect_rodriges@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Scarlett",  "Martinez", "Sunset Boulevard 8","Manchester", "Interior Design", "0994793624", "architect_martinez@gmail.com"));
            Console.WriteLine(eService.AddEmployee( "Yasemin", " Hernandez", "Canal Street 5", "Monaco", "Urban Design", "2540036248", "architect_yasemin@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Caleb",  "Lopez", "Peachtree Street 23", "Montevideo", "Industrial Architecture", "1547333248", "architect_lopez@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Greg", "Gonzalez", "Bourbon Street 12", "Munchen", "Commercial Architecture", "7547936248", "architect_g@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Amalia", "Wilson", "Mongolia Avenue 14", "Normandy", "Landscape Architecture", "8547936248", "architect_willson@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Kaira", "Anderson ",  "Via del Corso 15", "Otawa", "Commercial Architecture", "0547936248", "architect_anderson@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Rebeca", "Wimbley", "Via dei Fori 16", "Paris", "PR management", "08547936248", "architect_wimbley@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Stephany", "Baker", "Via Vento 8", "Pazardzhik", "Commercial Architecture", "0847936248", "architect_baker@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Atidje", "Bursin", "Via Appia Antica 10", "Pernik", "Interior Design", "0854793624", "architect_bursin@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Salihe", "Ercel", "Vitosha Boulevard 10", "Plovdiv", "Industrial Architecture", "0854793628", "architect_ercel@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Avishe", "Kaya", "Graf Ignatiev 10", "Porto", "Landscape Architecture", "0817936248", "architect_kaya@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Bryan", "Conar", "Hristo Botev str 25", "Blagoevgrad", "Residential Architecture", "08547777248", "architect_conar@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Jeremiah", "Connard", "--", "---", "Interior Design", "08547985858", "architect_connard@gmail.com"));
           


        }
    }
}
