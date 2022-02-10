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
                    if (i - j <= Size - 1 && i - j > 0)
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
                    if (j - i <= Size - 1 && j - i > 0)
                    {
                        Symmetrix[i, j] == Symmetrix[j, i];
                    }
                }
            }
            
            return Symmetrix;
        }
    }
}
