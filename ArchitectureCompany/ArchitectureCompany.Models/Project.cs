namespace ArchitectureCompany.Models
{
    using ArchitectureCompany.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public int BuildingTypeId { get; set; }
        public virtual BuildingType BuildingsType { get; set; }

        public int Capacity { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public int TotalFloorArea { get; set; }

        public int NumberOfFloors { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

        public int ImageId { get; set; }
        
        public virtual ICollection<Image> Images { get; } = new List<Image>();
        public virtual ICollection<ProjectEmployee> ProjectsEmployee { get; set; } = new List<ProjectEmployee>();
        public virtual ICollection<ProjectClient> ProjectClients { get; set; } = new List<ProjectClient>();
    }
}
