using System;
using Xunit;

namespace Chap1_ArraysAndStrings
{
    public class Chap1_RotateMatrixTest
    {
        //matrix is null
        [Fact]
        public void MatrixIsNull()
        {
            Chap1_RotateMatrix matrix = new Chap1_RotateMatrix();
            Assert.Throws<ArgumentException>(() =>  matrix.CreateMatrix(null));
        }

        //Matrix is not squre
        [Fact]
        public void MatrixIsNotSquare()
        {
            Chap1_RotateMatrix matrix = new Chap1_RotateMatrix();
            Assert.Throws<ArgumentException>(() => matrix.CreateMatrix(1, 2, 3, 4, 5, 6));
        }
        //Matrix 1x1
        [Fact]
        public void OneByOneMatrix()
        {
            Chap1_RotateMatrix matrix = new Chap1_RotateMatrix();
            int[,] input = matrix.RotateMatrix(matrix.CreateMatrix(1));
            int[,] result = matrix.CreateMatrix(1);

            int[,] input2 = matrix.RotateMatrix_inPlace(matrix.CreateMatrix(1));

            Assert.Equal(result, input);

            Assert.Equal(result, input2);
        }
        //Matrix 2x2
        [Fact]
        public void TwoByTwoMatrix()
        {
            Chap1_RotateMatrix m = new Chap1_RotateMatrix();
            int[,] input = m.RotateMatrix(m.CreateMatrix(1,2,3,4));
            int[,] result = m.CreateMatrix(3,1,4,2);

            int[,] input2 = m.RotateMatrix_inPlace(m.CreateMatrix(1,2,3,4));

            Assert.Equal(result, input);
            Assert.Equal(result, input2);
        }
        //Matrix 3x3
        [Fact]
        public void ThreeByThreeMatrix()
        {
            Chap1_RotateMatrix m = new Chap1_RotateMatrix();
            int[,] input = m.RotateMatrix(m.CreateMatrix(1, 2, 3, 4,5,6,7,8,9));
            int[,] result = m.CreateMatrix(7,4,1,8,5,2,9,6,3);

            int[,] input2 = m.RotateMatrix_inPlace(m.CreateMatrix(1, 2, 3, 4,5,6,7,8,9));

            Assert.Equal(result, input);
            Assert.Equal(result, input2);

        }
    }
}
