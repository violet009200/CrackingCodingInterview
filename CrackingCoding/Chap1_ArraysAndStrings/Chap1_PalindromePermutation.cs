using System;
using System.Collections.Generic;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_PalindromePermutation
    {
        /*
         * space O(n)
         * time O(n)
         * n is unique number of chars
         */
        public bool isPalindromePermutation(string input)
        {
            //check input is null or empty
            if (string.IsNullOrEmpty(input))
            {
                //throw new ArgumentException("input cannot be null or empty", nameof(input));
                return false;
            }

            Dictionary<char, bool> dic = new Dictionary<char, bool>();

            foreach(var ch in input)
            {
                bool val;
                dic.TryGetValue(ch, out val);
                dic[ch] = !val; // odd number of char will save false, even number of char will save true
            }

            bool hasOdd = false;

            foreach(var key in dic.Keys)
            {
                if (dic[key]) //string length is odd
                {
                    if (hasOdd) return false;
                    else hasOdd = true;
                }
            }

            return true; //all charater has even number
            
        }
    }
}
