using System.Drawing;

namespace AoC2021;

internal abstract partial class Day5
{
    internal class Part1 : Day5
    {
        public override string Name => "day5_1";

        protected override bool FilterSegment((Point Start, Point End) segment)
        {
            return segment.Start.X == segment.End.X || segment.Start.Y == segment.End.Y;
        }
    }
}