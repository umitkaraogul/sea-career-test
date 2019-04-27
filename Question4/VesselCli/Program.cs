using System;
using VesselCli.Contracts;
using VesselCli.Service;
using VesselCli.Repository;
using VesselCli.Models;
using Microsoft.Extensions.DependencyInjection;


namespace VesselCli
{
    class Program
    {
        //TODO:Use dependency injection
        static void Main(string[] args)
        {

            //TODO:Use dependency injection

            IVesselRepository repository = new VesselRepository();
            ILoggerService logger = new LoggerService();

            VesselService vesselService = new VesselService(repository, logger);

            vesselService.Add(new Vessel() { VesselId = 1, Name = "Test" });




            Console.WriteLine("Hello World!");
        }

        /*

          public static void Main(string[] args)
                {

                    //setup our DI
                    var serviceProvider = new ServiceCollection()
                        .AddSingleton<IVesselRepository, VesselRepository>()
                        .AddSingleton<ILoggerService, LoggerService>()
                        .AddSingleton<IVesselService, VesselService>()
                        .BuildServiceProvider();


                    var logger = serviceProvider.GetService<ILoggerService>();

                    //do  work here
                    var vesselService = serviceProvider.GetService<VesselService>();

                }
         */

    }
}


