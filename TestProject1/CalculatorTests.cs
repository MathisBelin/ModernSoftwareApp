using ModernSoftwareApp;

namespace TestProject1
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calc = new Calculator();
            Assert.Equal(5, calc.Add(2, 3));
        }
    }
}