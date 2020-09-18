using System;

namespace MatrixTrail
{
    public class Matrix
    {
        int rowsInput = 0;
        int colsInput = 0;
        int matrixTrail = 0;
        private IPrinter printer;
        readonly int[,] matrixArray = new int[rowsInput, cols];

        //public int RowsInput { get => rowsInput; set => rowsInput = value; }
        //public int ColsInput { get => colsInput; set => colsInput = value; }
        //public int MatrixTrail { get => matrixTrail; set => matrixTrail = value; }


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
                        matrixTrail += matrixArray[i, j];
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

        public void OutputMatrix(IPrinter printer)
        {
            this.Printer = printer;
        }

        public void Print()
        {
            Printer.Print(int[,] matrixArray);
        }
    }
}
