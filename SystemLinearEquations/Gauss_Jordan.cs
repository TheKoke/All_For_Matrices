using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous
{
    class Gauss_Jordan
    {
        //Поле для копирования матрицы системы для расчетов внутри класса
        private double[,] Clone_Matrix;

        //Сеттер для единственного поля
        private void SetClone(double[,] SoE_Matrix)
        {
            Clone_Matrix = new double[SoE_Matrix.GetLength(0), SoE_Matrix.GetLength(1)];

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < SoE_Matrix.GetLength(1); j++)
                {
                    Clone_Matrix[i, j] = SoE_Matrix[i, j];
                }
            }
        }

        /// <summary>
        /// Метод "Прямой ход", преоборазование главной диагонали в единичную
        /// </summary>
        private void DirectDivision(double[,] SoE_Matrix)
        {
            SetClone(SoE_Matrix);

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < SoE_Matrix.GetLength(1); j++)
                {
                    Clone_Matrix[i, j] = Clone_Matrix[i, j] / SoE_Matrix[i, i];
                }
            }
        }

        /// <summary>
        /// Метод "Обратный ход", обратное превращение главной диагонали в единичную
        /// </summary>
        private void ReverseDivision(double[,] SoE_Matrix)
        {
            SetClone(SoE_Matrix);

            for (int i = SoE_Matrix.GetLength(0) - 1; i > -1; i--)
            {
                for (int j = SoE_Matrix.GetLength(0); j > -1; j--)
                {
                    Clone_Matrix[i, j] = Clone_Matrix[i, j] / SoE_Matrix[i, i];
                }
            }
        }

        /// <summary>
        /// Метод Зануления левого нижнего угла матрицы системы
        /// </summary>
        private double[,] VanishingLeft(double[,] SoE_Matrix)
        {
            DirectDivision(SoE_Matrix);

            double Koeff;

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < SoE_Matrix.GetLength(0); j++)
                {
                    Koeff = Clone_Matrix[j, i] / Clone_Matrix[i, i];

                    for (int l = 0; l < SoE_Matrix.GetLength(1); l++)
                    {
                        Clone_Matrix[j, l] -= Clone_Matrix[i, l] * Koeff;
                    }
                }
            }

            double[,] Result = new double[SoE_Matrix.GetLength(0), SoE_Matrix.GetLength(1)];

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < SoE_Matrix.GetLength(1); j++)
                {
                    Result[i, j] = Clone_Matrix[i, j];
                }
            }

            return Result;
        }

        /// <summary>
        /// Метод Зануление правого верхнего угла матрицы системы
        /// </summary>
        private double[,] VanishingRight(double[,] SoE_Matrix)
        {
            ReverseDivision(VanishingLeft(SoE_Matrix));

            double koeff;

            for (int i = SoE_Matrix.GetLength(0) - 1; i > -1; i--)
            {
                for (int j = i - 1; j > -1; j--)
                {
                    koeff = Clone_Matrix[j, i] / Clone_Matrix[i, i];

                    for (int k = SoE_Matrix.GetLength(0); k > -1; k--)
                    {
                        Clone_Matrix[j, k] = Clone_Matrix[j, k] - Clone_Matrix[i, k] * koeff;
                    }
                }
            }

            double[,] Result = new double[SoE_Matrix.GetLength(0), SoE_Matrix.GetLength(1)];

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < SoE_Matrix.GetLength(1); j++)
                {
                    Result[i, j] = Clone_Matrix[i, j];
                }
            }

            return Result;
        }

        /// <summary>
        /// Метод возвращающий решения системы
        /// </summary
        public double[] GetSolutions(int[,] SoE_Matrix)
        {
            double[,] SMatrix = new double[SoE_Matrix.GetLength(0), SoE_Matrix.GetLength(1)];

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < SoE_Matrix.GetLength(1); j++)
                {
                    SMatrix[i, j] = SoE_Matrix[i, j];
                }
            }

            double[,] VanishMatrix = VanishingLeft(SMatrix);

            VanishMatrix = VanishingRight(VanishMatrix);

            double[] Solutions = new double[SoE_Matrix.GetLength(0)];

            for (int i = 0; i < SoE_Matrix.GetLength(0); i++)
            {
                Solutions[i] = VanishMatrix[i, SoE_Matrix.GetLength(0)];                
            }

            return Solutions;
        }
    }
}
