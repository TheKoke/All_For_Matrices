﻿using System;
using System.Collections.Generic;
using System.Text;

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
            int result = 0;

            if (Matrix.GetLength(0) == 2)
            {
                result += Second_Order(Matrix);
            }
            else
            {
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
            }

            return result;
        }

    }
}
