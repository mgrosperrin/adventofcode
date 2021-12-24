namespace AoC2021;

internal abstract partial class Day7 : IChallenge
{
    public abstract string Name { get; }
    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        var line = lines[0];
        var initialPositions = line.Split(',')
            .Select(int.Parse).ToList();
        var maxPosition = initialPositions.Max();

        var minimumFuel =
            Enumerable.Range(0, maxPosition)
            .Select(targetPostion => initialPositions.Sum(currentPosition => ComputeFuelConsumption(currentPosition, targetPostion)))
            .Min();

        return minimumFuel.ToString();
    }
    public abstract int ComputeFuelConsumption(int currentPosition, int targetPostion);
}