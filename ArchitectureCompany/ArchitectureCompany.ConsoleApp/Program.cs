namespace ArchitectureCompany.ConsoleApp
{
    using System;
    using Services;
    internal class Program
    {
        static void Main()
        {
            EmployeeService es = new EmployeeService();
            ClientService cs = new ClientService();
            DepartmentService ds = new DepartmentService();
            Console.WriteLine(ds.GetDepartmentsCount());
        }
    }

}
