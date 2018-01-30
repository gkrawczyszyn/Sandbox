using Serilog;
using Serilog.Sinks.GoogleCloudLogging;
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
                //.WriteTo.Console()
                .WriteTo.GoogleCloudLogging(new GoogleCloudLoggingSinkOptions(""))
                .CreateLogger();
            
//  var credential = GoogleCredential.FromFile(jsonPath);
//     var storage = StorageClient.Create(credential);
//     // Make an authenticated API request.
//     var buckets = storage.ListBuckets(projectId);
//     foreach (var bucket in buckets)
//     {
//         Console.WriteLine(bucket.Name);
//     }
//     return null;

            Log.Logger = logger;
        }
    }
}
