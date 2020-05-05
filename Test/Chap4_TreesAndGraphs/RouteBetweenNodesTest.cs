using System;
using Xunit;
using Helper;

namespace Chap4_TreesAndGraphs
{
    public class RouteBetweenNodeTest
    {
        [Fact]
        public void BasicTest()
        {
            Graph g = new Graph(5);

            g.addEdge(0, 1);
            g.addEdge(0, 2);
            g.addEdge(1, 2);
            g.addEdge(2, 0);
            g.addEdge(2, 3);
            g.addEdge(3, 3);
            g.addEdge(4, 1);

            RouteBetweenNodes isConnected = new RouteBetweenNodes();
            var result = isConnected.isConnected(g, 1, 3);
            Assert.True(result);

            result = isConnected.isConnected(g, 2, 4);
            Assert.False(result);
        }
    }  
}
