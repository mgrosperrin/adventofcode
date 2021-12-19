namespace AoC2021;

internal abstract partial class Day4
{
    internal class Part2 : Day4
    {
        public override string Name => "day4_2";
        protected override string GetFinalScores(List<string> scores)
        {
            return scores.Last();
        }
    }
}