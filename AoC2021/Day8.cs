namespace AoC2021;

internal abstract partial class Day8 : IChallenge
{
    public abstract string Name { get; }

    public abstract string Solve(string[] lines, IEnumerable<string> remainingArgs);
    /*
     * 2 => 1
     * 3 => 7
     * 4 => 4
     * 5 => 2, 3, 5
     * 6 => 0, 6, 9
     * 7 => 8
     */

    private static bool IsZero(string value, string one, string four)
    {
        return value.Length == 6 && ContainsAllSegments(value, one) && !ContainsAllSegments(value, four);
    }
    private static bool IsOne(string value)
    {
        return value.Length == 2;
    }
    private static bool IsTwo(string value, string nine)
    {
        return value.Length == 5 && !ContainsAllSegments(nine, value);
    }
    private static bool IsThree(string value, string nine, string six)
    {
        return value.Length == 5 && ContainsAllSegments(nine, value) && !ContainsAllSegments(six, value);
    }
    private static bool IsFour(string value)
    {
        return value.Length == 4;
    }
    private static bool IsFive(string value, string six)
    {
        return value.Length == 5 && ContainsAllSegments(six, value);
    }
    private static bool IsSix(string value, string one)
    {
        return value.Length == 6 && !ContainsAllSegments(value, one);
    }
    private static bool IsSeven(string value)
    {
        return value.Length == 3;
    }
    private static bool IsEight(string value)
    {
        return value.Length == 7;
    }
    private static bool IsNine(string value, string four, string seven)
    {
        if (value.Length != 6)
        {
            return false;
        }

        return ContainsAllSegments(value, four) && ContainsAllSegments(value, seven);
    }

    private static bool MatchAllSegments(string value, string number)
    {
        return ContainsAllSegments(value, number) && ContainsAllSegments(number, value);
    }
    private static bool ContainsAllSegments(string value, string number)
    {
        foreach (var numberCharacter in number)
        {
            if (!value.Contains(numberCharacter))
            {
                return false;
            }
        }
        return true;
    }
}