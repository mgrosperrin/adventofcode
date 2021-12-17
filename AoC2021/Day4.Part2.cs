namespace AoC2021;

internal abstract partial class Day4
{
    internal class Part2 : Day4
    {
        protected override string GetFinalScores(List<string> scores)
        {
            return scores.Last();
        }
    }
}