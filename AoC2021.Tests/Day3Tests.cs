using System.Linq;
using Xunit;

namespace AoC2021.Tests
{
    public class Day3Tests
    {
        private static readonly string[] lines = new[] {
                            "00100",
                            "11110",
                            "10110",
                            "10111",
                            "10101",
                            "01111",
                            "00111",
                            "11100",
                            "10000",
                            "11001",
                            "00010",
                            "01010"
            };
        [Fact]
        public void ValidateDay3Part1()
        {
            var challenge = new Day3Part1();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("198", result);
        }
        //[Fact]
        //public void ValidateDay3Part2()
        //{
        //    var challenge = new Day3Part2();
        //    var result = challenge.Solve(lines, Enumerable.Empty<string>());

        //    Assert.Equal("900", result);
        //}
    }
}