using System;
using System.Collections.Generic;
using System.Globalization;
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
        private static ClientService cService = new ClientService();
        private static ProjectService pService = new ProjectService();
        static void Main()
        {
             SeedTowns();
             SeedBuildingType();
             SeedDepartments();
             SeedAddress();
             SeedEmployee();
             SeedClientAddress();
             SeedClient();
             SeedProjects();
        }
        public static void SeedDepartments()
        {
            try
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

                for (int i = 0; i < d.Count; i++)
                {
                    string name = d[i];
                    Console.WriteLine(dService.AddDepartment(name));
                }
            }
            catch (Exception)
            {

            }
        }
        public static void SeedTowns()
        {
            try
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

                for (int i = 0; i < t.Count; i++)
                {
                    string name = t[i];
                    Console.WriteLine(aService.AddTown(name));
                }
            }
            catch (Exception)
            {

            }

        }
        public static void SeedAddress()
        {
            try
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
                for (int i = 0; i < a.Count; i++)
                {
                    string addressname = a[i];
                    List<string> towns = aService.GetTownsNames();
                    Console.WriteLine(aService.AddAddress(addressname, towns[i]));
                }
            }
            catch (Exception)
            {

            }

        }
        public static void SeedEmployee()
        {
            try
            {
                Console.WriteLine(eService.AddEmployee("Serkan", "Bolat", "Rodeo Drive 13", "New York", "Industrial Architecture", "0054703620", "architect_ceo@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Eda", "Yildiz", "Main Street 23", "Bansko", "Landscape Architecture", "0829654785", "arttLife1@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Kiraz", "Karadaa", "Main Street 7", "Barcelona", "Green Design Architecture", "0874856921", "building_constructor@abv.bg"));
                Console.WriteLine(eService.AddEmployee("Kiara", " Smith", "Park Avenue 9", "Berlin", "Urban Design", "0874793624", "architect_jb@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Joan", "Williams", "Broadway 10", "Blagoevgrad", "PR management", "0857936241", "architecture_j@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Aleph", "Cansli", "Oak Street 9", "Buenos Aires", "Commercial Architecture", "0147936248", "aarchitect_j@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Quintessa", "Johnson", "Maple Avenue 7", "Ciro", "Residential Architecture", "0547936248", "architect_johnson@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Margarette", "Brown", "Market Street 9", "Dubai", "Industrial Architecture", "3547936248", "architect_brown@gmail.com"));
                Console.WriteLine(eService.AddEmployee(" Oscar", "Jones", "Pine Street 4", "Helzinki", "Industrial Architecture", "55547936248", "architect_odcar@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Sebastian", "Garcia", "Church Street 3", "Limasol", "Residential Architecture", "8547936111", "architect_garcia@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Zane", "Miller", "King Street 5", "Lisbon", "Interior Design", "085479388", "architect_miller@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Mabel", "Davis", "Lombard Street 7", "London", "Urban Design", "0854553624", "architect_davis@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Leo", "Rodriguez", "5th Avenue 9", "Madrid", "PR management", "0877798824", "architect_rodriges@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Scarlett", "Martinez", "Sunset Boulevard 8", "Manchester", "Interior Design", "0994793624", "architect_martinez@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Yasemin", " Hernandez", "Canal Street 5", "Monaco", "Urban Design", "2540036248", "architect_yasemin@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Caleb", "Lopez", "Peachtree Street 23", "Montevideo", "Industrial Architecture", "1547333248", "architect_lopez@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Greg", "Gonzalez", "Bourbon Street 12", "Munchen", "Commercial Architecture", "7547936248", "architect_g@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Amalia", "Wilson", "Mongolia Avenue 14", "Normandy", "Landscape Architecture", "8547936248", "architect_willson@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Kaira", "Anderson ", "Via del Corso 15", "Otawa", "Commercial Architecture", "0947936248", "architect_anderson@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Rebeca", "Wimbley", "Via dei Fori 16", "Paris", "PR management", "08547936248", "architect_wimbley@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Stephany", "Baker", "Via Vento 8", "Pazardzhik", "Commercial Architecture", "0847936248", "architect_baker@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Atidje", "Bursin", "Via Appia Antica 10", "Pernik", "Interior Design", "0854793624", "architect_bursin@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Salihe", "Ercel", "Vitosha Boulevard 10", "Plovdiv", "Industrial Architecture", "0854793628", "architect_ercel@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Avishe", "Kaya", "Graf Ignatiev 10", "Porto", "Landscape Architecture", "0817936248", "architect_kaya@gmail.com"));
                Console.WriteLine(eService.AddEmployee("Bryan", "Conar", "Hristo Botev str 25", "Blagoevgrad", "Residential Architecture", "08547777248", "architect_conar@gmail.com"));

            }
            catch (Exception)
            {


            }


        }
        public static void SeedClientAddress()
        {
            try
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
                for (int i = 0; i < a.Count; i++)
                {
                    string addressname = a[i];
                    List<string> towns = aService.GetTownsNames();
                    Console.WriteLine(aService.AddAddress(addressname, towns[i]));
                }
            }
            catch (Exception)
            {

            }

        }
        public static void SeedClient()
        {
            try
            {
                Console.WriteLine(cService.AddClient("Samanta", "Gregory", "Abana Path", "Bansko", "0888552200", "samanta_12@gmail.com"));
                Console.WriteLine(cService.AddClient("Olivia", "Rodrigo", "Abasco Court", "Barcelona", "0833333333", "oliviarodrigo1@abv.bg"));
                Console.WriteLine(cService.AddClient("Kate", "Pausley", "Abney Avenue", "Berlin", "0777777777", "katep@abv.bg"));
                Console.WriteLine(cService.AddClient("Darvin", "Smith", "Adrienne Way", "Blagoevgrad", "0123456789", "darvin@abv.bg"));
                Console.WriteLine(cService.AddClient("Francis", "Genoa", "Aintree Lane", "Buenos Aires", "7894561230", "francis@abv.bg"));
                Console.WriteLine(cService.AddClient("Paola", "Pedres", "Brampton Street", "Burgas", "0111111111", "paola@abv.bg"));
                Console.WriteLine(cService.AddClient("Carlos", "Stone", "Brandy Street", "Ciro", "0222225555", "carlos2gmail.com"));
                Console.WriteLine(cService.AddClient("Derin", "Denizli", "Dyson Loop", "Dubai", "9023201562", "derin@gmail.com"));
                Console.WriteLine(cService.AddClient("Preslava", "Filipova", "Eaton Terrace", "Helzinki", "7000099999", "presi@abv.bg"));
                Console.WriteLine(cService.AddClient("Amaya", "Mitchel", "Foxbridge Terrace", "Limasol", "0993333000", "amaya@abv.bg"));
                Console.WriteLine(cService.AddClient("Sara", "Cameron", "Franklin Court", "Lisbon", "5987469874", "sara@gmail.com"));
                Console.WriteLine(cService.AddClient("Samuel", "Ibrahimovic", "Guerra Avenue", "London", "7310555666", "samuel@abv.bg"));
                Console.WriteLine(cService.AddClient("Benjamin", "Fronch", "Harston Trail", "Madrid", "5333322015", "benju@abv.bg"));
                Console.WriteLine(cService.AddClient("Elizabeth", "Robby", "Harleston Street", "Manchester", "6666666520", "beth@abv.bg"));
                Console.WriteLine(cService.AddClient("Darian", "Gibert", "Jetta Way", "Monaco", "1177445544", "darian@gmail.com"));
                Console.WriteLine(cService.AddClient("Nilson", "Pitcher", "Joiner Place", "Montevideo", "5532000000", "nil@abv.bg"));
                Console.WriteLine(cService.AddClient("Halil", "Goztepe", "Medford Place", "Munchen", "9990044444", "halil@gmail.com"));
                Console.WriteLine(cService.AddClient("Ferid", "Azanci", "Milhorn Loop", "New York", "5555222222", "ferid@abv.bg"));
                Console.WriteLine(cService.AddClient("Casteel", "Atlantic", "Odell Circle", "Normandy", "4444000000", "cas@abv.bg"));

            }
            catch (Exception)
            {

            }

        }
        public static void SeedBuildingType()
        {
            try
            {
                List<string> bt = new List<string>();
                bt.Add("Residential Buildings");
                bt.Add("Commercial Buildings ");
                bt.Add("Industrial Buildings");
                bt.Add("Educational Buildings");
                bt.Add("Institutional Buildings");
                bt.Add("Religious Buildings ");
                bt.Add("Recreational Buildings ");
                bt.Add("Transportation Buildings ");
                bt.Add("Skyscrapers ");
                bt.Add("Hotels");
                bt.Add("Residential Care Facilities ");

                for (int i = 0; i < bt.Count; i++)
                {
                    string name = bt[i];
                    Console.WriteLine(aService.AddBuildingType(name));
                }
            }
            catch (Exception)
            {

            }

        }
        public static void SeedProjects()
        {
            try
            {
                string releasedDate = "12-03-2025";
                DateTime data = new DateTime();
                bool v = DateTime.TryParseExact(releasedDate, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
                Console.WriteLine(pService.AddProject("The Opera house", "Industrial Buildings", 500, data, 1500, 5, "Eaton Terrace", "Sofia"));

                string releasedDate2 = "09-08-2021";
                DateTime data2 = new DateTime();
                bool v2 = DateTime.TryParseExact(releasedDate2, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data2);
                Console.WriteLine(pService.AddProject("The Lighthouse", "Residential Buildings", 70, data2, 700, 3, "Via dei Fori 16", "Paris"));

                string releasedDate3 = "13-03-2024";
                DateTime data3 = new DateTime();
                bool v3 = DateTime.TryParseExact(releasedDate3, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data3);
                Console.WriteLine(pService.AddProject("The Disney Concert Hall", "Commercial Buildings", 490, data3, 1500, 3, "Foxbridge Terrace", "Limasol"));

                string releasedDate4 = "28-09-2030";
                DateTime data4 = new DateTime();
                bool v4 = DateTime.TryParseExact(releasedDate4, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data4);
                Console.WriteLine(pService.AddProject("The Olimpic Stadium", "Institutional Buildings", 2000, data4, 2900, 1, "Abney Avenue", "Berlin"));

                string releasedDate5 = "04-02-2021";
                DateTime data5 = new DateTime();
                bool v5 = DateTime.TryParseExact(releasedDate5, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data5);
                Console.WriteLine(pService.AddProject("The Stadium", "Institutional Buildings", 1000, data5, 2000, 1, "Joiner Place", "Montevideo"));

                string releasedDate6 = "20-05-2028";
                DateTime data6 = new DateTime();
                bool v6 = DateTime.TryParseExact(releasedDate6, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data6);
                Console.WriteLine(pService.AddProject("The Sky Garden", "Hotels", 1000, data6, 895, 5, "Duson Loop", "Dubai"));

                string releasedDate7 = "28-06-2016";
                DateTime data7 = new DateTime();
                bool v7 = DateTime.TryParseExact(releasedDate7, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data7);
                Console.WriteLine(pService.AddProject("The Floating City", "Skyscrapers ", 1200, data7, 490, 50, "Chirch Street 3", "Limasol"));

                string releasedDate8 = "08-10-2026";
                DateTime data8 = new DateTime();
                bool v8 = DateTime.TryParseExact(releasedDate8, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data8);
                Console.WriteLine(pService.AddProject("The Oasis", "Hotels", 526, data8, 59, 6, "Harston Trail", "Madrid"));

                string releasedDate9 = "9-08-2021";
                DateTime data9 = new DateTime();
                bool v9 = DateTime.TryParseExact(releasedDate9, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data9);
                Console.WriteLine(pService.AddProject("The Beach House", "Recreational Buildings ", 565, data9, 545, 5, "Brampton Street", "Burgas"));

                string releasedDate10 = "12-09-2034";
                DateTime data10 = new DateTime();
                bool v10 = DateTime.TryParseExact(releasedDate10, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data10);
                Console.WriteLine(pService.AddProject("The Lake House", "Commercial Buildings ", 55, data10, 566, 5, "5th Avenue 9", "Madrid"));

                string releasedDate11 = "22-09-2005";
                DateTime data11 = new DateTime();
                bool v11 = DateTime.TryParseExact(releasedDate11, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data11);
                Console.WriteLine(pService.AddProject("The Mansion", "Residential Care Facilities ", 50, data11, 456, 7, "Bor str 15", "Plovdiv"));

                string releasedDate12 = "30-04-2020";
                DateTime data12 = new DateTime();
                bool v12 = DateTime.TryParseExact(releasedDate12, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data12);
                Console.WriteLine(pService.AddProject("The Skyscraper", "Skyscrapers ", 598, data12, 989, 50, "Via Vento 8", "Pazardzhik"));
            }
            catch (Exception)
            {

            }

        }

    }
}
