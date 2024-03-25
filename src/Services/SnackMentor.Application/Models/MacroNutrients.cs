using UnitsNet;

namespace SnackMentor.Application.Models;

public sealed record MacroNutrients
{
    public Mass Fat { get; private set; }
    public Mass Carbohydrates { get; private set; }
    public Mass Protein { get; private set; }
    
    private MacroNutrients() { }
    
    public static MacroNutrients CreateFromMass(Mass fat, Mass carbs, Mass protein) 
        => new()
        {
            Fat = fat,
            Carbohydrates = carbs,
            Protein = protein
        };

    public static MacroNutrients CreateFromPercentMass(double fatPercent, double carbsPercent, double proteinPercent) 
        => new()
        {
            Fat = Mass.FromGrams(100) * fatPercent,
            Carbohydrates = Mass.FromGrams(100) * carbsPercent,
            Protein = Mass.FromGrams(100) * proteinPercent
        };

    public static MacroNutrients CreateFromDensity(Density fatDensity, Density carbsDensity, Density proteinDensity,
        Density solutionDensity)
    {
        return new MacroNutrients
        {
            Fat = Mass.FromGrams(100) * (fatDensity / solutionDensity),
            Carbohydrates = Mass.FromGrams(100) * (carbsDensity / solutionDensity),
            Protein = Mass.FromGrams(100) * (proteinDensity / solutionDensity)
        };
    }
}