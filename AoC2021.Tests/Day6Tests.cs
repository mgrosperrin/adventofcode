using System.Linq;
using Xunit;

namespace AoC2021.Tests
{
    public class Day6Tests
    {
        private static readonly string[] lines = {
                            "3,4,3,1,2"
            };
        [Fact]
        public void ValidateDay6Part1()
        {
            var challenge = new Day6.Part1();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("5934", result);
        }
        [Fact]
        public void ValidateDay6Part2()
        {
            var challenge = new Day6.Part2();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("26984457539", result);
        }
    }
}