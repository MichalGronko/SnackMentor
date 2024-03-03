using SnackMentor.Application.Models;

namespace SnackMentor.Application.ValueObjects;

public sealed record Measurement
{
    public decimal AmountInGrams { get; }
    public UnitType Unit { get; }

    public Measurement(decimal amount, UnitType unit)
    {
        AmountInGrams = ConvertToGrams(amount, unit);

        Unit = unit;
    }

    private decimal ConvertToGrams(decimal amount, UnitType unit)
    {
        return unit switch
        {
            UnitType.Grams => amount,
            UnitType.Ounces => amount / 0.03527396M,
            _ => AmountInGrams
        };
    }
}