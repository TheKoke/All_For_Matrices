﻿using System;

namespace Drogergous.OperationsOnMatrix
{
    class MatrixChanger
    {
        private static int[,] Changed;

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

            return TransMatrix(Changed);
        }

        public static float[,] InverseMatrix(int[,] Matrix)
        {
            Changed = AddJointMatrix(Matrix);

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    (float)Changed[i, j] /= Determinants.Resolve(Matrix);
                }
            }

            return Changed;
        }
    }
}
