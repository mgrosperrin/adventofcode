using System.Linq;
using Xunit;

namespace AoC2021.Tests
{
    public class Day2Tests
    {
        private static readonly string[] lines = {
                            "forward 5",
                            "down 5",
                            "forward 8",
                            "up 3",
                            "down 8",
                            "forward 2"
            };
        [Fact]
        public void ValidateDay2Part1()
        {
            var challenge = new Day2Part1();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("150", result);
        }
        [Fact]
        public void ValidateDay2Part2()
        {
            var challenge = new Day2Part2();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("900", result);
        }
    }
}