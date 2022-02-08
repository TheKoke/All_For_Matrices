using System;

namespace Drogergous.Matrices
{
    class Persymmetric : Exchange
    {
        private int[,] PerSymmetricMatrix;
       
        public Persymmetric(int[,] Sample)
        {
            Size = Sample.GetLength(0);
            PerSymmetricMatrix = GetExchange();
        }

        private void SetDiagonal(int[,] Sample)
        {
            for (int i = 0; i < PerSymmetricMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < PerSymmetricMatrix.GetLength(1); j++)
                {
                    if (i + j == PerSymmetricMatrix.GetLength(0) - 1)
                    {
                        PerSymmetricMatrix[i, j] = Sample[i, j];
                    }
                }
            }
        }

        public int[,] GetMatrix(int[,] Matrix)
        {
            SetDiagonal(Matrix);
            return PerSymmetricMatrix;
        }
    }
}
