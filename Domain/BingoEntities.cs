// Domain Layer: Core BINGO logic and entities
namespace VibeBingo.Domain;

public enum BingoLetter { B, I, N, G, O }

public class BingoBall
{
    public BingoLetter Letter { get; }
    public int Number { get; }
    public string Display => $"{Letter}{Number}";

    public BingoBall(BingoLetter letter, int number)
    {
        Letter = letter;
        Number = number;
    }
}

public class BingoRound
{
    private readonly HashSet<string> _calledBalls = new();
    public IReadOnlyCollection<string> CalledBalls => _calledBalls;

    public void CallBall(BingoBall ball)
    {
        _calledBalls.Add(ball.Display);
    }

    public bool IsCalled(BingoBall ball) => _calledBalls.Contains(ball.Display);
    public void Reset() => _calledBalls.Clear();
}
