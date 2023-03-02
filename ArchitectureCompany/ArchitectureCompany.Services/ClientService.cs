using ArchitectureCompany.Data;
using ArchitectureCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchitectureCompany.Services
{

    public class ClientService
    {
        private AppDbContext context;
        public string AddClient(string firstName, string lastName, string address, string town, string phoneNumber, string email)
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
                t = context.Towns.FirstOrDefault(x => x.Name == town);
                a = context.Addresses.FirstOrDefault(x => x.Name == address);
            }
            if (t == null) { t = new Town() { Name = town }; }
            if (a == null) { a = new Address() { Name = address, Town = t }; }
            if (isValid)
            {
                using (context = new AppDbContext())
                {
                    Client client = new Client()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Address = a,
                        PhoneNumber = phoneNumber,
                        Email = email
                    };

                    context.Clients.Add(client);
                    context.SaveChanges();
                    message.AppendLine($"New client {firstName} {lastName} is added!");
                }
            }
            return message.ToString().TrimEnd();
        }
        public Client GetClientById(int id)
        {
            using (context = new AppDbContext())
            {
                return context.Clients.FirstOrDefault(x => x.Id == id);
            }
        }
       
        public string GetAllClientsInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Adress: ",-3} | {"Phone number",-10} | {"Email",-9}";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Client> clients = context.Clients.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var c in clients)
                {
                    string info = $"| {c.Id,-4} | {c.FirstName,-12} | {c.LastName,-12} | {c.AddressId,-20} | {c.PhoneNumber,-15}| {c.Email,-15} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Employees.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();

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
