using System;
using System.Collections.Generic;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_ZeroMatrix
    {
        /*
         * space: O(N)
         * time: O(N*M)
         */
        public int[,] ZeroMatrix(int[,] m)
        {
            List<int> rows = new List<int>();
            List<int> cols = new List<int>();


            for(int i = 0; i < m.GetLength(0); i++)
            {
                for(int j=0; j<m.GetLength(1); j++)
                {
                    if(m[i,j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }

            foreach(int r in rows)
            {
                for(int i = 0; i < m.GetLength(1); i++)
                {
                    m[r,i] = 0;
                }
            }

            foreach (int c in cols)
            {
                for (int i = 0; i < m.GetLength(0); i++)
                {
                    m[i,c] = 0;
                }
            }

            return m;
        }

        public int[,] CreateMatrix(int m, int n, params int[] input)
        {
            if (input == null) throw new ArgumentException("matrix is null");

            int[,] result = new int[m, n];
            int cnt = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = input[cnt++];
                }
            }

            return result;
        }
    }
}
