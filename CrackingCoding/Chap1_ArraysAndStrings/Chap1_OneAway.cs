using System;
using System.Collections.Generic;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_OneAway
    {
        public bool isOneAway(string input, string output)
        {
            if (String.Equals(input, output)) return true;

            if (String.IsNullOrEmpty(input)|| String.IsNullOrEmpty(output))
            {
                throw new ArgumentException("Input must not be null/empty");
            }

            int difLength = Math.Abs(input.Length - output.Length);

            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach(var ch in input)
            {
                if (dic.ContainsKey(ch)) dic[ch]++;
                else
                {
                    dic.Add(ch, 1);
                }

            }

            if (difLength == 1 || difLength == 0 ) //remove, insert and replace
            {
                int numDifference = 0;

                foreach (char ch in output)
                {
                    if (dic.ContainsKey(ch)) dic[ch]--;
                    else numDifference++;
                }
                if(difLength == 1) 
                {
                    foreach (var val in dic.Values) //insert
                    {
                        if (val > 0) numDifference++;
                    }
                }                

                return numDifference > 1 ? false : true;
            }

            else return false;
              
        }
        
    }
}
