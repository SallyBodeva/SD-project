namespace ArchitectureCompany.ConsoleApp
{
    using System;
    using Services;
    internal class Program
    {
        static void Main()
        {
            ClientService cs = new ClientService();
            Console.WriteLine(cs.AddClient("Lara","Bologne","Wall Street 8","Chicago","1234556790","Lara_W2021"));
        }
    }

}
