using CSharpFunctionalExtensions;

namespace PetProject.Domain.Pet.ValueObjects;

public record Color
{
    public byte Red { get; private set; }
    
    public byte Green { get; private set; }
    
    public byte Blue { get; private set; }

    private Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
    
    public static Result<Color, string> Create(byte red, byte green, byte blue)
    {
        return new Color(red, green, blue);
    }
    
    public static Result<Color, string> Create(string color)
    {
        //todo тут сделать парсинг из строки
        throw new NotImplementedException();
        //return new Color(red, green, blue);
    }
}