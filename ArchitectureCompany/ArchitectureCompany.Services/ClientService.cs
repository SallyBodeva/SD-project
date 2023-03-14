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
                if (t == null)
                {
                    t = new Town() { Name = town };
                    context.SaveChanges();
                }
                a = context.Addresses.FirstOrDefault(x => x.Name == address);
                if (a == null)
                {
                    a = new Address() { Name = address, Town = t };
                    context.SaveChanges();
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

                    context.Clients.Add(client);
                    context.SaveChanges();
                    message.AppendLine($"{firstName} {lastName} became our client!");

                }
            }
            return message.ToString().TrimEnd();
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
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Adress: ",-8} | {"Phone number",-25} | {"Email",-9} |";

            string line = $"|{new string('-', firstRow.Length - 2)}| ";

            using (context = new AppDbContext())
            {
                List<Client> clients = context.Clients.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var c in clients)
                {
                    string info = $"| {c.Id,-4} | {c.FirstName,-12} | {c.LastName,-12} | {c.AddressId,-8} | {c.PhoneNumber,-25} | {c.Email,-9} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Clients.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();

        }
        public string GetClientInfoById(int id)
        {
            Client client = null;
            using (context = new AppDbContext())
            {
                client = context.Clients.Find(id);

                if (client != null)
                {
                    StringBuilder msg = new StringBuilder();
                    msg.AppendLine($"{nameof(Client)} info: ");
                    msg.AppendLine($"\tId: {client.Id}");
                    msg.AppendLine($"\tFirst name: {client.FirstName}");
                    msg.AppendLine($"\tLast name: {client.LastName}");
                    string addressName = client.Address.Name;
                    msg.AppendLine($"\tAddress: {addressName}");
                    msg.AppendLine($"\tPhone number: {client.PhoneNumber}");
                    msg.AppendLine($"\tEmail: {client.Email}");
                    return msg.ToString().TrimEnd();
                }
                else
                {
                    return $"{nameof(Client)} not found!";
                }
            }
        }
        public int GetClientIdByPhoneNum(string phoneNum)
        {
            using (context = new AppDbContext())
            {
                return context.Clients.FirstOrDefault(x => x.PhoneNumber == phoneNum).Id;
            }
        }
        public List<string> GetProjectsName(int idClient)
        {
            using (context= new AppDbContext())
            {
                List<string> currentClientProjects = context.ProjectClients.Where(x => x.ClientId == idClient).Select(x=>x.Project.Name).ToList();
                return currentClientProjects;
            }
        }
        public string MatchClientToProject(int clientId,int  projectId)
        {
            using (context = new AppDbContext())
            {
                Client c = context.Clients.Find(clientId);
                Project p = context.Projects.Find(projectId);
                if (c==null)
                {
                    return "Client not found!";
                }
                if (p==null)
                {
                    return "Project not found!";
                }
                context.ProjectClients.Add(new ProjectClient() { Client=c,Project=p});
                context.SaveChanges();
                return "Client matches his project!";
            }
        }
        public List<string> GetClientBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Clients
                    .Skip((page - 1) * count)
                    .Take(count).Select(x => $"{x.Id} - {x.FirstName} {x.LastName}")
                    .ToList();
            }
            return list;
        }
        public List<string> GetClientBasicInfo()
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Clients.Select(x => $"{x.Id} - {x.FirstName} {x.LastName}")
                    .ToList();
            }
            return list;
        }
        public int GetClientPagesCount(int count)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Clients.Count() / (double)count);
            }
        }
        public List<string> GetClientsProjects(int clientId)
        {
            using (var context = new AppDbContext())
            {
                return context.ProjectClients
                    .Where(x => x.ClientId == clientId)
                    .Select(x => x.Project.Name).Distinct().ToList();
            }
        }
    }
}
