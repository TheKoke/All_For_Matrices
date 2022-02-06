using System;
using System.Collections.Generic;
using System.Text;

namespace Drogergous.SystemAlgebraicEquations
{
    class Kramer
    {
        private int[,] System_Matrix;
        private int[] Deltas;

        public int Size { get; private set; }

        public Kramer(int size)
        {
            this.Size = size;
        }

        private void SetDeltas(int[,] Matrix, int[] FreeNums)
        {
            Deltas = new int[Size];

            for (int i = 0; i < Size; i++)
            {
                System_Matrix = (int[,])Matrix.Clone();
                
                for (int j = 0; j < Size; j++)
                {
                    System_Matrix[j, i] = FreeNums[j];
                }

                Deltas[i] = OperationsOnMatrix.Determinants.Resolve(System_Matrix);
            }
        }

        public int[] GetSolutions(int[,] Matrix, int[] FreeNums)
        {
            if (OperationsOnMatrix.Determinants.Resolve(Matrix) == 0)
            {
                throw new Exception("Определитель равен нулю, используйте метод Гаусса-Жордана");
            }

            SetDeltas(Matrix, FreeNums);

            int[] Solutions = new int[Size];

            for (int i = 0; i < Size; i++)
            {
                Solutions[i] = Deltas[i] / OperationsOnMatrix.Determinants.Resolve(Matrix);
            }

            return Solutions;
        }
    }
}
