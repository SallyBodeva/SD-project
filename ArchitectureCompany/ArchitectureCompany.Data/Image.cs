

namespace ArchitectureCompany.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Url { get; set; }

    }
}
