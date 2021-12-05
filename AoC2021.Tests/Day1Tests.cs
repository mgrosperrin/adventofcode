using System.Linq;
using Xunit;

namespace AoC2021.Tests
{
    public class Day1Tests
    {
        [Fact]
        public void ValidateDay1Part1()
        {
            var lines = new[] {
                            "199",
                            "200",
                            "208",
                            "210",
                            "200",
                            "207",
                            "240",
                            "269",
                            "260",
                            "263"};
            var challenge = new Day1.Part1();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("7", result);
        }
        [Fact]
        public void ValidateDay1Part2()
        {
            var lines = new[] {
                            "199",
                            "200",
                            "208",
                            "210",
                            "200",
                            "207",
                            "240",
                            "269",
                            "260",
                            "263"};
            var challenge = new Day1.Part2();
            var result = challenge.Solve(lines, Enumerable.Empty<string>());

            Assert.Equal("5", result);
        }
    }
}