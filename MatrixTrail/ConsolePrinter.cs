using System;

namespace MatrixTrail
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(int[,] matrixArray)
        {
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(string.Format("{0} ", matrixArray[i, j]));
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(string.Format("{0} ", matrixArray[i, j]));
                    }
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }   
    }
}
