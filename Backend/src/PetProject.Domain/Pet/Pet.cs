using System.ComponentModel.Design;
using CSharpFunctionalExtensions;
using PetProject.Domain.Pet.Enums;
using PetProject.Domain.Pet.ValueObjects;
using PetProject.Domain.Pet.ValueObjects.Ids;
using PetProject.Domain.Shared.ValueObjects;

namespace PetProject.Domain.Pet;

public class Pet : Shared.Entity<PetId>
{
    private Pet() : base(PetId.Empty())
    {
    }

    private Pet(
        PetId id,
        Title title,
        Description description,
        Color color,
        Breed breed,
        Species species,
        PetStatus petStatus,
        DateOnly birthDate,
        bool isNeutered,
        bool isVaccinated,
        Phone ownerPhone,
        Address address,
        Requisites requisites,
        HealthInfo healthInfo,
        DateTime createdAt) : base(id)
    {
        Title = title;
        Description = description;
        Color = color;
        Breed = breed;
        Species = species;
        PetStatus = petStatus;
        BirthDate = birthDate;
        IsNeutered = isNeutered;
        IsVaccinated = isVaccinated;
        OwnerPhone = ownerPhone;
        Address = address;
        Requisites = requisites;
        HealthInfo = healthInfo;
        CreatedAt = createdAt;
    }
    
    
    public Title Title { get; private set; }
    
    public Description Description { get; private set; }

    public Color Color { get; private set; }

    public Breed Breed { get; private set; }        //не VO, он хранит в себе id

    public Species Species { get; private set; }    //не VO, он хранит в себе id
    
    public PetStatus PetStatus { get; private set; }
    
    public DateOnly BirthDate { get; private set; }
    
    public bool IsNeutered { get; private set; }
    
    public bool IsVaccinated { get; private set; }
    
    public DateTime CreatedAt { get; private set; }
    
    public Phone OwnerPhone { get; private set; }
    
    public Address Address { get; private set; }
    
    public Requisites Requisites { get; private set; }
    
    public HealthInfo HealthInfo { get; private set; }
    

    public static Result<Pet, string> Create(
        PetId id,
        Title title,
        Description description,
        Color color,
        Breed breed,
        Species species,
        PetStatus petStatus,
        DateOnly birthDate,
        bool isNeutered,
        bool isVaccinated,
        Phone ownerPhone,
        Address address,
        Requisites requisites,
        HealthInfo healthInfo)
    {
        var createdAt = DateTime.Now.ToLocalTime();
        var pet = new Pet(
            id,
            title,
            description,
            color,
            breed,
            species,
            petStatus,
            birthDate,
            isNeutered,
            isVaccinated,
            ownerPhone,
            address,
            requisites,
            healthInfo,
            createdAt);
        return pet;
    } 
    
}

/*
Id                                              [+]
Кличка                                          [+]
Вид (например - собака, кошка)                  [+]
Общее описание                                  [+]
Порода                                          [+]
Окрас                                           [+]
Информация о здоровье питомца
Адрес, где находится питомец                    [+]
Вес                                             [+]
Рост                                            [+]
Номер телефона для связи с владельцем           [+]
Кастрирован или нет                             [+]
Дата рождения                                   [+]
Вакцинирован или нет                            [+]
Статус помощи - Нуждается в помощи/Ищет дом/Нашел дом [+]
Реквизиты для помощи (у каждого реквизита будет название и описание, как сделать перевод), поэтому нужно сделать отдельный класс для реквизита. Это должен быть Value Object.
Дата создания [+]
 */