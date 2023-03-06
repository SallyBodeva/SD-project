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

        public string AddTown(string name)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine($"Invalid Town");
                isValid = false;
            }
            if (isValid)
            {
                Town t = new Town() { Name = name };
                using (context = new AppDbContext())
                {
                    context.Add(t);
                    context.SaveChanges();
                    message.AppendLine($"{nameof(Town)} {name} is added");
                }
            }
            return message.ToString().TrimEnd();
        }
        public string AddAddress(string name, string town)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(name))
            {
                message.AppendLine($"Invalid Address");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(town))
            {
                message.AppendLine($"Invalid Town");
                isValid = false;
            }

            Town t = null;
            using (context = new AppDbContext())
            {
                t = context.Towns.FirstOrDefault(x => x.Name == town);
                if (t == null) { t = new Town() { Name = town }; }
                if (isValid)
                {
                    Address address = new Address()
                    {
                        Name = name,
                        Town = t
                    };

                    context.Addresses.Add(address);
                    context.SaveChanges();
                    message.AppendLine($"New address is added in {t.Name}: {name} ");
                }
            }
            return message.ToString().TrimEnd();
        }
        public string DeleteTown(int id)
        {
            using (context= new AppDbContext())
            {
                Town t = context.Towns.Find(id);
                if (t==null)
                {
                    return "not found";
                }
                else
                {
                    context.Towns.Remove(t);
                    context.SaveChanges();
                    return "Town was removed from our database";
                }
            }
        }
        public Town GetTownById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Invalid Town id!");
            }
            Town town = this.context.Towns.FirstOrDefault(x => x.Id == (id));
            return town;
        }
        public Address GetAddressById(int id)
        {
            if (id<0)
            {
                throw new ArgumentException("Invalid address id");
            }
            using (context = new AppDbContext())
            {
                Address address = this.context.Addresses.FirstOrDefault(x => x.Id == (id));
                return address;
            }
        }
    }
}
