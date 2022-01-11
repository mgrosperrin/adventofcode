namespace AoC2021;

internal partial class Day8
{
    internal class Part2 : Day8
    {
        public override string Name => "day8_2";

        public override string Solve(string[] lines, IEnumerable<string> remainingArgs)
        {
            var numbers = new List<int>();
            foreach (var line in lines)
            {
                var patterns = line.Split('|');
                var signalPattern = AnalyzeSignalPattern(patterns[0]);
                var outputValue = ComputeOutput(signalPattern, patterns[1]);
                numbers.Add(outputValue);
            }

            return numbers.Sum().ToString();
        }

        private int ComputeOutput(
            (string zero, string one, string two, string three, string four, string five, string six, string seven,
                string eight, string nine) signalPattern, string pattern)
        {
            var numbers = pattern.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var result = 0;
            for (var digitIndex = 0; digitIndex < numbers.Length; digitIndex++)
            {
                var digitValue = ComputeDigit(signalPattern, numbers[digitIndex]);
                result += digitValue * (int)Math.Pow(10, numbers.Length - digitIndex - 1);
            }

            return result;
        }

        private int ComputeDigit(
            (string zero, string one, string two, string three, string four, string five, string six, string seven,
                string eight, string nine) signalPattern, string digit)
        {
            if (MatchAllSegments(digit, signalPattern.zero))
            {
                return 0;
            }

            if (MatchAllSegments(digit, signalPattern.one))
            {
                return 1;
            }

            if (MatchAllSegments(digit, signalPattern.two))
            {
                return 2;
            }

            if (MatchAllSegments(digit, signalPattern.three))
            {
                return 3;
            }

            if (MatchAllSegments(digit, signalPattern.four))
            {
                return 4;
            }

            if (MatchAllSegments(digit, signalPattern.five))
            {
                return 5;
            }

            if (MatchAllSegments(digit, signalPattern.six))
            {
                return 6;
            }

            if (MatchAllSegments(digit, signalPattern.seven))
            {
                return 7;
            }

            if (MatchAllSegments(digit, signalPattern.eight))
            {
                return 8;
            }

            if (MatchAllSegments(digit, signalPattern.nine))
            {
                return 9;
            }

            throw new ArgumentOutOfRangeException(nameof(digit));
        }

        private static (string zero, string one, string two, string three, string four, string five, string six, string
            seven, string eight, string nine) AnalyzeSignalPattern(string signalPattern)
        {
            var numbers = signalPattern.Split(' ');

            var one = numbers.Single(IsOne);
            var seven = numbers.Single(IsSeven);
            var four = numbers.Single(IsFour);
            var eight = numbers.Single(IsEight);
            var zero = numbers.Single(number => IsZero(number, one, four));
            var nine = numbers.Single(number => IsNine(number, four, seven));
            var six = numbers.Single(number => IsSix(number, one));
            var two = numbers.Single(number => IsTwo(number, nine));
            var three = numbers.Single(number => IsThree(number, nine, six));
            var five = numbers.Single(number => IsFive(number, six));
            return (zero, one, two, three, four, five, six, seven, eight, nine);
        }
    }
}