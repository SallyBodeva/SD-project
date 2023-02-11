namespace ArchitectureCompany.Models
{
    using ArchitectureCompany.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        public int TownId { get; set; }

        public virtual Town Town { get; set; }
        public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
        public virtual Project Project { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
