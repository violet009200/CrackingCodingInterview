using System;
using Xunit;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_ZeroMatrixTest
    {
        //invalid input
        [Fact]
        public void MatrixIsNull()
        {
            Chap1_ZeroMatrix m = new Chap1_ZeroMatrix();
            Assert.Throws<ArgumentException>(() => m.CreateMatrix(0 ,0, null));
        }

        //matrix has one elem
        [Fact]
        public void OneElement()
        {
            Chap1_ZeroMatrix m = new Chap1_ZeroMatrix();
            int[,] expect = m.CreateMatrix(1,1,1);
            int[,] result = m.ZeroMatrix(expect);

            Assert.Equal(expect, result);
        }

        //matrix without 0
        [Fact]
        public void WithoOutZero()
        {
            Chap1_ZeroMatrix m = new Chap1_ZeroMatrix();
            int[,] expect = m.CreateMatrix(2, 2, 1, 2, 3, 4);
            int[,] result = m.ZeroMatrix(expect);

            Assert.Equal(expect, result);
        }

        //Matrix with 0
        [Fact]
        public void WithZeros()
        {
            Chap1_ZeroMatrix m = new Chap1_ZeroMatrix();
            int[,] input = m.CreateMatrix(3, 3, 1, 2, 0, 3, 0, 4, 5, 6, 7);
            int[,] result = m.ZeroMatrix(input);
            int[,] expect = m.CreateMatrix(3, 3, 0, 0, 0, 0, 0, 0, 5, 0, 0);

            int[,] input1 = m.CreateMatrix(3, 3, 1,2,3,4,0,5,6,7,8);
            int[,] result1 = m.ZeroMatrix(input1);
            int[,] expect1 = m.CreateMatrix(3, 3, 1,0,3,0,0,0,6,0,8);

            Assert.Equal(expect, result);
            Assert.Equal(expect1, result1);

        }

    }
}
