using System.Numerics;

namespace AoC2021;

internal abstract partial class Day6 : IChallenge
{
    public abstract string Name { get; }
    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        var line = lines[0];
        var integers = line.Split(',')
            .Select(int.Parse).ToList();
        var lanternfishesByDays = new Dictionary<int, BigInteger>
        {
            {0, 0},
            {1, 0},
            {2, 0},
            {3, 0},
            {4, 0},
            {5, 0},
            {6, 0},
            {7, 0},
            {8, 0}
        };
        foreach (var integer in integers.GroupBy(_ => _))
        {
            lanternfishesByDays[integer.Key] = integer.Count();
        }
        for (int currentDay = 0; currentDay < NbOfDays; currentDay++)
        {
            var newLanterfishes = lanternfishesByDays[0];
            lanternfishesByDays[0] = lanternfishesByDays[1];
            lanternfishesByDays[1] = lanternfishesByDays[2];
            lanternfishesByDays[2] = lanternfishesByDays[3];
            lanternfishesByDays[3] = lanternfishesByDays[4];
            lanternfishesByDays[4] = lanternfishesByDays[5];
            lanternfishesByDays[5] = lanternfishesByDays[6];
            lanternfishesByDays[6] = lanternfishesByDays[7] + newLanterfishes;
            lanternfishesByDays[7] = lanternfishesByDays[8];
            lanternfishesByDays[8] = newLanterfishes;
        }
        return lanternfishesByDays.Values
            .Aggregate(new BigInteger(0),
                    (accumulate, current) => accumulate+current)
            .ToString();
    }
    protected abstract int NbOfDays { get; }
}