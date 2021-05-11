using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.OperationsOnMatrix
{
    class Determinants
    {
        /// <summary>
        /// Метод Определителя второго порядка, принимает квадратную матрицу размером = 2
        /// </summary>
        public static int Second_Order(int[,] Matrix)
        {
            //Вводим понятия положительной и отрицательной части определителя
            int positive = 1;
            int negative = 1;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    if (i == j)
                    {
                        positive *= Matrix[i, j];
                    }
                    else
                    {
                        negative *= Matrix[i, j];
                    }
                }
            }

            return positive - negative;
        }

        /// <summary>
        /// Метод находящий определитель матрицы порядка больше двух, работает через рекурсию
        /// </summary>
        public static int Resolve(int[,] Matrix)
        {
            //переменная для результата
            int result = 0;

            //нахождение с использованием миноров матрицы, происходит рекурсия
            if (Matrix.GetLength(0) == 2)
            {
                result += Second_Order(Matrix);
            }
            else
            {
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    //как и в определителе второго порядка обозначение положительной и отрицтельной части определителя
                    if (i % 2 == 0)
                    {
                        result += Matrix[0, i] * Resolve(SpecificAlgebra.GetMinor(Matrix, 0, i));
                    }
                    else
                    {
                        result -= Matrix[0, i] * Resolve(SpecificAlgebra.GetMinor(Matrix, 0, i));
                    }
                }
            }

            return result;
        }

    }
}
