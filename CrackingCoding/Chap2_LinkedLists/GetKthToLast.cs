using System;
using System.Collections.Generic;

namespace Chap2_LinkedLists
{
    public class GetKthToLast
    {
       public int GetKth_WithSizeInput(LinkedList<int> input, int k)
        {
            int size = input.Count;
            if (size < k) throw new ArgumentException("k is bigger than size");
            if (size == k) return input.First.Value;

            int cnt = size - k;

            var head = input.First;

            while(cnt > 0)
            {
                head = head.Next;
                cnt--;
            }

            return head.Value;
        }

        /*
         * time O(n)
         * space O(1)
         */
        public int GetKth_WithOutSizeInput(LinkedList<int> input, int k)
        {
            var result = input.First;
            var runner = input.First;

            k = k - 1;

            while(k > 0)
            {
                if (runner.Next != null)
                {
                    runner = runner.Next;
                    k--;
                }
                else throw new ArgumentException("K is bigger than size of input");
            }

            while(runner.Next != null)
            {
                runner = runner.Next;
                result = result.Next;
            }

            return result.Value;
        }
    }
}
