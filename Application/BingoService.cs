// Application Layer: Use cases and services
using VibeBingo.Domain;

namespace VibeBingo.Application;

public class BingoService
{
    private readonly BingoRound _round = new();
    private readonly List<BingoBall> _allBalls;
    private readonly Random _random = new();

    public BingoService()
    {
        _allBalls = new List<BingoBall>();
        foreach (BingoLetter letter in Enum.GetValues(typeof(BingoLetter)))
        {
            int start = letter switch
            {
                BingoLetter.B => 1,
                BingoLetter.I => 16,
                BingoLetter.N => 31,
                BingoLetter.G => 46,
                BingoLetter.O => 61,
                _ => 1
            };
            int end = start + 14;
            for (int n = start; n <= end; n++)
                _allBalls.Add(new BingoBall(letter, n));
        }
    }

    public IReadOnlyCollection<BingoBall> AllBalls => _allBalls;
    public IReadOnlyCollection<string> CalledBalls => _round.CalledBalls;

    public BingoBall? CallNextBall()
    {
        var available = _allBalls.Where(b => !_round.IsCalled(b)).ToList();
        if (!available.Any()) return null;
        var ball = available[_random.Next(available.Count)];
        _round.CallBall(ball);
        return ball;
    }

    public void StartNewRound() => _round.Reset();
    public bool IsCalled(BingoBall ball) => _round.IsCalled(ball);
}
