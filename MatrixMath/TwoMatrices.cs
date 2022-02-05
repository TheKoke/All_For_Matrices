using System;

namespace Drogergous.MatrixMath
{
    class TwoMatrices
    {
        public static int[,] Sum(int[,] First, int[,] Second)
        {
            int[,] ResultMatrix = new int[First.GetLength(0), First.GetLength(1)];

            if (First.GetLength(0) == Second.GetLength(0) & First.GetLength(1) == Second.GetLength(1))
            {
                throw new Exception("Размеры матриц не совпадают, суммирование невозможно");
            }
            
            for (int i = 0; i < First.GetLength(0); i++)
            {
                for (int j = 0; j < First.GetLength(0); j++)
                {
                    ResultMatrix[i, j] = First[i, j] + Second[i, j];
                }
            }

            return ResultMatrix;
        }

        public static int[,] Multiplication(int[,] First, int[,] Second)
        {
            if (First.GetLength(1) != Second.GetLength(0))
            {
                throw new Exception("Умножение невозможно");
            }
            
            int[,] ResultMatrix = new int[First.GetLength(1), Second.GetLength(0)];
            
            for (int i = 0; i < ResultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ResultMatrix.GetLength(1); j++)
                {
                    ResultMatrix[i, j] = 0;
                    for (int k = 0; k < ResultMatrix.GetLength(1); k++)
                    {
                        ResultMatrix[i, j] = ResultMatrix[i, j] + First[i, k] * Second[k, j];
                    }
                }
            }

            return ResultMatrix;
        }

        public static int[,] Multiplication(float[,] First, int[] Second)
        {
            if (First.GetLength(1) != Second.Length)
            {
                throw new Exception("Умножение невозможнo");
            }
            
            int[,] ResultMatrix = new int[First.GetLength(0), 1];
            
            for (int i = 0; i < ResultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < ResultMatrix.GetLength(1); j++)
                {
                    ResultMatrix[i, j] = 0;
                    for (int k = 0; k < ResultMatrix.GetLength(1); k++)
                    {
                        ResultMatrix[i, j] += (int)First[i, k] * Second[k];
                    }
                }
            }

            return ResultMatrix;
        }
    }
}
