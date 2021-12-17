using AoC2021;

var solver = new Solver();
var challengeName = args[0];
var challenge = GetChallenge(challengeName);
var result = await solver.Solve(challenge, args.Skip(1));
Console.WriteLine(result);

static IChallenge GetChallenge(string challengeName)
{
    return challengeName switch
    {
        "day1_1" => new Day1.Part1(),
        "day1_2" => new Day1.Part2(),
        "day2_1" => new Day2Part1(),
        "day2_2" => new Day2Part2(),
        "day3_1" => new Day3Part1(),
        "day3_2" => new Day3Part2(),
        "day4_1" => new Day4.Part1(),
        "day4_2" => new Day4.Part2(),
        _ => throw new ArgumentOutOfRangeException(nameof(challengeName))
    };
}
