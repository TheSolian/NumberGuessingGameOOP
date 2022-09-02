namespace NumberGuessingGameOOP;

internal class Program
{
    public static void Main(string[] args)
    {
        NumberGuesser game = new NumberGuesser("Number Guesser");
        game.StartGame();
    }
}