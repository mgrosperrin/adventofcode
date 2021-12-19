namespace AoC2021;
internal class Day2Part2: IChallenge
{
    public string Name => "day2_2";
    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        int horizontalPosition = 0, depth = 0, aim = 0;
        for (var i = 0; i < lines.Length; i++)
        {
            var parts = lines[i].Split(' ');
            var value = int.Parse(parts[1]);
            switch (parts[0])
            {
                case "down":
                    aim += value;
                    break;
                case "up":
                    aim -= value;
                    break;
                case "forward":
                    horizontalPosition += value;
                    depth += aim * value;
                    break;
                default:
                    break;
            }
        }
        return (horizontalPosition * depth).ToString();
    }
}