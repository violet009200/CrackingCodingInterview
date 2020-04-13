using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_CheckPermutation
    {
        /*
         * using Dictionary
         * O(n)
         */
        private bool IsPermutation1(string a, string b)
        {
            if (a.Length != b.Length) return false;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach(var ch in a)
            {
                if (dic.ContainsKey(ch)) dic[ch]++;
                else dic.Add(ch, 1);
            }

            foreach(var ch in b)
            {
                if (dic.ContainsKey(ch))
                {
                    dic[ch]--;
                    if (dic[ch] < 0) return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsPermutation2(string a, string b)
        {
            string aSorted = String.Concat(a.OrderBy(c => c)); //quicksort O(nlogn)
            string bSorted = String.Concat(b.OrderBy(c => c));

            return String.Equals(aSorted, bSorted);
        }

        public void Run()
        {
            string[][] pairs =
           {
                new string[]{"apple", "papel"},
                new string[]{"carrot", "tarroc"},
                new string[]{"hello", "llloh"}
            };

            foreach (var pair in pairs)
            {
                var word1 = pair[0];
                var word2 = pair[1];
                var result1 = IsPermutation1(word1, word2);
                var result2 = IsPermutation2(word1, word2);
                Console.WriteLine("{0}, {1}: {2} / {3}", word1, word2, result1, result2);
            }
        }
    }
}
