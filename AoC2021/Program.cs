using AoC2021;

var solver = new Solver();
var challengeName = args[0];
var challenge = GetChallenge(challengeName);


var result = await solver.Solve(challenge, args.Skip(1));
Console.WriteLine(result);

static IChallenge GetChallenge(string challengeName)
{
    throw new ArgumentOutOfRangeException(nameof(challengeName));
}
