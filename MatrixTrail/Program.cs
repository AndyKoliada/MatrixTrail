using System;

namespace MatrixTrailCalculator
{
    class Program
    {
        static void Main()
        {
            var inputreader = new ConsoleInputReader();
            var printer = new ConsolePrinter();
            var matrix = new MatrixBuilder(inputreader, printer);

            inputreader.ReadInput();

            matrix.BuildMatrix(inputreader.RowsInput, inputreader.ColsInput);

            printer.Print(matrix.MatrixArray);

            printer.Print(matrix.MatrixTrail);

        }
    }
}
