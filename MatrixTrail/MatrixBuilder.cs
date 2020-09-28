using MatrixTrail.Interfaces;
using System;

namespace MatrixTrailCalculator
{
    public class MatrixBuilder : IMatrixBuilder
    {
        public int MatrixTrail { get; set; }
        public int[,] MatrixArray { get; set; }

        public void BuildMatrix(uint rows, uint cols)
        {
            int min = 0, max = 100;
            Random random = new Random();
            MatrixArray = new int[rows , cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j)
                    {
                        MatrixArray[i, j] = random.Next(min, max);
                        MatrixTrail += MatrixArray[i, j];
                    }
                    else
                    {
                        MatrixArray[i, j] = random.Next(min, max);
                    }
                }

            }

        }

    }
}
