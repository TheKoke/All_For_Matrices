using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.Matrices
{
    class Hilbert
    {
        private double[,] HilMatrix;

        public double[,] GetHilbertMatrix(int Size)
        {
            HilMatrix = new double[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    HilMatrix[i, j] = 1 / (i + j + 1);
                }
            }

            return HilMatrix;
        }
    }
}
