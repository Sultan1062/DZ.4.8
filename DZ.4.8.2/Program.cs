using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ._4._8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrixA = new int[2, 3];
            int[,] matrixB = new int[2, 3];

            {
                int numRows = matrixA.GetLength(0);
                int numCols = matrixA.GetLength(1);
                Random random = new Random();

                int[,] resultMatrix = new int[numRows, numCols];

                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        matrixA[i, j] = random.Next(-9, 10);
                        matrixA[i, j] = random.Next(-9, 10);
                        resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
                        Console.WriteLine($"ответ = {resultMatrix[i, j]}");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}