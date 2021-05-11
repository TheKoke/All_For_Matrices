using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.MatrixMath
{
    class TwoMatrices
    {
        /// <summary>
        /// Метод который суммирует матрицы, и размер этих матриц должен быть равным обязательно
        /// </summary>
        public static int[,] Sum(int[,] First, int[,] Second)
        {
            //Масссив для возвращаемого результата
            int[,] ResultMatrix = new int[First.GetLength(0), First.GetLength(0)];

            if (First.GetLength(0) == Second.GetLength(0) & First.GetLength(1) == Second.GetLength(1))
            {
                throw new Exception("Размеры матриц не совпадают, суммирование невозможно");
            }
            else
            {
                for (int i = 0; i < First.GetLength(0); i++)
                {
                    for (int j = 0; j < First.GetLength(0); j++)
                    {
                        ResultMatrix[i, j] = First[i, j] + Second[i, j];
                    }
                }
            }

            return ResultMatrix;
        }

        /// <summary>
        /// Метод который умножает матрицы, при не совпадении размером кидает исключение
        /// </summary>
        public static int[,] Multiplication(int[,] First, int[,] Second)
        {
            //Переменные для результирующей матрицы
            short strFirst = (short)First.GetLength(1);
            short colSecond = (short)Second.GetLength(0);

            int[,] ResultMatrix = new int[strFirst, colSecond];

            //Переменные для проверки умножаемость матриц
            short colFirst = (short)First.GetLength(0);
            short strSecond = (short)Second.GetLength(1);

            //Для умножения матриц обязательно нужно чтобы число столбцов первого было равна числу строк второго
            if (colFirst != strSecond)
            {
                Console.WriteLine("Умножение невозможно");
                throw new Exception("Умножение невозможно");
            }
            else
            {

                for (int i = 0; i < ResultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
                    {
                        ResultMatrix[i, j] = 0;

                        //Третий цикл для правильного выполнения умножения и добавления
                        for (int k = 0; k < ResultMatrix.GetLength(1); k++)
                        {
                            ResultMatrix[i, j] = ResultMatrix[i, j] + First[i, k] * Second[k, j];
                        }
                    }
                }
            }

            return ResultMatrix;
        }

        /// <summary>
        /// Метод который умножает матрицы, при не совпадении размером кидает исключение
        /// Перегрузка метода нужная для решения СЛАУ
        /// </summary>
        public static int[,] Multiplication(float[,] First, int[] Second)
        {
            //Переменные для проверки умножаемости
            short colFirst = (short)First.GetLength(1);
            short SecondSize = (short)Second.Length;

            //Переменная для размера результата
            short strFirst = (short)First.GetLength(0);
            int[,] ResultMatrix = new int[strFirst, 1];

            if (colFirst != SecondSize)
            {
                Console.WriteLine("Умножение невозможнo");
                throw new Exception("Умножение невозможнo");
            }
            else
            {
                //Три цикла как и в основном методе умножения
                for (int i = 0; i < ResultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < ResultMatrix.GetLength(1); j++)
                    {
                        for (int k = 0; k < ResultMatrix.GetLength(1); k++)
                        {
                            ResultMatrix[i, j] += (int)First[i, k] * Second[k];
                        }
                    }
                }
            }

            return ResultMatrix;
        }
    }
}
