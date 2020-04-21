using System;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_RotateMatrix
    {
        /*
         * Runtime: o(n^2)
         * space:o(n^2)
         */
        public int[,] RotateMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            //create new Array
            int[,] result = new int[size, size];

            for(int i = 0; i < size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    result[j, size-1-i] = matrix[i, j];
                }
            }
            return result;
        }

        /*
         * runtime: o(n^2)
         */
        public int[,] RotateMatrix_inPlace(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            if (size == 1) return matrix;
            //swap matrix top with left, bottom, right
            int curLevel = 0;
            int totalLevel = size / 2;
            int last = size - 1;

            while (curLevel < totalLevel)
            {
                for (int i = curLevel; i < last; i++)
                {
                    //left
                    int top = matrix[curLevel, i];                   
                    matrix[curLevel, i] = matrix[i, last];
                    matrix[i, last] = top;

                    //bottom
                    top = matrix[curLevel, i];
                    //top = matrix[last, last - i + curLevel];
                    matrix[curLevel, i] = matrix[last, last - i + curLevel];
                    matrix[last, last - i + curLevel] = top;

                    //right
                    top = matrix[curLevel, i];
                    matrix[curLevel, i] = matrix[last - i + curLevel, curLevel];
                    matrix[last - i + curLevel, curLevel] = top;

                }
                curLevel++;
                last--;
            }

            return matrix;

        }

        public int[,] CreateMatrix(params int[] input)
        {
            if (input == null) throw new ArgumentException("matrix is null");
            int size = getSizeMatrix(input);

            int[,] result = new int[size,size];
            int cnt = 0;

            for(int i = 0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    result[i,j] = input[cnt++];
                }
            }

            return result;
        }

        private int getSizeMatrix(params int[] input)
        {
            double size = Math.Sqrt(input.Length);

            if(size%1 != 0)
            {
               throw new ArgumentException("matrix is not square");
            }

            return (int)size;
        }
    }
}
