using Microsoft.Extensions.DependencyInjection;

namespace MatrixTrailCalculator
{
    class Program
    {

        static void Main()
        {
            //setting up DI (registering services)
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IInputReader, ConsoleInputReader>()
                .AddSingleton<IPrinter, ConsolePrinter>()
                .BuildServiceProvider();

            //calling registered services from serviceProvider
            var inputReader = serviceProvider.GetService<IInputReader>();
            var printer = serviceProvider.GetService<IPrinter>();

            var builder = new MatrixBuilder();
            inputReader.ReadInput();
            builder.BuildMatrix(inputReader.MatrixArray);

            printer.Print(builder.MatrixArray);
            printer.Print(builder.MatrixTrail);
        }

    }
}
