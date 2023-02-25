
namespace ArchitectureCompany.Data
{
    using ArchitectureCompany.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public int AddressId { get; set; }

        public int DepartmentId { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public virtual Address Address { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<ProjectEmployee> ProjectsEmployee { get; set; } = new List<ProjectEmployee>();

    }
}
