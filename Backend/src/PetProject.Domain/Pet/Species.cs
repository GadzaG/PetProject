using System.Dynamic;
using CSharpFunctionalExtensions;
using PetProject.Domain.Pet.ValueObjects.Ids;
using PetProject.Domain.Shared.ValueObjects;

namespace PetProject.Domain.Pet;

public class Species : Shared.Entity<SpeciesId>
{
    private Species() : base(SpeciesId.Empty())
    {
    }

    private Species(SpeciesId id, Title title) : base(id)
    {
        Title = title;
    }
    
    public Title Title { get; private set; }

    private readonly List<Breed> _breeds = [];

    public IReadOnlyList<Breed> Breeds => _breeds;
    
    public static Result<Species, string> Create(SpeciesId id, Title title)
    {
        var species = new Species(id, title);
        return species;
    }
    
    public UnitResult<string> AddBreed(Breed breed)
    {
        _breeds.Add(breed);
        return UnitResult.Success<string>();
    }
    
}