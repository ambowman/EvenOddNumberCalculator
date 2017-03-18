using OddEvenCalculatorConsoleApp;
using Shouldly;
using Xunit;

namespace Tests
{
    public class Tests
    {
        PlayWithNumbers playWithNumbers = new PlayWithNumbers();
        [Fact]
        public void EvenTest()
        {
            int number = 8;
            var result = playWithNumbers.DetermineOddOrEven(number);
            result.ShouldBe(true);
        }
        [Fact]
        public void OddTest()
        {
            int number = 9;
            var result = playWithNumbers.DetermineOddOrEven(number);
            result.ShouldBe(false);
        }
    }
}

