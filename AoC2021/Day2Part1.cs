namespace AoC2021;
internal class Day2Part1: IChallenge
{
    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        int horizontalPosition = 0, depth = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            var parts = lines[i].Split(' ');
            switch (parts[0])
            {
                case "forward":
                    horizontalPosition += int.Parse(parts[1]);
                    break;
                case "up":
                    depth -= int.Parse(parts[1]);
                    break;
                case "down":
                    depth += int.Parse(parts[1]);
                    break;
                default:
                    break;
            }
        }
        return (horizontalPosition * depth).ToString();
    }
}