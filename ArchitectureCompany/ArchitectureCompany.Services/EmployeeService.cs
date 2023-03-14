namespace ArchitectureCompany.Services
{
    using System;
    using Models;
    using System.Collections.Generic;
    using System.Text;
    using ArchitectureCompany.Data;
    using System.Linq;
    using Microsoft.Practices.EnterpriseLibrary.Common.Utility;

    public class EmployeeService
    {
        private AppDbContext context;
        public string AddProjectTeam(int projectId, List<int> teamId)
        {
            StringBuilder message = new StringBuilder();
            using (context = new AppDbContext())
            {
                Project project = context.Projects.Find(projectId);
                if (project == null)
                {
                    message.AppendLine($"{nameof(Project)} not found!");
                    return message.ToString().TrimEnd();
                }
                List<Employee> employees = new List<Employee>();
                foreach (var id in teamId)
                {
                    Employee employee = context.Employees.Find(id);
                    if (employee != null)
                    {
                        employees.Add(employee);
                    }
                }
                if (employees.Count == 0)
                {
                    message.AppendLine($"{nameof(Employee)}s not found!");
                    return message.ToString().TrimEnd();
                }
                message.AppendLine($"{projectId} {project.Name} team: ");
                foreach (var employee in employees)
                {
                    context.ProjectEmployees.Add(new ProjectEmployee
                    {
                        Project = project,
                        Employee = employee
                    });
                    message.AppendLine($"\t{employee.FirstName} {employee.LastName}");
                }
                context.SaveChanges();
                return message.ToString().TrimEnd();
            }
            }
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
                t = context.Towns.FirstOrDefault(t => t.Name == town);
                a = context.Addresses.FirstOrDefault(a => a.Name == address && a.Town.Name == town);
                d = context.Departments.FirstOrDefault(d => d.Name == department);
                t = context.Towns.FirstOrDefault(t => t.Name == town);
                if (t == null)
                {
                    t = new Town() { Name = town };
                }
                if (d == null)
                {
                    d = new Department() { Name = department };
                }
                if (a == null)
                {
                    a = new Address() { Name = address, Town = t };
                }

                if (isValid)
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
                return message.ToString().TrimEnd();
            }

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
        public string GetEmployeeInfo(int id)
        {
            Employee employee = null;
            using (context = new AppDbContext())
            {
                employee = context.Employees.Find(id);
            }
            if (employee != null)
            {
                StringBuilder masege = new StringBuilder();
                masege.AppendLine($"Employee info: ");
                masege.AppendLine($"\tId: {employee.Id}");
                masege.AppendLine($"\tFirst name: {employee.FirstName}");
                masege.AppendLine($"\tLast name: {employee.LastName}");
                masege.AppendLine($"\tAddres id: {employee.AddressId}");
                masege.AppendLine($"\tDepartment id: {employee.DepartmentId}");
                masege.AppendLine($"\tPhone number: {employee.PhoneNumber}");
                masege.AppendLine($"\tEmail: {employee.Email}");
                return masege.ToString().TrimEnd();
            }
            else
            {
                return $"{nameof(Employee)} not found!";
            }
        }
        public Employee GetEmployeeById(int id)
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
            string firstRow = $"| {"Id",-4} | {"First name",-12} | {"Last name",-12} | {"Adress id",-3} | {"Dpartmenmt id",-3} | {"Phone number",-15} | {"Email",-15} |";

            string line = $"|{new string('-', firstRow.Length - 2)}|";

            using (context = new AppDbContext())
            {
                List<Employee> employees = context.Employees.Skip((page - 1) * count).Take(count).ToList();
                msg.AppendLine(firstRow);
                msg.AppendLine(line);
                foreach (var e in employees)
                {
                    string info = $"| {e.Id,-4} | {e.FirstName,-12} | {e.LastName,-12} | {e.AddressId,-3} | {e.DepartmentId,-3} | {e.PhoneNumber,-15}| {e.Email,-15} |";
                    msg.AppendLine(info);
                    msg.AppendLine(line);
                }
                int pageCount = (int)Math.Ceiling(context.Employees.Count() / (decimal)count);
                msg.AppendLine($"Page: {page} / {pageCount}");
            }

            return msg.ToString().TrimEnd();
        }
        public List<string> GetEmployeeBasicInfo(int page = 1, int count = 10)
        {
            List<string> list = null;
            using (context = new AppDbContext())
            {
                list = context.Employees
                    .Skip((page - 1) * count)
                    .Take(count).Select(x => $"{x.Id} - {x.FirstName} {x.LastName}")
                    .ToList();
            }
            return list;
        }
        public List<string> GetEmployeeNames()
        {
            using (context = new AppDbContext())
            {
                List<string> employeeNames = context.Employees.Select(x => x.Address.Name).ToList();
                return employeeNames;
            }
        }
        public string GetAddresssName(int id)
        {
            using (context = new AppDbContext())
            {
                Employee e = context.Employees.Find(id);
                return e.Address.Name.ToString();

            }
        }
        public string GetTownName(int id)
        {
            using (context = new AppDbContext())
            {
                Employee e = context.Employees.Find(id);
                return e.Address.Town.Name.ToString();

            }
        }
        public string GetDepartmentName(int id)
        {
            using (context = new AppDbContext())
            {
                Employee e = context.Employees.Find(id);
                return e.Department.Name.ToString();

            }
        }
        public string UpdateEmployeePhoneNum(int id, string num)
        {
            using (context = new AppDbContext())
            {
                Employee e = context.Employees.Find(id);
                if (e == null)
                {
                    return $"Employee not found!";
                }
                e.PhoneNumber = num;
                context.Employees.Update(e);
                context.SaveChanges();
                return $"Employee {e.FirstName} {e.LastName} has new phone number: {num}";
            }
        }
        public int GetEmployeePagesCount(int count)
        {
            using (context = new AppDbContext())
            {
                return (int)Math.Ceiling(context.Employees.Count() / (double)count);
            }
        }
       
    }

}



