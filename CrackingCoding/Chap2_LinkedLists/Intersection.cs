using System;
using Helper;

namespace Chap2_LinkedLists
{
    public class Intersection
    {
        public Node<int> FindIntersection(Node<int> list1, Node<int> list2)
        {
            if (list1 == null || list2 == null) return null;

            int list1Size = GetLength(list1);
            int list2Size = GetLength(list2);

            if (!IsIntersection(list1, list2)) return null;

            if(list1Size > list2Size)
            {
                for(int i = 0; i< list1Size - list2Size; i++)
                {
                    list1 = list1.Next;
                }
            }
            else
            {
                for(int i = 0; i<list2Size-list1Size; i++)
                {
                    list2 = list2.Next;
                }
            }

            while(list1.Next != null)
            {
                if (ReferenceEquals(list1, list2)) return list1;
                else
                {
                    list1 = list1.Next;
                    list2 = list2.Next;
                }
            }

            return null;

        }

        public bool IsIntersection(Node<int> list1, Node<int> list2)
        {
            return GetTail(list1) == GetTail(list2) ? true : false;
        }

        public Node<int> GetTail(Node<int> list)
        {
            var cur = list;
            while(cur.Next != null)
            {
                cur = cur.Next;
            }

            return cur;
        }

        public int GetLength(Node<int> list)
        {
            int size = 0;
            while(list.Next != null)
            {
                size++;
                list = list.Next;
            }

            return size;
        }

        public void CreateIntersection(Node<int> list1, Node<int> list2, Node<int> intersection)
        {
            while (list1.Next != null) list1 = list1.Next;
            list1.Next = intersection;

            while (list2.Next != null) list2 = list2.Next;
            list2.Next = intersection;
        }
    }
}
