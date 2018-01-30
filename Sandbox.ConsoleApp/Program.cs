using Serilog;
using System;
using Sandbox.BusinessLogic;

namespace Sandbox.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InitializeLogger();
            Log.Information("Logger initialized");

            Console.WriteLine("What's your name?");

            var name = Console.ReadLine();
            var response = HelloWorld.Welcome(name);

            Console.WriteLine(response);

            Log.Information("App finished");
        }

        private static void InitializeLogger()
        {
            Serilog.ILogger logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            
            Log.Logger = logger;
        }
    }
}
