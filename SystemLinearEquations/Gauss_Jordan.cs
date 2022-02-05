using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous
{
    class Gauss_Jordan
    {
        private double[,] Clone_Matrix;

        private void SetClone(double[,] SLE_Matrix)
        {
            Clone_Matrix = new double[SLE_Matrix.GetLength(0), SLE_Matrix.GetLength(1)];

            for (int i = 0; i < SLE_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < SLE_Matrix.GetLength(1); j++)
                {
                    Clone_Matrix[i, j] = SLE_Matrix[i, j];
                }
            }
        }

        private void DirectDivision(double[,] SLE_Matrix)
        {
            SetClone(SLE_Matrix);

            for (int i = 0; i < SLE_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < SLE_Matrix.GetLength(1); j++)
                {
                    Clone_Matrix[i, j] = Clone_Matrix[i, j] / SLE_Matrix[i, i];
                }
            }
        }

        private void ReverseDivision(double[,] SLE_Matrix)
        {
            SetClone(SLE_Matrix);

            for (int i = SLE_Matrix.GetLength(0) - 1; i > -1; i--)
            {
                for (int j = SLE_Matrix.GetLength(0); j > -1; j--)
                {
                    Clone_Matrix[i, j] = Clone_Matrix[i, j] / SLE_Matrix[i, i];
                }
            }
        }

        private double[,] VanishingLeft(double[,] SLE_Matrix)
        {
            DirectDivision(SoE_Matrix);

            double Koeff;

            for (int i = 0; i < SLE_Matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < SLE_Matrix.GetLength(0); j++)
                {
                    Koeff = Clone_Matrix[j, i] / Clone_Matrix[i, i];

                    for (int l = 0; l < SLE_Matrix.GetLength(1); l++)
                    {
                        Clone_Matrix[j, l] -= Clone_Matrix[i, l] * Koeff;
                    }
                }
            }

            return Clone_Matrix;
        }

        private double[,] VanishingRight(double[,] SLE_Matrix)
        {
            ReverseDivision(VanishingLeft(SLE_Matrix));

            double koeff;

            for (int i = SLE_Matrix.GetLength(0) - 1; i > -1; i--)
            {
                for (int j = i - 1; j > -1; j--)
                {
                    koeff = Clone_Matrix[j, i] / Clone_Matrix[i, i];

                    for (int k = SLE_Matrix.GetLength(0); k > -1; k--)
                    {
                        Clone_Matrix[j, k] = Clone_Matrix[j, k] - Clone_Matrix[i, k] * koeff;
                    }
                }
            }

            return Clone_Matrix;
        }

        public double[] GetSolutions(int[,] SLE_Matrix)
        {
            SLE_Matrix = VanishingLeft(SLE_Matrix);

            SLE_Matrix = VanishingRight(SLE_Matrix);

            double[] Solutions = new double[SLE_Matrix.GetLength(0)];

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                Solutions[i] = VanishMatrix[i, SLE_Matrix.GetLength(0)];                
            }

            return Solutions;
        }
    }
}
