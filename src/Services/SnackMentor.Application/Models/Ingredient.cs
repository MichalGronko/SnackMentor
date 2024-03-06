namespace SnackMentor.Application.Models;

public sealed class Ingredient
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Type { get; set; }
    public required string Description { get; set; }
    
    public required string? Category { get; set; }
    public required string? Brand { get; set; }
    public required string? Manufacturer { get; set; }

    public required IEnumerable<Attribute> Attributes { get; set; }
}