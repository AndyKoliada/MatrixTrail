using System;

namespace MatrixTrail
{
    class Program
    {
        static void Main()
        {
            #region INPUT
            Console.WriteLine("Let's create new matrix.");
            Console.Write("Enter number of rows: ");

            ConsoleInputReader i = new ConsoleInputReader();
            i.ReadRowCount();

            Console.Write("Now enter number of columns: ");

            i.ReadColCount();

            Console.WriteLine();
            #endregion

            #region PROCESSING
            MatrixBuilder m = new MatrixBuilder();

            #endregion

            #region MATRIXOUTPUT

            //m.Printer = new ConsolePrinter();
            m.Print(m.MatrixArrayBuilder(i.RowsInput, i.ColsInput));

            #endregion

            #region RESULTOUTPUT
            Console.ResetColor();
            Console.WriteLine($"Sum of values of main diagonal is: {m.MatrixTrail}");

            Console.ReadLine();
            #endregion

            var matrix = new MatrixBuilder();
            //matrix.ReadInput();
            //matrix.Print();




        }
    }
}
