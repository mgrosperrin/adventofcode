namespace AoC2021
{
    public interface IChallenge
    {
        string Name { get; }
        string Solve(string[] lines, IEnumerable<string> remainingArgs);
    }
}
