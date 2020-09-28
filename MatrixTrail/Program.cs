using MatrixTrail;
using MatrixTrail.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MatrixTrailCalculator
{
    class Program
    {
        private static IServiceProvider serviceProvider;
        static void Main()
        {
            RegisterServices();

            var driver = new Driver(serviceProvider);
            driver.Run();
            
        }

        private static void RegisterServices()
        {
            //setting up DI (registering services)
            var collection = new ServiceCollection()
                .AddSingleton<IInputReader, ConsoleInputReader>()
                .AddSingleton<IMatrixBuilder, MatrixBuilder>()
                .AddSingleton<IPrinter, ConsolePrinter>();
            serviceProvider = collection.BuildServiceProvider();
        }

    }
}
