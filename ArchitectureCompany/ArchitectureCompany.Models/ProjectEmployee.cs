

namespace ArchitectureCompany.Models
{
    using ArchitectureCompany.Data;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class ProjectEmployee
    {
        public int ProjectId { get; set; }
        public virtual Project  Project { get; set; }
        public int EmployeeId { get; set; }
        public virtual  Employee Employee { get; set; }

    }
}
