using System;
using System.Collections.Generic;

namespace Chap2_LinkedLists
{
    public class RemoveDups
    {
        /*
         * Time: O(n)
         * Space: O(n)
         */
        public LinkedList<int> RemoveDups1(LinkedList<int> input)
        {
            //using Dictionary
            Dictionary<int, bool> table = new Dictionary<int, bool>();
            var head = input.First;

            LinkedList<int> result = new LinkedList<int>();

            while(head != null)
            {
                if (table.ContainsKey(head.Value)) head = head.Next;
                else
                {
                    table.Add(head.Value, true);
                    result.AddLast(head.Value);
                    head = head.Next;
                }
            }

            return result;
        }

        /*
         * Time O(n^2)
         * space O(1)
         */
        public LinkedList<int> RemoveDup_NoBuffer(LinkedList<int> input)
        {
            var current = input.First;

            while(current != null)
            {
                var runner = current;
                var runnerNext = runner.Next;

                while(runnerNext != null)
                {
                    if (runnerNext.Value == current.Value)
                    {
                        runner = runnerNext.Next;
                        input.Remove(runnerNext);
                        runnerNext = runner.Next;
                    }
                    else
                    { 
                        runner = runner.Next;
                        runnerNext = runner.Next;
                    }
                }

                current = current.Next;
            }

            return input;
        }
    }
}
