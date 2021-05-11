using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.Matrices
{
    class Persymmetric : Exchange
    {
        private int[,] PerSymmetricMatrix;
       
        private void SetMatrix(int[,] Matrix)
        {
            Size = Matrix.GetLength(0);
            PerSymmetricMatrix = GetExchange();
        }

        private void SetDiagonal(int[,] Matrix)
        {
            for (int i = 0; i < PerSymmetricMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < PerSymmetricMatrix.GetLength(0); j++)
                {
                    if (i + j == PerSymmetricMatrix.GetLength(0) - 1)
                    {
                        PerSymmetricMatrix[i, j] = Matrix[i, j];
                    }
                }
            }
        }

        public int[,] GetMatrix(int[,] Matrix)
        {
            SetMatrix(Matrix);
            SetDiagonal(Matrix);

            return PerSymmetricMatrix;
        }
    }
}
