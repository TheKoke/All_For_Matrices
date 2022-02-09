using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.Matrices
{
    class Single
    {
        private int[,] SingleMatrix;
        public int Size { get; private set; }
        
        public Single(int size)
        {
            this.Size = size;
        }

        public int[,] GetSingle()
        {
            SingleMatrix = new int[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j)
                    {
                        SingleMatrix[i, j] = 1;
                    }
                    else
                    {
                        SingleMatrix[i, j] = SingleMatrix[j, i];
                    }
                }
            }

            return SingleMatrix;
        }
    }
}
