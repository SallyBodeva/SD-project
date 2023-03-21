using System;

namespace ArchitectureCompany.WebApp.Models
{
    public class ProjectIndexViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string BuildingType { get; set; }
        public int Capacity { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Area { get; set; }
        public int FloorsCount { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; } = "https://mlcynqtblhhi.i.optimole.com/w:849/h:566/q:mauto/https://i0.wp.com/aplosgroup.com/wp-content/uploads/2018/04/ConstructionProject.jpg?fit=849%2C566&ssl=1";
    }
}
