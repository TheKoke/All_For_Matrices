using System;

namespace Drogergous.OperationsOnMatrix
{
    class Determinants
    {
        public static int Second_Order(int[,] Matrix)
        { 
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

        public static int Resolve(int[,] Matrix)
        {
            if (Matrix.GetLength(0) == 2)
            {
                return Second_Order(Matrix);
            }
            
            int result = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    result += Matrix[0, i] * Resolve(MatrixAlgebra.GetMinor(Matrix, 0, i));
                }
                else
                {
                    result -= Matrix[0, i] * Resolve(MatrixAlgebra.GetMinor(Matrix, 0, i));
                }
            }

            return result;
        }
    }
}
