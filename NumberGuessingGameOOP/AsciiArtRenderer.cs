using Figgle;

namespace NumberGuessingGameOOP;

public class AsciiArtRenderer
{
    public void RenderAscii(string text)
    {
        Console.WriteLine(FiggleFonts.Standard.Render(text));
    }
}