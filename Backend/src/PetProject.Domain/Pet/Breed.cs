using PetProject.Domain.Pet.ValueObjects.Ids;
using PetProject.Domain.Shared;

namespace PetProject.Domain.Pet;

public class Breed : Entity<BreedId>
{
    private Breed() : base(BreedId.Empty())
    {
    }

    private Breed(BreedId id) : base(id)
    {
    }
}