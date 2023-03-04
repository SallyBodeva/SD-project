

namespace ArchitectureCompany.Services
{
    using ArchitectureCompany.Data;
    using ArchitectureCompany.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class AdditionalService
    {
        private AppDbContext context;
        public Town GetTownById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Invalid Town id!");
            }
            Town town = this.context.Towns.FirstOrDefault(x => x.Id == (id));
            return town;
        }
    }
}
