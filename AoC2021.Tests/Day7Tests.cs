using System.Linq;
using Xunit;

namespace AoC2021.Tests
{
    public class Day7Tests
    {
        private static readonly string[] lines = {
                            "16,1,2,0,4,2,7,1,2,14"
            };
        [Fact]
        public void ValidateDay7Part1()
        {
            var challenge = new Day7.Part1();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("37", result);
        }
        [Fact]
        public void ValidateDay7Part2()
        {
            var challenge = new Day7.Part2();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("168", result);
        }
    }
}