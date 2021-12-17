using System;

namespace OopMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "John";
            p.LastName = "Doe";
            p.SayHello();

            ConsoleHelper.PrintMessage("test");

            Console.WriteLine("Hello World!");
        }
    }
}
