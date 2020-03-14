using System;
using Xunit;

namespace CICDTesting.Unit.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            int a = 10;

            //Act

            //Assert
            Assert.Equal(10, a);
        }

        [Fact]
        public void Test2()
        {
            int b = 106;

            Assert.Equal(10, b);
        }
    }
}
