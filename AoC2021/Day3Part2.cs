namespace AoC2021;

internal class Day3Part2 : IChallenge
{
    public string Name => "day3_2";
    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        var remainingOxygenGeneratorRatingLines = new List<string>(lines);
        var currentIndex = 0;
        while (remainingOxygenGeneratorRatingLines.Count != 1)
        {
            remainingOxygenGeneratorRatingLines = FilterByIndex(remainingOxygenGeneratorRatingLines, currentIndex, (zero, one) => zero > one);
            currentIndex++;
        }

        var oxygenGeneratorRatingLine = remainingOxygenGeneratorRatingLines[0];
        var remainingCO2ScrubberRatingLines = new List<string>(lines);
        currentIndex = 0;
        while (remainingCO2ScrubberRatingLines.Count != 1)
        {
            remainingCO2ScrubberRatingLines = FilterByIndex(remainingCO2ScrubberRatingLines, currentIndex, (zero, one) => zero <= one);
            currentIndex++;
        }

        var co2ScrubberRatingLine = remainingCO2ScrubberRatingLines[0];
        return (Convert.ToInt32(oxygenGeneratorRatingLine, 2) * Convert.ToInt32(co2ScrubberRatingLine, 2)).ToString();
    }

    private List<string> FilterByIndex(List<string> remainingLines, int currentIndex, Func<int, int, bool> selectZeroList)
    {
        var has1 = new List<string>();
        var has0 = new List<string>();
        foreach (var line in remainingLines)
        {
            if (line[currentIndex] == '1')
            {
                has1.Add(line);
            }
            else
            {
                has0.Add(line);
            }
        }
        return selectZeroList(has0.Count, has1.Count) ? has0 : has1;
    }
}