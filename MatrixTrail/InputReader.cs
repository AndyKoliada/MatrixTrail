using System;

namespace MatrixTrail
{
    public class InputReader

    {
        int rowsInput = 0;
        int colsInput = 0;

        public int RowsInput { get => rowsInput; set => rowsInput = value; }
        public int ColsInput { get => colsInput; set => colsInput = value; }

        public void ReadRowCount()
        {
            
            while (!Int32.TryParse(Console.ReadLine(), out rowsInput))
            {
                Console.WriteLine("Please enter valid number");
            }

        }

        public void ReadColCount()
        {

            while (!Int32.TryParse(Console.ReadLine(), out colsInput))
            {
                Console.WriteLine("Please enter valid number");
            }

        }


    }
}

