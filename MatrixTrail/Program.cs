using System;

namespace MatrixTrail
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INPUT
            Console.WriteLine("Let's create new matrix.");
            Console.Write("Enter number of rows: ");

            InputReader i = new InputReader();
            i.ReadRowCount();

            Console.Write("Now enter number of columns: ");

            i.ReadColCount();

            Console.WriteLine();
            #endregion

            #region PROCESSING
            Matrix m = new Matrix();
            m.MatrixArrayBuilder(i.RowsInput, i.ColsInput);
            #endregion

            #region MATRIXOUTPUT
            OutputWriter();
            #endregion

            #region RESULTOUTPUT
            Console.ResetColor();
            Console.WriteLine($"Sum of values of main diagonal is: {m.MatrixTrail}");

            Console.ReadLine();
            #endregion
        }
    }
}
