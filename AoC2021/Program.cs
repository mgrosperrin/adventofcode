using AoC2021;

var solver = new Solver();
var challengeName = args[0];
var challenge = GetChallenge(challengeName);
var result = await solver.Solve(challenge, args.Skip(1));
Console.WriteLine(result);

static IChallenge GetChallenge(string challengeName)
{
    var challenges = typeof(Program).Assembly.GetTypes()
        .Where(t => t.IsAssignableTo(typeof(IChallenge)))
        .Where(t => !t.IsAbstract)
        .Select(t => ((IChallenge)Activator.CreateInstance(t)))
        .ToDictionary(challenge => challenge.Name, challenge => challenge);
    if(challenges.TryGetValue(challengeName, out var challenge))
    {
        return challenge!;
    }
    throw new Exception("challenge not found");
}
