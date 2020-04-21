using System;
using System.Collections.Generic;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_StringCompression
    {
        /*
         * Space : O(n)
         * time:O(n)
         */         
        public string stringCompression(string input)
        {
            if(String.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input is null or Empty");
            }

            System.Text.StringBuilder finalString = new System.Text.StringBuilder();

            int countChar = 0;

            for(int i= 0; i< input.Length; i++)
            {
                countChar++;

                if(i+1 >= input.Length || input[i] != input[i + 1])
                {
                    finalString.Append(input[i]);
                    finalString.Append(countChar);
                    countChar = 0;
                }
            }

            return input.Length > finalString.Length ? finalString.ToString() : input;
        }
    }
}
