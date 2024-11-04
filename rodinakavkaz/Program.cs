using System;
using System.Linq;

namespace rodinakavkaz
{
    class Program
    {
        public static void PrintRange(int M, int N)
        {
            if (M > N) return;
            Console.Write(M);
            if (M < N) Console.Write(", ");
            PrintRange(M + 1, N);
        }
        static void Main(string[] args)
        {
            int[,] array = new int [3, 3];
            Random rnd = new Random();

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(10, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------");

            for(int col = 0; col < array.GetLength(1); col++)
            {
                int max = array[0, col];
                
                for(int row = 0; row < array.GetLength(0); row++)
                {
                    if (array[row, col] > max)
                    {
                        max = array[row, col];
                    }
                }
                Console.WriteLine($"Столбец {col + 1}: {max}");
            }

            int M = 1;
            int N = 5;
            Console.WriteLine("Числа в промежутке:");
            PrintRange(M, N);
        }
    }
}
