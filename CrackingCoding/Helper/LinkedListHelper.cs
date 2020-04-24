using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    public class LinkedListHelper<T> where T : IEquatable<T>
    {
        //create LinkedList
        public LinkedList<T> CreateLinkedList(params T[] input)
        {
            if (input == null) throw new ArgumentNullException("input is null");

            LinkedList<T> list = new LinkedList<T>();

            foreach(var val in input)
            {
                list.AddLast(val);      
            }

            return list;
        }

        public Node<T> CreateLinkedList_Node(params T[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var head = new Node<T>(input[0]);
            Node<T> cur = head;

            for (int i = 1; i < input.Length; i++)
            {
                var next = new Node<T>(input[i]);
                cur.Next = next;
                cur = cur.Next;
            }

            return head;
        }


        public string PrintLinkedList(Node<T> head)
        {
            StringBuilder sb = new StringBuilder();

            if (head == null) throw new ArgumentNullException("head is null");

            sb.Append(head.Data);

            while (head.Next != null)
            {
                head = head.Next;
                sb.Append(" ");
                sb.Append(head.Data);
            }

            return sb.ToString();
        }
    }

    
}
