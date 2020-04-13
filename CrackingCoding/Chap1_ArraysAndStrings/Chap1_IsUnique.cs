using System;
using System.Collections.Generic;

namespace Chap1_ArraysAndStrings
{
    /*
      *Implement an Algorithm to determine if a string has all unique characters. What if you cannot use additional data structure?
      */
    public class Chap1_IsUnique
    {
        private bool isUnique_1(string input)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            char[] elems = input.ToCharArray();

            foreach (char elem in elems)
            {
                if (dic.ContainsKey(elem)) dic[elem]++;
                else dic.Add(elem, 1);
            }

            foreach (var elem in dic)
            {
                if (elem.Value > 1) return false;
            }

            return true;
        }

        private bool isUnique_2(string input)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (var s in input)
            {
                if (set.Contains(s)) return false;
                else set.Add(s);
            }
            return true;
        }

        private bool isUnique_3(string input) //without use additioanl data structure
        {
            int checker = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int val = input[i] - 'a';
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker |= (1 << val);
            }
            return true;
        }

        public void Run()
        {
            string[] inputs = { "abcde", "hello", "apple", "kite", "padle" };
            Console.WriteLine("1.1 Is Unique");
            foreach (string input in inputs)
            {
                Console.WriteLine($"Solution using Dictionary {input}: " + isUnique_1(input));
                Console.WriteLine($"Solution using HashSet {input}:" + isUnique_2(input));
                Console.WriteLine($"Solution without data structure {input}: " + isUnique_3(input));
                Console.WriteLine("\n");
            }
        }
    }
}
