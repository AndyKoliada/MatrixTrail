using MatrixTrail.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MatrixTrailCalculator
{
    class Program
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.Add(new ServiceDescriptor(typeof(IInputReader), new ConsoleInputReader()));
            services.Add(new ServiceDescriptor(typeof(IPrinter), new ConsolePrinter()));
        }

        static void Main()
        {

        }

    }
}
