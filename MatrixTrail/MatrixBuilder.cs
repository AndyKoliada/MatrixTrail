using System;

namespace MatrixTrailCalculator
{
    public class MatrixBuilder
    {
        public IPrinter _print;

        public IInputReader _readinput;

        public MatrixBuilder(IInputReader readinput, IPrinter print)
        {
            _readinput = readinput;
            _print = print;
        }

        public int[,] BuildMatrix(int[,] matrixArray)
        {
            matrixArray = _readinput.ReadInput();

            int rows = matrixArray[1,0];
            int cols = matrixArray[0,1];
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

            _print.Print(matrixArray);
            _print.Print(matrixTrail);

            return matrixArray;
        }

    }
}
