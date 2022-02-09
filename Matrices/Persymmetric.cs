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

        public int[,] GetUpperMatrix(int[,] Matrix)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i + j == Size - 1)
                    {
                        PerSymmetricMatrix[i, j] = Matrix[i, j];
                    }
                    
                    if (i + j <= Size - 2)
                    {
                        PerSymmetricMatrix[i, j] = Matrix[i, j];
                    }
                    
                    if (i + j >= Size - 2)
                    {
                        PerSymmertricMatrix[i, j] = Matrix[Size - i - 1, Size - j - 1];
                    }
                }
            }
            
            return PerSymmetricMatrix;
        }
        
        public int[,] GetLowerMatrix(int[,] Matrix)
        {
            for (int i = Size - 1; i >= 0; i--)
            {
                for (int j = Size - 1; j >= 0; j--)
                {
                    if (i + j == Size - 1)
                    {
                        PerSymmetricMatrix[i, j] = Matrix[i, j];
                    }
                    
                    if (i + j >= Size - 2)
                    {
                        PerSymmetricMatrix[i, j] = Matrix[i, j];
                    }
                    
                    if (i + j <= Size - 2)
                    {
                        PerSymmertricMatrix[i, j] = Matrix[Size - i - 1, Size - j - 1];
                    }
                }
            }
            
            return PerSymmetricMatrix;
        }
    }
}
