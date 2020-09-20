using System;

namespace MatrixTrail
{
    public class ConsoleInputReader : IInputReader

    {
        int rowsInput = 0;
        int colsInput = 0;

        public int RowsInput { get => rowsInput; set => rowsInput = value; }
        public int ColsInput { get => colsInput; set => colsInput = value; }

        readonly InputRestrictor r = new InputRestrictor();

        public void ReadInput()
        {
            ReadRowCount();
            ReadColCount();
        }

        public void ReadRowCount()
        {
            while (!Int32.TryParse(Console.ReadLine(), out rowsInput))
            {
                r.IncorrectInputMessage();
            }
        }

        public void ReadColCount()
        {
            while (!Int32.TryParse(Console.ReadLine(), out colsInput))
            {
                r.IncorrectInputMessage();
            }
        }

    }
}

