using MatrixTrail.Interfaces;
using System;

namespace MatrixTrailCalculator
{
    public class ConsoleInputReader : IInputReader

    {
        public uint RowsInput { get; set; }
        public uint ColsInput { get; set; }

        uint rowsInput = 0;
        uint colsInput = 0;

        public void ReadInput()
        {
            Console.WriteLine("Let's create new matrix!");
            Console.Write("Enter number of rows: ");
            ReadRowCount();
            Console.Write("Now enter number of columns: ");
            ReadColCount();
            Console.WriteLine();
            RowsInput = rowsInput;
            ColsInput = colsInput;
        }

        public void ReadRowCount()
        {
            while (!UInt32.TryParse(Console.ReadLine(), out rowsInput))
            {
                Console.WriteLine("Please enter valid positive number");
            }
        }

        public void ReadColCount()
        {
            while (!UInt32.TryParse(Console.ReadLine(), out colsInput))
            {
                Console.WriteLine("Please enter valid positive number");
            }
        }
    }

}

