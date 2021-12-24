namespace AoC2021;

internal abstract partial class Day7 : IChallenge
{
    internal class Part2 : Day7
    {
        public override string Name => "day7_2";

        public override int ComputeFuelConsumption(int currentPosition, int targetPostion)
        {
            var distance = Math.Abs(currentPosition - targetPostion);
            return distance * (distance + 1) / 2;
        }
    }
}