using System;
using Xunit;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_OneAwayTest
    {
        private readonly Chap1_OneAway oneWay = new Chap1_OneAway();

        [Fact]
        public void ShouldReturnTrueWithNoChanges()
        {
            //Chap1_OneAway oneWay = new Chap1_OneAway();

            bool result = oneWay.isOneAway("pales", "pales");

            Assert.True(result);
        }

        [Fact]
        public void ShouldThrowExceptionWithNullOrEmptyInput()
        {
            //Chap1_OneAway oneWay = new Chap1_OneAway();

            Assert.Throws<ArgumentException>(() => oneWay.isOneAway(string.Empty, null));
        }

        [Fact]
        public void ShouldReturnFalseWithMoreThan1LengthDifference()
        {
            bool result = oneWay.isOneAway("pale", "abcdd");
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnTrueWithRemoveAChar()
        {
            bool result = oneWay.isOneAway("pale", "pal");

            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnTrueWithOneInsert()
        {
            bool result = oneWay.isOneAway("pale", "pales");
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseWithTwoChanges()
        {
            bool result1 = oneWay.isOneAway("pale", "paleab");
            bool result2 = oneWay.isOneAway("pale", "pa");

            Assert.False(result1);
            Assert.False(result2);
        }

        [Fact]
        public void ShouldReturnTruewithOneReplace()
        {
            bool result = oneWay.isOneAway("pale", "bale");
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseWithMultipleChages()
        {
            bool result = oneWay.isOneAway("pale", "bake");
            Assert.False(result);
        }
    }
}
