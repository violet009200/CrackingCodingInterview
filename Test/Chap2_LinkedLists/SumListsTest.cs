using System;
using Xunit;
using Helper;

namespace Chap2_LinkedLists
{
    public class SumListsTest
    {
        [Fact]
        public void ListHasSameLength()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            var input1 = helper.CreateLinkedList_Node(7, 1, 6);
            var input2 = helper.CreateLinkedList_Node(5, 9, 2);

            SumLists sum = new SumLists();

            var result = sum.SumList_reverse(input1, input2);

            string resultVal = helper.PrintLinkedList(result);

            Assert.Equal("2 1 9", resultVal);
        }

        [Fact]
        public void ListHasDifferentLength()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            var input1 = helper.CreateLinkedList_Node(7, 1, 6);
            var input2 = helper.CreateLinkedList_Node(5, 9);

            SumLists sum = new SumLists();

            var result = sum.SumList_reverse(input1, input2);

            string resultVal = helper.PrintLinkedList(result);

            Assert.Equal("2 1 7", resultVal);
        }
    }
}
