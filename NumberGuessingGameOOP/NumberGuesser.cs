namespace NumberGuessingGameOOP;

public class NumberGuesser
{
    private int _secretNumber;
    private int _guess;
    private int _numberOfGuesses = 0;
    private readonly string _startScreenText;

    public NumberGuesser(string startScreenText)
    {
        _startScreenText = startScreenText;
    }

    public void StartGame()
    {
        Console.Clear();
        GenerateRandomNumber();
        AsciiArtRenderer asciiArtRenderer = new AsciiArtRenderer();
        asciiArtRenderer.RenderAscii(_startScreenText);
        Console.WriteLine("Drücke SPACE um zu starten...");
        while (true)
        {
            if (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                break;
            }
        }

        InputHandler inputHandler = new InputHandler();

        Console.WriteLine("Gib eine Zahl zwischen 1 und 100 ein:");

        while (true)
        {
            _guess = inputHandler.ConvertStringToInt();

            _numberOfGuesses++;
            
            if (CheckForWin() == "won") break;
            Console.Clear();
            Console.WriteLine(CheckForWin());
        }

        HandleWin();
    }

    private void GenerateRandomNumber()
    {
        Random random = new Random();
        _secretNumber = random.Next(1, 100);
    }

    private string CheckForWin()
    {
        if (_guess == _secretNumber) return "won";
        if (_guess > _secretNumber) return "Die gesuchte Zahl ist kleiner";
        if (_guess < _secretNumber) return "Die gesuchte Zahl ist grösser";

        return "";
    }

    private void HandleWin()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Du hast gewonnen!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"Die gesuchte Zahl war {_secretNumber}");
        Console.WriteLine($"Du hast {_numberOfGuesses} Versuche gebraucht");
        CheckForRestart();
    }

    private void CheckForRestart()
    {
        Console.Write("Willst du nochmal spielen? [y/n]: ");
        _numberOfGuesses = 0;
        if (Console.ReadLine() == "y") StartGame();
    }
}