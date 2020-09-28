using MatrixTrail.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MatrixTrail
{
    class Driver
    {
        readonly IInputReader inputPromt;
        readonly IMatrixBuilder builder;
        readonly IPrinter printer;

        public Driver(IServiceProvider serviceProvider)
        {
            inputPromt = serviceProvider.GetService<IInputReader>();
            builder = serviceProvider.GetService<IMatrixBuilder>();
            printer = serviceProvider.GetService<IPrinter>();
        }

        public void Run()
        {
            inputPromt.ReadInput();
            builder.BuildMatrix(inputPromt.RowsInput, inputPromt.ColsInput);
            printer.Print(builder.MatrixArray);
            printer.Print(builder.MatrixTrail);
        }

    }
}
