namespace NumberGuessingGameOOP;

public class InputHandler
{
    public int ConvertStringToInt()
    {
        int number = 0;
        
        try
        {
            number = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            if (number > 100 || number < 1) throw new Exception();
        }
        catch
        {
            Console.Clear();
            Console.WriteLine("Ungültige Eingabe!");
            ConvertStringToInt();
        }

        return number;
    }
}