using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.OperationsOnMatrix
{
    class ChangeMatrix
    {
        private static int[,] Changed;

        /// <summary>
        /// Метод находящий транспонираванную матрицу
        /// </summary>
        public static int[,] TransMatrix(int[,] Matrix)
        {
            Changed = new int[Matrix.GetLength(0), Matrix.GetLength(1)];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    Changed[i, j] = Matrix[j, i];
                }
            }

            return Changed;
        }

        /// <summary>
        /// Метод находящий дополненную матрицу
        /// </summary>
        public static int[,] AddJointMatrix(int[,] Matrix)
        {
            Changed = new int[Matrix.GetLength(0), Matrix.GetLength(1)];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Changed[i, j] = SpecificAlgebra.AlgebraicApp(Matrix, i, j);
                }
            }

            Changed = TransMatrix(Changed);

            return Changed;
        }

        /// <summary>
        /// Метод находящий обратную матрицу
        /// </summary>
        public static float[,] InverseMatrix(int[,] Matrix)
        {
            Changed = AddJointMatrix(Matrix);

            float[,] Inverse = new float[Matrix.GetLength(0), Matrix.GetLength(1)];

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    Inverse[i, j] = (float)Changed[i, j] / Determinants.Resolve(Matrix);
                }
            }

            return Inverse;
        }
    }
}
