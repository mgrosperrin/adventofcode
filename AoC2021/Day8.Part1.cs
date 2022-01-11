namespace AoC2021;

internal partial class Day8
{
    internal class Part1 : Day8
    {
        public override string Name => "day8_1";

        public override string Solve(string[] lines, IEnumerable<string> remainingArgs)
        {
            var numbers = lines.Select(line => line.Split('|')[1]);
            var distinctNumbers = numbers.SelectMany(number => number.Split(' '));
            var easyNumbers = distinctNumbers.Where(number => IsOne(number) || IsFour(number) || IsSeven(number) || IsEight(number));

            return easyNumbers.Count().ToString();
        }
    }
}