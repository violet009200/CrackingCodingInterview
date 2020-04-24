using System;
using System.Collections.Generic;
using Helper;

namespace Chap2_LinkedLists
{
    public class DeleteMiddleNode
    {
        /*
         * space: O(1)
         * time: O(1)
         */
        public bool DeleteMiddle(Node<int> n)
        {
            if(n == null || n.Next == null) throw new ArgumentException(nameof(n));

            var nextNode = n.Next;
            n.Data = nextNode.Data;
            n.Next = nextNode.Next;

            return true;
        }
    }
}
