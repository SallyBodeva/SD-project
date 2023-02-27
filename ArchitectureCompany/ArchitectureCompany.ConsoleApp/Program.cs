namespace ArchitectureCompany.ConsoleApp
{
    using System;
    using Services;
    internal class Program
    {
        static void Main()
        {
            EmployeeService es = new EmployeeService();
            Console.WriteLine(es.AddEmployee("Eda","Yaldis","Karadja 10","Instanbul","Landscape Architecture","9807587909","eda_1998"));
        }
    }
}
