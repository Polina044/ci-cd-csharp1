using Xunit;
using CalculatorApp1;
namespace CalculatorApp1.Tests
{
    public class Calculator1Tests
    {
        [Fact]
        public void Add_returnCorrectSum()
        {
            Calculator1 calc = new Calculator1();
            int result = calc.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}