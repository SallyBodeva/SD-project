using ArchitectureCompany.Data;
using ArchitectureCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchitectureCompany.Services
{
     
    public class ClientService
    {
        private AppDbContext context;
        public string AddClient(string firstName, string lastName, string address,string town, string phoneNumber, string email)
        {
            StringBuilder message = new StringBuilder();
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                message.AppendLine($"Invalid {(nameof(firstName))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                message.AppendLine($"Invalid {(nameof(lastName))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                message.AppendLine($"Invalid {(nameof(address))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                message.AppendLine($"Invalid {(nameof(phoneNumber))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                message.AppendLine($"Invalid {(nameof(email))}");
                isValid = false;
            }
            Address a = null;
            Town t = null;
            using (context = new AppDbContext())
            {
                a = context.Addresses.FirstOrDefault(x => x.Name == address);
                t = context.Towns.FirstOrDefault(x => x.Name == town);
            }
            if (isValid)
            {
                Client client = new Client()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = a,
                    PhoneNumber = phoneNumber,
                    Email = email
                };
                using (context = new AppDbContext())
                {
                    context.Clients.Add(client);
                    context.SaveChanges();
                    message.AppendLine($"New client {firstName} {lastName} is added!");
                }
            }
            return message.ToString().TrimEnd();
        }
        public string GetAllClientsInfo(int page = 1, int count = 10)
        {
            return null;
        }
        public string GetAllClientsInfo()
        {
            return null;

        }
        public string DeleteClientById(int id)
        {
            using (context = new AppDbContext())
            {
                Client client = context.Clients.Find(id);
                if (client == null)
                {
                    return $"{nameof(Client)} not found!";
                }
                context.Clients.Remove(client);
                context.SaveChanges();
                return $"{nameof(Client)} {client.FirstName} {client.LastName} stopped working with us!";
            }
        }
    }
}
