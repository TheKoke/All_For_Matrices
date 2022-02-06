using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.SystemLinearEquations
{
    class InverseMethod
    {
        private float[,] Inverse;
        private int[] Solutins;

        public int[] GetSolutions(int[,] Matrix, int[] FreeNums)
        {
            if (OperationsOnMatrix.Determinants.Resolve(Matrix) == 0)
            {
                throw new Exception("Определитель равен нулю, используйте метод Гаусса-Жордана");
            }

            Inverse = OperationsOnMatrix.MatrixChanger.InverseMatrix(Matrix);

            int[,] ResultMultiplication = MatrixMath.TwoMatrices.Multiplication(Inverse, FreeNums);

            Solutins = new int[FreeNums.Length];

            for (int i = 0; i < FreeNums.Length; i++)
            {
                Solutins[i] = ResultMultiplication[0, i];
            }

            return Solutins;
        }
    }
}
