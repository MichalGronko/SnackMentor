using SnackMentor.Application.ValueObjects;

namespace SnackMentor.Application.Models;

public sealed class Dish
{
    public required string Name { get; set; }
    public required IEnumerable<int> IngredientIds { get; set; }
    public required Dictionary<int, Measurement> Ingredients { get; set; } //<ingredientId, measurement>
}