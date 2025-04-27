using System.Text.RegularExpressions;
using CSharpFunctionalExtensions;

namespace PetProject.Domain.Shared.ValueObjects;

public partial record Phone
{
    public string Value { get; private set; }

    private Phone(string phone)
    {
        Value = phone;
    }

    public static Result<Phone, string> Create(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone))
        {
            return "Phone number cannot be null or empty.";
        }
        
        if (!PhoneRegex().IsMatch(phone))
        {
            return "Phone number is not in a valid format.";
        }

        return new Phone(phone);
    }

    [GeneratedRegex(@"^\+?[1-9]\d{1,14}$")]
    private static partial Regex PhoneRegex();
}