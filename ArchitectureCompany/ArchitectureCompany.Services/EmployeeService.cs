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

        public string AddEmployee(string firstName, string lastName, string address, string town, string department, string phoneNumber, string email)
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

            if (string.IsNullOrWhiteSpace(department))
            {
                message.AppendLine($"Invalid {(nameof(department))}");
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
            Department d = null;
            Town t = null;
            using (context = new AppDbContext())
            {
                a = context.Addresses.FirstOrDefault(x => x.Name == address);
                d = context.Departments.FirstOrDefault(x => x.Name == department);
                t = context.Towns.FirstOrDefault(x => x.Name == town);
            }
            if (t == null) { t = new Town() { Name = town }; }
            if (a == null) { a = new Address() { Name = address, Town = t }; }
            if (d == null) { d = new Department() { Name = department }; }
            if (isValid)
            {
                using (context = new AppDbContext())
                {
                    Employee employee = new Employee()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Address = a,
                        Department = d,
                        PhoneNumber = phoneNumber,
                        Email = email
                    };
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    message.AppendLine($"Employee {firstName} {lastName} is added!");
                }
            }
            return message.ToString().TrimEnd();
        }
        public string GetEmployeeInfo()
        {
            Employee employee = null;
            using (context = new AppDbContext())
            {
                employee = context.Employees.Find(employee);
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
        public Employee GetEmployeeInfoById(int id)
        {
            using (context = new AppDbContext())
            {
                Employee e = context.Employees.FirstOrDefault(x => x.Id == id);
                return e;

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
                return $"{nameof(Employee)} {employee.FirstName} {employee.LastName} was fired!";
            }
        }


    }
}



