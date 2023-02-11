
namespace ArchitectureCompany.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ProjectClient
    {
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public int ClientId  { get; set; }
        public virtual Client Client { get; set; }
    }
}
