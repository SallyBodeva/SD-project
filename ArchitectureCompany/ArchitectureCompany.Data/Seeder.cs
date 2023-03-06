namespace ArchitectureCompany.Data
{
    using ArchitectureCompany.Models;
  

    using System;
    using System.Collections.Generic;

    public class Seeder
    {
       
        public Seeder()
        {
            SeedTowns();
        }

        public static void SeedTowns()
        {
            
            List<Town> towns = new List<Town>();
            List<Project> projects = new List<Project>();

            towns.Add(new Town() { Id = 1, Name = "Plovdiv" });
            towns.Add(new Town() { Id = 2, Name = "Pazardzhik" });
            towns.Add(new Town() { Id = 3, Name = "Sofia" });
            towns.Add(new Town() { Id = 4, Name = "Varna" });
            towns.Add(new Town() { Id = 5, Name = "Ruse" });
            towns.Add(new Town() { Id = 6, Name = "Blagoevgrad" });
            towns.Add(new Town() { Id = 7, Name = "Burgas" });
            towns.Add(new Town() { Id = 8, Name = "Velingrad" });
            towns.Add(new Town() { Id = 9, Name = "Bansko" });
            towns.Add(new Town() { Id = 10, Name = "Svishtov" });
            towns.Add(new Town() { Id = 11, Name = "Sliven" });
            towns.Add(new Town() { Id = 12, Name = "Stara Zagora" });
            towns.Add(new Town() { Id = 13, Name = "Nova Zagora" });
            towns.Add(new Town() { Id = 14, Name = "Ymbol" });
            towns.Add(new Town() { Id = 15, Name = "Dimitrovgrad" });
            towns.Add(new Town() { Id = 16, Name = "TopolovGrad" });
            towns.Add(new Town() { Id = 17, Name = "Haskovo" });
            towns.Add(new Town() { Id = 18, Name = "Montana" });
            towns.Add(new Town() { Id = 19, Name = "Elhovo" });
            towns.Add(new Town() { Id = 20, Name = "Simeonovgrad" });
            towns.Add(new Town() { Id = 21, Name = "Svilengrad" });
            towns.Add(new Town() { Id = 22, Name = "Botevgrad" });
            towns.Add(new Town() { Id = 23, Name = "Shumen" });
            towns.Add(new Town() { Id = 24, Name = "Targovishte" });
            towns.Add(new Town() { Id = 25, Name = "Razgrad" });
            towns.Add(new Town() { Id = 26, Name = "Vidin" });
            towns.Add(new Town() { Id = 27, Name = "Karlovo" });
            towns.Add(new Town() { Id = 28, Name = "Koprivshtitsa" });
            towns.Add(new Town() { Id = 29, Name = "Kalofer" });
            towns.Add(new Town() { Id = 30, Name = "Kyustendil" });
            towns.Add(new Town() { Id = 31, Name = "Razlog" });
            towns.Add(new Town() { Id = 32, Name = "Bansko" });
            towns.Add(new Town() { Id = 33, Name = "Belica" });
            towns.Add(new Town() { Id = 34, Name = "Teteven" });
            towns.Add(new Town() { Id = 35, Name = "Lovech" });
            towns.Add(new Town() { Id = 36, Name = "Lom" });
            towns.Add(new Town() { Id = 37, Name = "Panagyurishte" });
            towns.Add(new Town() { Id = 38, Name = "Peshtera" });
            towns.Add(new Town() { Id = 39, Name = "Sarnica" });
            towns.Add(new Town() { Id = 40, Name = "Rakitovo" });
            towns.Add(new Town() { Id = 41, Name = "Stanke Dimitrov" });
            towns.Add(new Town() { Id = 42, Name = "Ahtopol" });
            towns.Add(new Town() { Id = 43, Name = "Carevec" });
            towns.Add(new Town() { Id = 44, Name = "Kpstinbrot" });
            towns.Add(new Town() { Id = 45, Name = "Neseber" });
            towns.Add(new Town() { Id = 46, Name = "Ivailovgrad" });
            towns.Add(new Town() { Id = 47, Name = "Septemvri" });
            towns.Add(new Town() { Id = 48, Name = "Varvara" });
            towns.Add(new Town() { Id = 49, Name = "Belovo" });
            towns.Add(new Town() { Id = 50, Name = "Ihtiman" });

        
        }
    }
}

 
