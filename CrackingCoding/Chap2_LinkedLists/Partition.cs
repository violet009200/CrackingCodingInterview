using System;
using Helper;

namespace Chap2_LinkedLists
{
    public class Partition
    {
        public Node<int> PartitionList(Node<int> head, int k)
        {
            Node<int> smallerLast = null;
            Node<int> smallerHead = null;

            Node<int> biggerHead = null;
            Node<int> biggerLast = null;


            while (head != null)
            {
                var nodeToAdd = new Node<int>(head.Data);

                if (head.Data.CompareTo(k) < 0)
                {
                    if (smallerLast == null)
                    {
                        smallerHead = nodeToAdd;
                        smallerLast = nodeToAdd;
                    }
                    else
                    {
                        smallerLast.Next = nodeToAdd;
                        smallerLast = nodeToAdd;
                    }
                }
                else
                {
                    if (biggerLast == null)
                    {
                        biggerHead = nodeToAdd;
                        biggerLast = nodeToAdd;
                    }
                    else
                    {
                        biggerLast.Next = nodeToAdd;
                        biggerLast = nodeToAdd;
                    }
                }

                head = head.Next;
            }

            if (smallerHead == null)
            {
                return biggerHead;
            }
            else
            {
                smallerLast.Next = biggerHead;
                return smallerHead;
            }
        }
    }
}
