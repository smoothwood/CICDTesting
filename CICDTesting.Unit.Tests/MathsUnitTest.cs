using System;
using Xunit;

namespace CICDTesting.Unit.Tests
{
    public class MathsUnitTest
    {
  
        [Theory]
        [InlineData(1,2,2)]
        [InlineData(2,2,4)]

        public void MultiplyTest(int x, int y, int expected)
        {
            //Arrange
            var maths = new Maths();

            //Act
            int actual = maths.Multiply(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(5,0, null)]
        public void DivideTest(int x, int y, int? expected)
        {
            //Arrange
            var maths = new Maths();

            //Act
            int? actual = maths.Divide(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
