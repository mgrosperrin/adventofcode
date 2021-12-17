namespace AoC2021;

internal class Day3Part1 : IChallenge
{
    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        var numberOfLines = lines.Length;
        var length = lines[0].Length;
        var numberOfOne = new int[length];
        for (var currentLine = 0; currentLine < numberOfLines; currentLine++)
        {
            for (var currentRow = 0; currentRow < length; currentRow++)
            {
                if (lines[currentLine][currentRow] == '1')
                {
                    numberOfOne[currentRow]++;
                }
            }
        }
        int gamma = 0, epsilon = 0;
        for (var currentRow = 0; currentRow < length; currentRow++)
        {
            if(numberOfOne[currentRow] > numberOfLines / 2)
            {
                gamma++;
            }
            else
            {
                epsilon++;
            }
            gamma <<= 1;
            epsilon <<= 1;
        }
        return ((gamma>>1) * (epsilon>>1)).ToString();
    }
}