using System;
using System.Collections.Generic;
using Helper;
using Xunit;


namespace Chap2_LinkedLists
{
    public class RemoveDupsTest
    {
        [Fact]
        public void CreateLinkedList()
        {
            LinkedListHelper<int> listHelper = new LinkedListHelper<int>();
            LinkedList<int> result = listHelper.CreateLinkedList(1, 2, 3, 4, 5);

            LinkedList<int> expected = new LinkedList<int>();
            expected.AddLast(1);
            expected.AddLast(2);
            expected.AddLast(3);
            expected.AddLast(4);
            expected.AddLast(5);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void NoDuplicates()
        {
            LinkedListHelper<int> listHelper = new LinkedListHelper<int>();
            LinkedList<int> inputList = listHelper.CreateLinkedList(1, 2, 7, 4, 5);
            LinkedList<int> expected = listHelper.CreateLinkedList(1, 2, 7, 4, 5);
            RemoveDups rdups = new RemoveDups();
            LinkedList<int> result = rdups.RemoveDups1(inputList);

            LinkedList<int> result1 = rdups.RemoveDup_NoBuffer(inputList);

            Assert.Equal(expected, result);
            Assert.Equal(expected, result1);
        }

        [Fact]
        public void WithDuplicates()
        {
            LinkedListHelper<int> listHelper = new LinkedListHelper<int>();
            LinkedList<int> inputList = listHelper.CreateLinkedList(1, 2, 7, 1, 5, 7,9);
            LinkedList<int> expected = listHelper.CreateLinkedList(1, 2, 7, 5,9);

            RemoveDups rdups = new RemoveDups();
            LinkedList<int> result = rdups.RemoveDups1(inputList);

            LinkedList<int> inputList1 = listHelper.CreateLinkedList(1, 2, 2, 3, 2, 4, 3, 5, 5, 6);
            LinkedList<int> expected1 = listHelper.CreateLinkedList(1, 2, 3, 4, 5, 6);
            LinkedList<int> result1 = rdups.RemoveDups1(inputList1);

            LinkedList<int> result2 = rdups.RemoveDup_NoBuffer(inputList);
            LinkedList<int> result3 = rdups.RemoveDup_NoBuffer(inputList1);


            Assert.Equal(expected, result);
            Assert.Equal(expected1, result1);

            Assert.Equal(expected, result2);
            Assert.Equal(expected1, result3);
        }
    }
}
