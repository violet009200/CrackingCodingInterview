using System;
using Xunit;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_StringRotationTest
    {
        //Test isSubstring
        [Fact]
        public void CheckIsSubstring()
        {
            Chap1_StringRotation s = new Chap1_StringRotation();

            Assert.True(s.isSubstring("abcd", "bc"));
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            Chap1_StringRotation s = new Chap1_StringRotation();
            bool result = s.IsRotation("water", "waert");
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrue()
        {
            Chap1_StringRotation s = new Chap1_StringRotation();
            bool result = s.IsRotation("waterbottle", "erbottlewat");
            Assert.True(result);
        }
    }
}
