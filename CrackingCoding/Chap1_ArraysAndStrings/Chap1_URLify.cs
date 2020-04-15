using System;
namespace Chap1_ArraysAndStrings
{
    public class Chap1_URLify
    {
        /*
         * using String
         * string is immutable, we used string directly the function would have to return a new copy of the string
         */
        private string Urlify1(string input, int trueLength)
        {
            string replaceString = "%20";
            string newString = input.Substring(0, trueLength);
            input = newString.Replace(" ", replaceString);

            return input;
        }

        //using char array
        private string Urlify2(string input, int trueLength)
        {
            char[] inputChar = input.ToCharArray();
           
            var numSpace = FindSpace(inputChar, trueLength);
            int newIndex = trueLength-1 + numSpace * 2;
            char[] newChar = new char[newIndex+1];

            for(int i = 0; i<inputChar.Length; i++)
            {
                newChar[i] = inputChar[i];
            }
            
            // copying the characters backwards and inserting %20
            for (int oldIndex = trueLength-1; oldIndex >= 0; oldIndex--)
            {
                if (newChar[oldIndex] == ' ')
                {
                    newChar[newIndex] = '0';
                    newChar[newIndex - 1] = '2';
                    newChar[newIndex - 2] = '%';
                    newIndex -= 3;
                }
                else
                {
                    newChar[newIndex] = newChar[oldIndex];
                    newIndex -= 1;
                }
            }

            return new string(newChar);
        }

        //find number of space
        private int FindSpace(char[] input, int len)
        {
            int numSpace = 0;
            for(int i = 0; i<len; i++)
            {
                if (input[i] == ' ') numSpace++;
            }

            return numSpace;
        }

        public void Run()
        {
            Console.WriteLine("1.3 URLify");

            string input1 = "abc d e f";
            string input2 = "Mr John Smith   ";

            string result1 = Urlify1(input1, 9);
            string result2 = Urlify1(input2, 13);

            Console.WriteLine("Using char array");
            Console.WriteLine("{0} -> {1}", input1, result1);
            Console.WriteLine("{0} -> {1}", input2, result2);

            Console.WriteLine("Using char array");
            string result3 = Urlify2(input1, 9);
            string result4 = Urlify2(input2, 13);

            Console.WriteLine("{0} -> {1}", input1, result3);
            Console.WriteLine("{0} -> {1}", input2, result4);
        }
    }
}
