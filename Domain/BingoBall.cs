namespace VibeBingo.Domain;

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
