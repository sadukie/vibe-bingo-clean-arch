namespace VibeBingo.Domain;

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
