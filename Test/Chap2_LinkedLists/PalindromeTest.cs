using System;
using Xunit;
using Helper;

namespace Chap2_LinkedLists
{
    public class PalindromeTest
    {
       [Fact]
       public void BasicTest()
        {
            LinkedListHelper<int> helper = new LinkedListHelper<int>();
            var inputHead = helper.CreateLinkedList_Node(0, 1, 2, 1, 0);

            Palindrome p = new Palindrome();
            var result = p.isPalindrome(inputHead);

            var inputHead2 = helper.CreateLinkedList_Node(0, 1, 2, 3, 4);
            var result2 = p.isPalindrome(inputHead2);

            Assert.True(result);
            Assert.False(result2);
        }
    }
}
