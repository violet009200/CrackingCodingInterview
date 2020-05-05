using System;
using System.Collections.Generic;

namespace Helper
{
    public class Graph
    {
        int Size;
        public List<int>[] Adj;

        public Graph(int s)
        {
            Size = s;
            Adj = new List<int>[Size];

            for(int i =0; i<Size; i++)
            {
                Adj[i] = new List<int>();
            }
        }

        public void addEdge(int s, int e)
        {
            Adj[s].Add(e);
        }
    }
}
