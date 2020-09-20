using System;

namespace MatrixTrail
{
    public class MatrixBuilder : IMatrixBuilder
    {
        public int[,] MatrixArray { get; set; }

        public int MatrixTrail { get; set; } = 0;

        public int[,] MatrixArrayBuilder(int rows, int cols)
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
                        matrixArray[i, j] = random.Next(min, max);
                        MatrixTrail += matrixArray[i, j];
                    }
                    else
                    {
                        matrixArray[i, j] = random.Next(min, max);
                    }
                }

            }

            return matrixArray;
        }

        public IPrinter Printer { get; set; }
        
        public void Print(int[,] matrixArray)
        {
            Printer.Print(matrixArray);
        }
    }
}
