using PetProject.Domain.Pet.ValueObjects.Ids;
using PetProject.Domain.Shared;

namespace PetProject.Domain.Pet;

public class Species : Entity<SpeciesId>
{
    private Species() : base(SpeciesId.Empty())
    {
    }

    private Species(SpeciesId id) : base(id)
    {
    }
}