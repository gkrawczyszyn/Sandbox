using System;
using Sandbox.BusinessLogic;

namespace Sandbox.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");

            var name = Console.ReadLine();
            var response = HelloWorld.Welcome(name);

            Console.WriteLine(response);
        }
    }
}
