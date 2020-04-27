using System;
using Xunit;
using Helper;

namespace Chap2_LinkedLists
{
    public class IntetsectionTest
    {
        [Fact]
        public void FindIntersectioWithNoIntersection()
        {
            Intersection i = new Intersection();
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            Node<int> list1 = helper.CreateLinkedList_Node(1, 2, 3, 4);
            Node<int> list2 = helper.CreateLinkedList_Node(5, 6, 7, 8);

            Node<int> result = i.FindIntersection(list1, list2);

            Assert.Null(result);
        }

        [Fact]
        public void FindIntersectionWithIntersection()
        {
            Intersection i = new Intersection();
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            Node<int> list1 = helper.CreateLinkedList_Node(1, 2, 3, 4);
            Node<int> list2 = helper.CreateLinkedList_Node(5, 6, 7, 8);

            Node<int> intersection = helper.CreateLinkedList_Node(9, 10, 11);

            i.CreateIntersection(list1, list2, intersection);

            Node<int> result = i.FindIntersection(list1, list2);

            Assert.Equal("9", result.Data.ToString());
        }

        [Fact]
        public void IsIntersectionWithNoIntersection()
        {
            Intersection i = new Intersection();
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            Node<int> list1 = helper.CreateLinkedList_Node(1, 2, 3, 4);
            Node<int> list2 = helper.CreateLinkedList_Node(5, 6, 7, 8);

            bool result = i.IsIntersection(list1, list2);

            Assert.False(result);
        }

        [Fact]
        public void IstIntersectionWithIntersection()
        {
            Intersection i = new Intersection();
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            Node<int> list1 = helper.CreateLinkedList_Node(1, 2, 3, 4);
            Node<int> list2 = helper.CreateLinkedList_Node(5, 6, 7, 8);

            Node<int> intersection = helper.CreateLinkedList_Node(9, 10, 11);

            i.CreateIntersection(list1, list2, intersection);

            bool result = i.IsIntersection(list1, list2);

            Assert.True(result);
        }

        [Fact]
        public void TestIntersection()
        {
            Intersection i = new Intersection();
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            Node<int> list1 = helper.CreateLinkedList_Node(1, 2, 3, 4);
            Node<int> list2 = helper.CreateLinkedList_Node(5, 6, 7, 8);

            Node<int> intersection = helper.CreateLinkedList_Node(9, 10, 11);

            i.CreateIntersection(list1, list2, intersection);

            var list1Result = helper.PrintLinkedList(list1);
            var list2Result = helper.PrintLinkedList(list2);

            Assert.Equal("1 2 3 4 9 10 11", list1Result);
            Assert.Equal("5 6 7 8 9 10 11", list2Result);
        }
    }
}
