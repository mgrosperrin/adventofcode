using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace AoC2021;

internal abstract partial class Day5 : IChallenge
{
    public abstract string Name { get; }

    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        var segments = ParseLines(lines).ToList();
        var horizontalAndVerticalsSegments = segments.Where(FilterSegment);
        var allPoints = GenerateAllPoints(horizontalAndVerticalsSegments).ToList();
        var diagram = allPoints.GroupBy(point => point).ToList();
        var dangerousPoints = diagram.Where(group => group.Count() >= 2);

        return dangerousPoints.Count().ToString();
    }
    protected abstract bool FilterSegment((Point Start, Point End) segment);

    private IEnumerable<Point> GenerateAllPoints(IEnumerable<(Point Start, Point End)> horizontalAndVerticalsSegments)
    {
        foreach (var segment in horizontalAndVerticalsSegments)
        {
            var xIncrement = Math.Sign(segment.End.X - segment.Start.X);
            var yIncrement = Math.Sign(segment.End.Y - segment.Start.Y);
            var positionX = segment.Start.X;
            var positionY = segment.Start.Y;
            do {
                yield return new Point(positionX, positionY);
                positionX += xIncrement;
                positionY += yIncrement;
            }
            while ((xIncrement == 0 || positionX != segment.End.X) && (yIncrement == 0 || positionY != segment.End.Y));
            yield return new Point(positionX, positionY);
        }
    }

    private IEnumerable<(Point Start, Point End)> ParseLines(string[] lines)
    {
        foreach (var line in lines)
        {
            var points = line.Split("->", StringSplitOptions.TrimEntries);
            var startCoordinates = points[0].Split(',');
            var start = new Point(int.Parse(startCoordinates[0]), int.Parse(startCoordinates[1]));
            var endCoordinates = points[1].Split(',');
            var end = new Point(int.Parse(endCoordinates[0]), int.Parse(endCoordinates[1]));
            yield return (start, end);
        }
    }
}