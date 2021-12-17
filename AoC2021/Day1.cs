namespace AoC2021;

internal abstract partial class Day1 : IChallenge
{
    public string Solve(string[] lines, IEnumerable<string> _)
    {
        var step = GetStep();
        var numberOfIncrease = 0;
        var parsedLines = lines.Select(int.Parse).ToArray();
        for (var i = step; i < lines.Length; i++)
        {
            if (parsedLines[i] > parsedLines[i - step])
            {
                numberOfIncrease++;
            }
        }
        return numberOfIncrease.ToString();
    }
    protected abstract int GetStep();
}
