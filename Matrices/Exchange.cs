using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.Matrices
{
    class Exchange
    {
        private int[,] ExchangeMatrix;
        public int Size { get; protected set; }
        
        public Echange(int size)
        {
            this.Size = size;
        }  

        public int[,] GetExchange()
        {
            ExchangeMatrix = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i + j == Size - 1)
                    {
                        ExchangeMatrix[i, j] = 1;
                    }
                }
            }

            return ExchangeMatrix;
        }
    }
}
