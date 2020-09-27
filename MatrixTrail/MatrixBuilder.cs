using System;

namespace MatrixTrailCalculator
{
    public class MatrixBuilder
    {
        public int MatrixTrail { get; set; }
        public int[,] MatrixArray { get; set; }


        public void BuildMatrix(int[,] matrixArray)
        {
            int rows = matrixArray[1,0];
            int cols = matrixArray[0,1];
            //int matrixTrail = 0;

            int min = 0, max = 100;
            Random random = new Random();

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
            //MatrixTrail = matrixTrail;
            //MatrixArray = matrixArray;
            //return matrixArray;
        }

    }
}
