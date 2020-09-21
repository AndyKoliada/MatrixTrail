using System;

namespace MatrixTrailCalculator
{
    public class MatrixBuilder
    {
        public IPrinter Printer { get; set; }
        
        public IInputReader Inputreader { get; set; }
        public int[,] MatrixArray { get; set; }
        public int MatrixTrail { get; set; }


        public MatrixBuilder(IInputReader _inputreader, IPrinter _printer)
        {
            Inputreader = _inputreader;
            Printer = _printer;
        }

        public int[,] BuildMatrix(int rows, int cols)
        {
            int[,] matrixArray = new int[rows, cols];
            int matrixTrail = 0;

            int min = 0, max = 100;
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j)
                    {
                        matrixArray[i, j] = random.Next(min, max);
                        matrixTrail += matrixArray[i, j];
                    }
                    else
                    {
                        matrixArray[i, j] = random.Next(min, max);
                    }
                }

            }
            MatrixArray = matrixArray;
            MatrixTrail = matrixTrail;
            return MatrixArray;
        }

    }
}
