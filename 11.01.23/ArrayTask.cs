using System;
using System.Collections.Generic;
using System.Text;

namespace _11._01._23
{
    class ArrayTask
    {
        internal int[,] swapMaxAndMin()
        {
            Console.WriteLine("The Lengh of Massive:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The High of Massive:");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n,m];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"mass[{i}],[{j}]=");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }

            }
            return arr;
        }

        internal static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
            
        internal int [,] SwapMaxandMin (int[,] arr)
        {
            int minRow = 0, minColumn = 0, maxRow = 0, maxColumn = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[minRow, minColumn])
                    {
                        minRow = i;
                        minColumn = j;
                    }
                    if (arr[i, j] > arr[maxRow, maxColumn])
                    {
                        maxRow = i;
                        maxColumn = j;
                    }
                }
            }
            return SwapMaxandMin;
        }
    }
}
