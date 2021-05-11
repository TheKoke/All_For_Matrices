using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.Matrices
{
    class Exchange
    {
        private int[,] ExchangeMatrix;
        public int Size { get; set; }

        public int[,] GetExchange()
        {
            ExchangeMatrix = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i + j == Size - 1)//Обозначение побочной диагонали матрицы
                    {
                        ExchangeMatrix[i, j] = 1;
                    }
                    else
                    {
                        //приравнивание симметричных элементов, относительно побочной диагонали
                        ExchangeMatrix[i, j] = ExchangeMatrix[Size - j - 1, Size - i - 1];
                    }
                }
            }

            return ExchangeMatrix;
        }
    }
}
