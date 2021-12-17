namespace AoC2021;

internal abstract partial class Day4 : IChallenge
{
    public string Solve(string[] lines, IEnumerable<string> remainingArgs)
    {
        var numbers = lines[0].Split(',', StringSplitOptions.RemoveEmptyEntries)
            .Select(rawNumber => int.Parse(rawNumber));

        var boards = ParseBoards(lines).ToList();
        var scores = new List<string>();
        foreach (var number in numbers)
        {
            var boardsToRemove = new List<Board>();
            foreach (var board in boards)
            {
                var result = board.SetNumber(number);
                if (result != 0)
                {
                    scores.Add(((result - number) * number).ToString());
                    boardsToRemove.Add(board);
                }
            }
            boardsToRemove.ForEach(board => boards.Remove(board));
        }

        return GetFinalScores(scores);
    }

    protected abstract string GetFinalScores(List<string> scores);

    private IEnumerable<Board> ParseBoards(string[] lines)
    {
        for (var boardIndex = 0; boardIndex < (lines.Length - 1) / 6; boardIndex++)
        {
            yield return new Board(lines.Skip(2 + boardIndex * 6).Take(5));
        }
    }

    internal class Board
    {
        private readonly List<Line> _possibleLines = new();
        private int _currentScore;

        public Board(IEnumerable<string> lines)
        {
            var numberLines = lines.Select(line =>
                    line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList())
                .ToList();

            foreach (var numberLine in numberLines)
            {
                _possibleLines.Add(new(numberLine));
            }

            for (var columnIndex = 0; columnIndex < numberLines[0].Count; columnIndex++)
            {
                _possibleLines.Add(new(numberLines.Select(line => line.Skip(columnIndex).First()).ToList()));
            }

            _currentScore = numberLines.Select(line => line.Sum()).Sum();
        }

        public int SetNumber(int number)
        {
            var hasBeenMarked = false;
            foreach (var possibleLine in _possibleLines)
            {
                var result = possibleLine.SetNumber(number);
                switch (result)
                {
                    case Mark.None:
                        continue;
                    case Mark.Partial:
                        hasBeenMarked = true;
                        break;
                    case Mark.All:
                        return _currentScore;
                }
            }

            if (hasBeenMarked)
            {
                _currentScore -= number;
            }

            return 0;
        }
    }

    private class Line
    {
        private readonly HashSet<int> _numbers;
        private int _remainingNumber;

        public Line(IEnumerable<int> numbers)
        {
            _numbers = new(numbers);
            _remainingNumber = _numbers.Count;
        }

        public Mark SetNumber(int number)
        {
            if (_numbers.Contains(number))
            {
                _remainingNumber--;
                if (_remainingNumber == 0)
                {
                    return Mark.All;
                }

                return Mark.Partial;
            }

            return Mark.None;
        }
    }

    private enum Mark
    {
        None,
        Partial,
        All
    }
}