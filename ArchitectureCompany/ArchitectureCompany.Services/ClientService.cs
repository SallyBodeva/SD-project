using ArchitectureCompany.Data;
using ArchitectureCompany.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureCompany.Services
{
     
    public class ClientService
    {
        private AppDbContext context;
        public string AddClient(string firstName, string lastName, string address_id, string phoneNumber, string email)
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
            if (string.IsNullOrWhiteSpace(address_id))
            {
                message.AppendLine($"Invalid {(nameof(address_id))}");
                isValid = false;
            }
            if (!int.TryParse(address_id, out _))
            {
                message.AppendLine($"Invalid {(nameof(address_id))}");
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
            if (isValid)
            {
                Client client = new Client()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    AddressId = int.Parse(address_id),
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
