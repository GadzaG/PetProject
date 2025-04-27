using CSharpFunctionalExtensions;
using PetProject.Domain.Pet.ValueObjects.Ids;
using PetProject.Domain.Shared.ValueObjects;

namespace PetProject.Domain.Pet;

public class Breed : Shared.Entity<BreedId>
{
    private Breed() : base(BreedId.Empty())
    {
    }

    private Breed(BreedId id, Title title) : base(id)
    {
        Title = title;
    }
    
    public Title Title { get; private set; }

    public static Result<Breed, string> Create(BreedId id, Title title)
    {
        var breed = new Breed();
        return breed;
    }
}