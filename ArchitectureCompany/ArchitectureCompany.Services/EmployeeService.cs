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

        public string AddEmployee(string firstName, string lastName, string address_id, string department_id, string phoneNumber, string email)
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
            if (int.Parse(department_id) < 0)
            {
                message.AppendLine($"Invalid {(nameof(department_id))}");
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(department_id))
            {
                message.AppendLine($"Invalid {(nameof(department_id))}");
                isValid = false;
            }
            if (!int.TryParse(department_id, out _))
            {
                message.AppendLine($"Invalid {(nameof(department_id))}");
                isValid = false;
            }
            if (int.Parse(department_id)<0)
            {
                message.AppendLine($"Invalid {(nameof(department_id))}");
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
                Employee employee = new Employee()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    AddressId = int.Parse(address_id),
                    DepartmentId = int.Parse(department_id),
                    PhoneNumber = phoneNumber,
                    Email = email
                };
                using (context = new AppDbContext())
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    message.AppendLine($"Employee {firstName} {lastName} is added!");
                }
            }
            return message.ToString().TrimEnd();
        }
        public string GetEmployeeInfoById(int id)
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
        public string GetAllEmployeesInfo(int page = 1, int count = 10)
        {
            StringBuilder msg = new StringBuilder();
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Adress id",-3} | {"Dpartmenmt id",-3} | {"Phone number",-3} | {"Email",-15}";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Employee> employees = context.Employees.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var e in employees)
                {
                    string info = $"| {e.Id,-4} | {e.FirstName,-12} | {e.LastName,-12} | {e.AddressId,-20} | {e.DepartmentId,-10} | {e.PhoneNumber,-15}| {e.Email,-15} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Employees.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();
        }
        public string DeleteEmployeeById(int id)
        {
            using (context = new AppDbContext())
            {
                Employee employee = context.Employees.Find(id);
                if (employee == null)
                {
                    return $"{nameof(Employee)} not found!";
                }
                context.Employees.Remove(employee);
                context.SaveChanges();
                return $"{nameof(Employee)} {employee.FirstName} {employee.LastName} was deleted!";
            }
        }


    }
}



