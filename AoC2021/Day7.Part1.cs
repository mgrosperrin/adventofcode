namespace AoC2021;

internal abstract partial class Day7 : IChallenge
{
    internal class Part1 : Day7
    {
        public override string Name => "day7_1";

        public override int ComputeFuelConsumption(int currentPosition, int targetPostion)
        {
            return Math.Abs(currentPosition - targetPostion);
        }
    }
}