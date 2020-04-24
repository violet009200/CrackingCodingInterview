using System;
using Xunit;
using Helper;

namespace Chap2_LinkedLists
{
    public class PartitionTest
    {
        [Fact]
        public void BasicTest()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            Node<int> head = helper.CreateLinkedList_Node(3,5,8,5,10,2,1);
            Partition p = new Partition();

            Node<int> resultHead = p.PartitionList(head, 5);
            string result = helper.PrintLinkedList(resultHead);

            Assert.Equal("3 2 1 5 8 5 10", result);
        }
    }
}
