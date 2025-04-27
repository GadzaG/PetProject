using System.Dynamic;
using CSharpFunctionalExtensions;

namespace PetProject.Domain.Pet.ValueObjects;

public record Weight
{
    public double Value { get; private set; }

    private Weight(double weight)
    {
        Value = weight;
    }
    
    public static Result<Weight, string> Create(double weight)
    {
        if (weight <= 0)
        {
            return "Weight must be greater than 0";
        }

        return new Weight(weight);
    }
}