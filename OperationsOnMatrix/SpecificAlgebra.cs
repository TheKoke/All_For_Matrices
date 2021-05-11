using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.OperationsOnMatrix
{
    class SpecificAlgebra
    {
        private static int[,] MinorMatrix;

        /// <summary>
        /// Метод находящий минор матрицы в индексах переданной методу
        /// </summary>
        public static int[,] GetMinor(int[,] Matrix, int DelStr, int DelCol)
        {
            MinorMatrix = new int[Matrix.GetLength(0) - 1, Matrix.GetLength(1) - 1];

            //Переменная для копирования элементов матрицы в элементы минора
            short varForIndexStr = 0;

            short varForIndexCol = 0;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                if (i == DelStr)
                    continue;
                else
                {
                    for (int j = 0; j < Matrix.GetLength(0); j++)
                    {
                        if (j == DelCol)
                            continue;
                        else
                        {
                            MinorMatrix[varForIndexStr, varForIndexCol] = Matrix[i, j];

                            varForIndexCol++;
                        }
                    }
                    varForIndexStr++;
                }

                varForIndexCol = 0;
            }

            return MinorMatrix;
            
        }

        /// <summary>
        /// Метод находящий Алгебраическое дополнение элемента матрицы, принимает матрицу и индексы элемента
        /// </summary>
        public static int AlgebraicApp(int[,] Matrix, int firstIndex, int SecIndex)
        {
            GetMinor(Matrix, firstIndex, SecIndex);

            //Классическая формула для Алгебраического дополнения
            int result = (int)(Math.Pow(-1, firstIndex + SecIndex) * Determinants.Resolve(MinorMatrix));

            return result;
        }
    }
}
