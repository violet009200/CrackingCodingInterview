using System;
using System.Collections.Generic;

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
    }

    
}
