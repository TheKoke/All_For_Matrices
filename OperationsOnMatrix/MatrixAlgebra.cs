using System;

namespace Drogergous.OperationsOnMatrix
{
    class SpecificAlgebra
    {
        private static int[,] MinorMatrix;

        public static int[,] GetMinor(int[,] Matrix, int DelStr, int DelCol)
        {
            MinorMatrix = new int[Matrix.GetLength(0) - 1, Matrix.GetLength(1) - 1];
            
            short varForIndexStr = 0;
            short varForIndexCol = 0;

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                if (i == DelStr)
                    continue;
               
               for (int j = 0; j < Matrix.GetLength(0); j++)
               {
                    if (j == DelCol)
                        continue;
                    
                    MinorMatrix[varForIndexStr, varForIndexCol] = Matrix[i, j];
                    varForIndexCol++;
                }
                
                varForIndexStr++;
                varForIndexCol = 0;
            }

            return MinorMatrix;
            
        }

        public static int AlgebraicApp(int[,] Matrix, int firstIndex, int SecIndex)
        {
            GetMinor(Matrix, firstIndex, SecIndex);

            int result = (int)(Math.Pow(-1, firstIndex + SecIndex) * Determinants.Resolve(MinorMatrix));

            return result;
        }
    }
}
