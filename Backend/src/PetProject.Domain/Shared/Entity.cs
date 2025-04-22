using System.Text.Json;
using System.Text.Json.Serialization;

namespace PetProject.Domain.Shared;

public abstract class Entity<TId> where TId : notnull
{
    protected Entity(TId id) => Id = id;
    
    public TId Id { get; private set; }
    
    public override string ToString()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            IncludeFields = false
        };

        return JsonSerializer.Serialize(this, this.GetType(), options);
    }
}