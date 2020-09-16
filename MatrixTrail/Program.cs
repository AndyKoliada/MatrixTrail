using System;

namespace MatrixTrail
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputValidator i = new UserInputValidator();
            i.ValidRowInput();
            i.ValidColInput();

            Matrix m = new Matrix();
            m.MatrixArrayBuilder(i.RowsInput, i.ColsInput);

            Console.ResetColor();
            Console.WriteLine($"Sum of values of main diagonal is: {m.MatrixTrail}");

            Console.ReadLine();

        }
    }
}
