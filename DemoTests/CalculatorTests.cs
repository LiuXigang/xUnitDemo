using Xunit;
using xUnitDemo;

namespace DemoTests
{
    public class CalculatorTests
    {
        [Fact]
        public void ShouldAdd()
        {
            //Arrange (System Under Test)
            var sut = new Calculator();
            //Art
            var result = sut.Add(1, 2);
            //Assert
            Assert.Equal(3, result);
        }
    }
}
