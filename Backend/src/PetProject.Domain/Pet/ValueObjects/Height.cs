using CSharpFunctionalExtensions;

namespace PetProject.Domain.Pet.ValueObjects;

public record Height
{
    public double Value { get; private set; }

    private Height(double height)
    {
        Value = height;
    }
    
    public static Result<Height, string> Create(double weight)
    {
        if (weight <= 0)
        {
            return "Height must be greater than 0";
        }

        return new Height(weight);
    }
}