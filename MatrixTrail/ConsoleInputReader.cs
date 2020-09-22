using System;

namespace MatrixTrailCalculator
{
    public class ConsoleInputReader : IInputReader

    {
        uint rowsInput = 0;
        uint colsInput = 0;

        public uint RowsInput { get => rowsInput; set => rowsInput = value; }
        public uint ColsInput { get => colsInput; set => colsInput = value; }

        public void ReadInput()
        {
            Console.WriteLine("Let's create new matrix!");
            Console.Write("Enter number of rows: ");
            ReadRowCount();
            Console.Write("Now enter number of columns: ");
            ReadColCount();
            Console.WriteLine();
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

