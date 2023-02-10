﻿

namespace ArchitectureCompany.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class BuildingType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string TypeName { get; set; }
    }
}
