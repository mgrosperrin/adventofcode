using System.Drawing;

namespace AoC2021;

internal abstract partial class Day5
{
    internal class Part2 : Day5
    {
        public override string Name => "day5_2";

        protected override bool FilterSegment((Point Start, Point End) segment)
        {
            return true;
        }
    }
}