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
            SeedEmployee();
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
            Console.WriteLine(eService.AddEmployee("Kaira", "Anderson ",  "Via del Corso 15", "Otawa", "Commercial Architecture", "0947936248", "architect_anderson@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Rebeca", "Wimbley", "Via dei Fori 16", "Paris", "PR management", "08547936248", "architect_wimbley@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Stephany", "Baker", "Via Vento 8", "Pazardzhik", "Commercial Architecture", "0847936248", "architect_baker@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Atidje", "Bursin", "Via Appia Antica 10", "Pernik", "Interior Design", "0854793624", "architect_bursin@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Salihe", "Ercel", "Vitosha Boulevard 10", "Plovdiv", "Industrial Architecture", "0854793628", "architect_ercel@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Avishe", "Kaya", "Graf Ignatiev 10", "Porto", "Landscape Architecture", "0817936248", "architect_kaya@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Bryan", "Conar", "Hristo Botev str 25", "Blagoevgrad", "Residential Architecture", "08547777248", "architect_conar@gmail.com"));
            Console.WriteLine(eService.AddEmployee("Jeremiah", "Connard", "--", "---", "Interior Design", "08547985858", "architect_connard@gmail.com"));
           
        }
        public static void SeedClientAddress()
        {
            List<string> a = new List<string>();
            a.Add("Aalto Place");
            a.Add("Abana Path");
            a.Add("Abasco Court");
            a.Add("Abney Avenue");
            a.Add("Adrienne Way");
            a.Add("Aintree Lane");
            a.Add("Brampton Street");
            a.Add("Brandy Street ");
            a.Add("Dyson Loop");
            a.Add("Eaton Terrace");
            a.Add("Foxbridge Terrace");
            a.Add("Franklin Court");
            a.Add("Guerra Avenue");
            a.Add("Harston Trail");
            a.Add("Harleston Street");
            a.Add("Jetta Way");
            a.Add("Joiner Place");
            a.Add("Medford Place");
            a.Add("Millhorn Loop");
            a.Add("Odell Circle");
            for (int i = 0; i < 25; i++)
            {
                Random r = new Random();
                string addressname = a[i];
                List<string> towns = aService.GetTownsNames();
                Console.WriteLine(aService.AddAddress(addressname, towns[i]));
            }
        }
    }
}
