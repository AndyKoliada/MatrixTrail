using MatrixTrail;
using MatrixTrail.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MatrixTrailCalculator
{
    class Program
    {
        static void Main()
        {
            using (var serviceProvider = SetupDI())
            {
                serviceProvider.GetService<App>().Run();
            }
        }

        private static ServiceProvider SetupDI()
        {
            var services = new ServiceCollection();

            services.AddTransient<IInputReader, ConsoleInputReader>();
            services.AddTransient<IMatrixBuilder, MatrixBuilder>();
            services.AddTransient<IPrinter, ConsolePrinter>();

            services.AddTransient<App>();

            return services.BuildServiceProvider();
        }
    }

}
