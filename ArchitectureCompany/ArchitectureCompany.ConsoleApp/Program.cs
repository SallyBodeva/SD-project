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
            AdditionalService ads = new AdditionalService();
            Console.WriteLine(cs.AddClient("Mia","Robert", "Loch Ness Road 17","Chicago","3456780123","mia_r"));
        }
    }

}
