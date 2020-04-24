using System;
using Xunit;
using Helper;
using System.Collections.Generic;

namespace Chap2_LinkedLists
{
    public class DeleteMiddleNodeTest
    {
        [Fact]
        public void BasicTest()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            var input = helper.CreateLinkedList_Node(1, 2, 3, 4, 5);

            var target = input.Next.Next;
            DeleteMiddleNode delete = new DeleteMiddleNode();
            var result = delete.DeleteMiddle(target);

            Assert.True(result);

        }

    }
}
