using System;
using System.Collections.Generic;

namespace Drogergous
{
    class Start
    {
        public static int Size { get; set; }

        static int[,] GetSMatrix(int[,] Matrix, int[] FreeNums)
        {
            int[,] Result = new int[Size, Size + 1];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size + 1; j++)
                {
                    if (j == Size)
                    {
                        Result[i, j] = FreeNums[i];
                    }
                    else
                    {
                        Result[i, j] = Matrix[i, j];
                    }

                }
            }

            return Result;
        }

        static void Print(int[,] SoAE_Matrix)
        {
            for (int i = 0; i < SoAE_Matrix.GetLength(0); i++)
            {
                for (int j= 0; j < SoAE_Matrix.GetLength(1); j++)
                {
                    Console.Write("\t" + SoAE_Matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Size: ");
            Size = int.Parse(Console.ReadLine());

            Console.Clear();

            int[,] Matrix = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{i}, {j} : ");
                    Matrix[i, j] = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }

            //int[] freenums = new int[Size];

            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Введите свободный член под номером {i+1}: ");
            //    freenums[i] = int.Parse(Console.ReadLine());
            //}
        }
    }
}
