using System;


namespace Chap1_ArraysAndStrings
{
    public class Chap1_StringRotation
    {
        public bool isSubstring(string input, string sub)
        {
            return input.IndexOf(sub) >= 0 ? true : false;
        }

        public bool IsRotation(string input, string compare)
        {
            if (input.Length != compare.Length) return false;

            var result = compare + compare;

            return isSubstring(result, input);
        }
    }
}
