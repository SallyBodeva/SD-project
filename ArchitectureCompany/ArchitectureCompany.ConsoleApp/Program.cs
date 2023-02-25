namespace ArchitectureCompany.ConsoleApp
{
    using System;
    using Services;
    internal class Program
    {
        static void Main()
        {
            EmployeeService es = new EmployeeService();
            Console.WriteLine(es.AddEmployee("Harry","Williams","1","2","0123456789","harry_w06"));
        }
    }
}
