using SnackMentor.Application.Models;

namespace SnackMentor.Application.ValueObjects;

public sealed record Measurement
{
    public decimal Amount { get; }
    public UnitType Unit => UnitType.Grams;

    public Measurement(decimal amount, UnitType unit)
    {
        Amount = Save(amount, unit);
    }

    private decimal Save(decimal amount, UnitType unit) 
        => unit switch
        {
            UnitType.Grams => amount,
            UnitType.Ounces => amount / 0.03527396M,
            _ => Amount
        };

    public decimal DisplayAs(UnitType unit) 
        => unit switch
        {
            UnitType.Grams => Amount,
            UnitType.Ounces => Amount / 28.3495m,
            UnitType.Cups => Amount / 236.588m,
            UnitType.Teaspoons => Amount / 5.91m,
            UnitType.Tablespoons => Amount / 14.79m,
            _ => throw new ArgumentOutOfRangeException(nameof(unit), unit, null)
        };
}