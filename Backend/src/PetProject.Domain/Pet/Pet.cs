using CSharpFunctionalExtensions;
using PetProject.Domain.Pet.Enums;
using PetProject.Domain.Pet.ValueObjects.Ids;
using PetProject.Domain.Shared.ValueObjects;

namespace PetProject.Domain.Pet;

public class Pet : Shared.Entity<PetId>
{
    private Pet() : base(PetId.Empty())
    {
    }

    private Pet(PetId id) : base(id)
    {
    }
    
    
    public Title Title { get; private set; }
    
    public Description Description { get; private set; }
    
    public Breed Breed { get; private set; }

    public Species Species { get; private set; }
    
    public PetStatus PetStatus { get; private set; }
    
    public DateOnly BirthDate { get; private set; }
    
    public bool IsNeutered { get; private set; }
    
    public bool IsVaccinated { get; private set; }

    public static Result<Pet, string> Create(PetId id)
    {
        var pet = new Pet(id);
        return pet;
    } 
    
}