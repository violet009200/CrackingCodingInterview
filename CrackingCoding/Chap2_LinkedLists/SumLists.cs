using System;
using Helper;

namespace Chap2_LinkedLists
{
    public class SumLists
    {
        /*
         * time: O(n)
         * space O(n)
         */
        public Node<int> SumList_reverse(Node<int> head1, Node<int> head2)
        {
            if (head1 == null && head2 == null) throw new ArgumentNullException("input list is null");

            Node<int> result = null;
            Node<int> resultHead = null;

            int val = 0;
            int carry = 0;
            int digit = 0;

            while(head1!= null || head2 != null)
            {
                int data1 = 0;
                int data2 = 0;

                if (head1 != null) data1 = head1.Data;
                if (head2 != null) data2 = head2.Data;

                val = data1 + data2 + carry;
                digit = val % 10;
                carry = val / 10;

                if(resultHead == null)
                {
                    resultHead = new Node<int>(digit);
                    result = resultHead;
                }
                else
                {
                    result.Next = new Node<int>(digit);
                    result = result.Next;
                }

                head1 = head1?.Next;
                head2 = head2?.Next;
            }

            return resultHead;
        }

    }
}
