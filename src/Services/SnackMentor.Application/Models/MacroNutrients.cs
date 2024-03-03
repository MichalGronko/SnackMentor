using SnackMentor.Application.ValueObjects;

namespace SnackMentor.Application.Models;

public sealed class MacroNutrients
{
    public required Measurement Fat { get; set; }
    public required Measurement Carbohydrates { get; set; }
    public required Measurement Protein { get; set; }
    public required Measurement Fiber { get; set; }
}