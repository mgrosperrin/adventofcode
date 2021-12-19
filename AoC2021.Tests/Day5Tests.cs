using System.Linq;
using Xunit;

namespace AoC2021.Tests
{
    public class Day5Tests
    {
        private static readonly string[] lines = {
                            "0,9 -> 5,9",
                            "8,0 -> 0,8",
                            "9,4 -> 3,4",
                            "2,2 -> 2,1",
                            "7,0 -> 7,4",
                            "6,4 -> 2,0",
                            "0,9 -> 2,9",
                            "3,4 -> 1,4",
                            "0,0 -> 8,8",
                            "5,5 -> 8,2"
            };
        [Fact]
        public void ValidateDay5Part1()
        {
            var challenge = new Day5.Part1();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("5", result);
        }
        [Fact]
        public void ValidateDay5Part2()
        {
            var challenge = new Day5.Part2();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("12", result);
        }
    }
}