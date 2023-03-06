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
            ProjectService ps = new ProjectService();
            Console.WriteLine(ps.AddImageToProject(2,"https://cf.bstatic.com/xdata/images/hotel/max1280x900/400263490.jpg?k=7ef370931ee5424f3ffb00f10a2591c7b960289ad2ce6cbafa5fc1f03e67142f&o=&hp=1"));
        }
    }

}
