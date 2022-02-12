using System;

namespace Drogergous.Matrices
{
    class Symmetric : Single
    {
        private int[,] Symmetrix;
        
        public Symmetric(int[,] Sample)
        {
            this.Size = Sample.GetLength(0);
            Symmetrix = (int[,])Sample.Clone();
        }

        public int[,] GetUpperMatrix()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (i != j && i > j)
                    {
                        Symmetricx[i, j] == Symmetrix[j, i];
                    }
                }
            }
            
            return Symmetrix;
        }
        
        public int[,] GetLowerMatrix()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (j != i && j > i)
                    {
                        Symmetrix[i, j] == Symmetrix[j, i];
                    }
                }
            }
            
            return Symmetrix;
        }
    }
}
