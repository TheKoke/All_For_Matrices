using System;

namespace Drogergous.OperationsOnMatrix
{
    class Determinants
    {
        public static int Resolve(int[,] Matrix)
        {
            if (Matrix.GetLength(0) != Matrix.GetLength(1))
            {
                return int.MinValue;
            }
            
            if (Matrix.GetLength(0) == 1)
            {
                return Matrix[0, 0];
            }
            
            int result = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                result += Matrix[0, i] * MatrixAlgebra.AlgebraicApp(Matrix, 0, i);
            }

            return result;
        }
        
        public static float Resolve(float[,] Matrix)
        {
            if (Matrix.GetLength(0) != Matrix.GetLength(1))
            {
                return float.MinValue;
            }
            
            if (Matrix.GetLength(0) == 1)
            {
                return Matrix[0, 0];
            }
            
            float result = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                result += Matrix[0, i] * MatrixAlgebra.AlgebraicApp(Matrix, 0, i);
            }
            
            return result;
        }
    }
}
