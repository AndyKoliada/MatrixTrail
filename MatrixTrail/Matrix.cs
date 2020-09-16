using System;

namespace MatrixTrail
{
    public class Matrix
    {
        int rowsInput = 0;
        int colsInput = 0;
        int matrixTrail = 0;

        public int RowsInput { get => rowsInput; set => rowsInput = value; }
        public int ColsInput { get => colsInput; set => colsInput = value; }
        public int MatrixTrail { get => matrixTrail; set => matrixTrail = value; }

        public void MatrixArrayBuilder(int rows, int cols)
        {
            int[,] matrixArray = new int[rows, cols];

            int min = 0, max = 100;
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j)
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(string.Format("{0} ", matrixArray[i, j] = random.Next(min, max)));
                        Console.ResetColor();
                        matrixTrail += matrixArray[i, j];
                    }
                    else
                    {
                        Console.Write(string.Format("{0} ", matrixArray[i, j] = random.Next(min, max)));
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
