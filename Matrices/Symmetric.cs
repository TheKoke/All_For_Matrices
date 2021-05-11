using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.Matrices
{
    class Symmetric : Single
    {
        private int[,] SymmetricMatrix;
        
        private void SetMatrix(int[,] Matrix)
        {
            Size = Matrix.GetLength(0);

            SymmetricMatrix = GetSingle();
        }

        private void SetDiagonal(int[,] Matrix)
        {
            for (int i = 0; i < Size; i++)
            {
                SymmetricMatrix[i, i] = Matrix[i, i];
            }
        }

        public int[,] GetMatrix(int[,] Matrix)
        {
            SetMatrix(Matrix);
            SetDiagonal(Matrix);

            return SymmetricMatrix;
        }
    }
}
