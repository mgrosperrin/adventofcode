namespace AoC2021
{
    internal class Solver
    {
        public async Task<string> Solve(IChallenge challenge, IEnumerable<string> args)
        {
            if (!args.Any())
            {
                throw new ArgumentException("missing input file");
            }
            var fileContent = await File.ReadAllLinesAsync(args.First());
            return challenge.Solve(fileContent, args.Skip(1));
        }
    }
}
