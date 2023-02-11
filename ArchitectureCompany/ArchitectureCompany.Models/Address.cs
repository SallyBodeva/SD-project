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

        public virtual Client Client { get; set; }
        public virtual Project Project { get; set; }
        public virtual Employee Emplolyee { get; set; }
    }
}
