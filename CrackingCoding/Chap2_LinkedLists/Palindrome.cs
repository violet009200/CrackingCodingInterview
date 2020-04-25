using System;
using Helper;

namespace Chap2_LinkedLists
{
    public class Palindrome
    {
        public bool isPalindrome(Node<int> head)
        {
            if (head == null) throw new ArgumentNullException("node is null");

            var reversed = Reverse(head);

            while(head != null)
            {
                if (head.Data == reversed.Data)
                {
                    head = head.Next;
                    reversed = reversed.Next;
                }
                else return false;
            }

            return true;
        }

        public Node<int> Reverse(Node<int> head)
        {
            if (head == null) throw new ArgumentNullException("node is null");

            Node<int> reverseHead = null;

            while(head != null)
            {
                Node<int> tmp = new Node<int>(head.Data); // clone
                tmp.Next = reverseHead;
                reverseHead = tmp;
                head = head.Next;
            }
            return reverseHead;
        }
    }
}
