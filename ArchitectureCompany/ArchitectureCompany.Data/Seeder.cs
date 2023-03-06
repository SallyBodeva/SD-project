namespace ArchitectureCompany.Data
{
    using ArchitectureCompany.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
            List<BuildingType> buildingTypes = new List<BuildingType>();
            List<Address> adreses = new List<Address>();

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

            projects.Add(new Project() { Id = 1, Name = "Museum design" });
            projects.Add(new Project() { Id = 2, Name = "Theater design" });
            projects.Add(new Project() { Id = 3, Name = "Kino design" });
            projects.Add(new Project() { Id = 4, Name = "Renovation of old buildings" });
            projects.Add(new Project() { Id = 5, Name = "Modern office" });
            projects.Add(new Project() { Id = 6, Name = "Modern house" });
            projects.Add(new Project() { Id = 7, Name = "Old house" });
            projects.Add(new Project() { Id = 8, Name = "Restaurant renovation" });
            projects.Add(new Project() { Id = 9, Name = "Renovation of a residential complex" });
            projects.Add(new Project() { Id = 10, Name = "Mansion design" });
            projects.Add(new Project() { Id = 11, Name = " Leaf fall" });
            projects.Add(new Project() { Id = 12, Name = " Oasis" });
            projects.Add(new Project() { Id = 13, Name = "Cristal city" });
            projects.Add(new Project() { Id = 14, Name = "Golden river" });
            projects.Add(new Project() { Id = 15, Name = "Golden street" });
            projects.Add(new Project() { Id = 16, Name = "Dream land" });
            projects.Add(new Project() { Id = 17, Name = "Children's corner " });
            projects.Add(new Project() { Id = 18, Name = "A beaytifull park" });
            projects.Add(new Project() { Id = 19, Name = "Subway" });
            projects.Add(new Project() { Id = 20, Name = "Bus station" });
            projects.Add(new Project() { Id = 21, Name = "Renovation of an old church" });

            buildingTypes.Add(new BuildingType() { Id = 1, TypeName = "house" });
            buildingTypes.Add(new BuildingType() { Id = 2, TypeName = "appartmant" });
            buildingTypes.Add(new BuildingType() { Id = 3, TypeName = "mansion" });

            buildingTypes.Add(new BuildingType() { Id = 4, TypeName = "farm" });
            buildingTypes.Add(new BuildingType() { Id = 5, TypeName = "skyscaper" });
            buildingTypes.Add(new BuildingType() { Id = 6, TypeName = "compani" });

            buildingTypes.Add(new BuildingType() { Id = 7, TypeName = "office" });
            buildingTypes.Add(new BuildingType() { Id = 8, TypeName = "restaurant" });
            buildingTypes.Add(new BuildingType() { Id = 9, TypeName = "kino" });
            buildingTypes.Add(new BuildingType() { Id = 10, TypeName = "theater" });


        }
    }
}

 
