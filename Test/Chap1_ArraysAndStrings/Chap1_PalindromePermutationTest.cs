using System;
using Xunit;

namespace Chap1_ArraysAndStrings
{

    public class Chap1_PalindromePermutationTest
    {
        [Fact]
        public void ShouldReturn0()
        {
            //arrange
            Chap1_PalindromePermutation p = new Chap1_PalindromePermutation();

            //act
            int result = p.Run();

            //Assert
            Assert.Equal(0, result);
        }
    }
}
