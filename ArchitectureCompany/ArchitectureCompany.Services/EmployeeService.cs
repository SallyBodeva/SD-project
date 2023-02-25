

namespace ArchitectureCompany.Services
{
    using System;

    using Models;
    using System.Collections.Generic;
    using System.Text;
    using ArchitectureCompany.Data;
    using System.Linq;

    public class EmployeeService
    {
        private AppDbContext context;

        public string AddEmployee(string firstName, string lastName, int address_id, int department_id, string phoneNumber, string email)
        {
            StringBuilder masege = new StringBuilder();
            bool isValud = true;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                masege.AppendLine($"Invalid {(nameof(firstName))}");
                isValud = false;

            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                masege.AppendLine($"Invalid {(nameof(lastName))}");
                isValud = false;

            }
            if (address_id == 0)
            {
                masege.AppendLine($"Invalid {(nameof(address_id))}");
                isValud = false;

            }
            if (department_id == 0)
            {
                masege.AppendLine($"Invalid {(nameof(department_id))}");
                isValud = false;
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                masege.AppendLine($"Invalid {(nameof(phoneNumber))}");
                isValud = false;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                masege.AppendLine($"Invalid {(nameof(email))}");
                isValud = false;
            }
            if (isValud)
            {
                Employee employee = new Employee()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    AddressId = address_id,
                    DepartmentId = department_id,
                    PhoneNumber = phoneNumber,
                    Email = email
                };
                using (context = new AppDbContext())
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    masege.AppendLine($"Employee {firstName} {lastName} is added!");
                }
            }
            return masege.ToString().TrimEnd();
        }
        public string GetPilotInfoById(int id)
        {
            Employee employee = null;
            using (context = new AppDbContext())
            {
                employee = context.Employees.Find(id);
            }
            if (employee != null)
            {
                StringBuilder masege = new StringBuilder();
                masege.AppendLine($"{nameof(employee)} info: ");
                masege.AppendLine($"\tId: {employee.Id}");
                masege.AppendLine($"\tFirst name: {employee.FirstName}");
                masege.AppendLine($"\tLast name: {employee.LastName}");
                masege.AppendLine($"\tAddres id: {employee.AddressId}");
                masege.AppendLine($"\tDepartment id: {employee.DepartmentId}");
                masege.AppendLine($"\tPhobe number: {employee.PhoneNumber}");
                masege.AppendLine($"\t Email: {employee.Email}");
                return masege.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Employee)} not found!";
            }
        }
        //public string GetPilotInfo()
        //{
        //ToDo
        //}
        public string GetAllPilotsInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Age",-3} | {"Rating",-6}|";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Employee> pilots = context.Employees
                    .Skip((page - 1) * count)
                    .Take(count)
                    .ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var p in pilots)
                {
                    string info = $"| {p.Id,-4} | {p.FirstName,-12} | {p.LastName,-12} | {p.AddressId,-20} | {p.DepartmentId,-10} | {p.PhoneNumber,-15}| {p.Email,-15} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Employees.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();
        }
        public string DeletePilotById(int id)
        {
            using (context = new AppDbContext())
            {
                Employee employee = context.Employees.Find(id);
                if (employee == null) { return $"{nameof(Employee)} not found!"; }
                context.Employees.Remove(employee);
                context.SaveChanges();
                return $"{nameof(Employee)} {employee.FirstName} {employee.LastName} was deleted!";
            }
        }


    }
}



