namespace PetProject.Domain.Shared.ValueObjects;

public record Title
{
    public string Value { get; private set; }

    private Title(string title)
    {
        
    }
}