using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строчек");
            int stroch = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int stolb = int.Parse(Console.ReadLine());
            int[,] capa = new int[stroch, stolb];
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < stroch; i++)    
            {
               for (int j = 0; j < stolb; j++)
                {
                    capa[i,j] = rand.Next(10);
                    Console.Write(capa [i, j]);
                    sum += capa[i, j];
                    
                }
                Console.WriteLine();

            }
            Console.WriteLine($"сумма двухмерного массива: {sum}");
            Console.ReadLine();
        }
    }
}
