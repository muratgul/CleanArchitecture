using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Entities;

public sealed class Car : Entity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public int EnginePower { get; set; }
}
