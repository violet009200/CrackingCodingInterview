using System;
using Xunit;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_StringCompressionTest
    {
        private readonly Chap1_StringCompression sc = new Chap1_StringCompression();

        [Fact]
        public void CheckInputIsNull()
        {
            Assert.Throws<ArgumentException>(() => sc.stringCompression(null));
        }

        [Fact]
        public void CheckInputIsEmpty()
        {
            Assert.Throws<ArgumentException>(() => sc.stringCompression(String.Empty));
        }

        [Fact]
        public void CheckWithInput()
        {
            string result1 = sc.stringCompression("aabccccc");
            string result2 = sc.stringCompression("aabcccccaaa");

            Assert.Equal("a2b1c5", result1);
            Assert.Equal("a2b1c5a3", result2);
        }

        [Fact]
        public void ShouldReturnInputString()
        {
            string result1 = sc.stringCompression("a");
            Assert.Equal("a", result1);
        }
    }
}
