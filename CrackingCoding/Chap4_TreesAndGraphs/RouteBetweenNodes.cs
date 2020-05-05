using System;
using System.Collections.Generic;
using Helper;

namespace Chap4_TreesAndGraphs
{
    public class RouteBetweenNodes
    {
        //BSF
        public bool isConnected(Graph g, int s, int e)
        {
            if (s == e) return true;

            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();

            queue.Enqueue(s);

            while (queue.Count != 0)
            {
                int val = queue.Dequeue();
                if (val == e) return true;
                visited.Add(val);

                var adj = g.Adj[val];
                if (adj != null)
                {
                    foreach (int a in adj)
                    {
                        if (!visited.Contains(a))
                        {
                            queue.Enqueue(a);
                        }
                    }
                }
            }

            return false;
            
        }
    }
}
