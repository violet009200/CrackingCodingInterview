using System;
using Xunit;

namespace Chap1_ArraysAndStrings
{

    public class Chap1_PalindromePermutationTest
    {
        [Fact]
        public void PalindromePermutationTest()
        {
            //arrange
            Chap1_PalindromePermutation p = new Chap1_PalindromePermutation();

            //act
            bool result1 = p.isPalindromePermutation("tactcoa");
            bool result2 = p.isPalindromePermutation("asda");
            
            //Assert
            Assert.True(result1); //taco cat
            Assert.False(result2);
           
        }

        [Fact]
        public void CheckInputIsNullOrEmpty()
        {
            Chap1_PalindromePermutation p = new Chap1_PalindromePermutation();

            bool result = p.isPalindromePermutation(null);
            Assert.False(result);

            result = p.isPalindromePermutation(string.Empty);
            Assert.False(result);
        }
    }
}

