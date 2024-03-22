using UnitsNet;

namespace SnackMentor.Application.Models;

public sealed class MacroNutrients
{
    public Mass Fat { get; private set; }
    public Mass Carbohydrates { get; private set; }
    public Mass Protein { get; private set; }
    
    public static MacroNutrients CreateFromMass(Mass fat, Mass carbs, Mass protein) 
        => new()
        {
            Fat = fat,
            Carbohydrates = carbs,
            Protein = protein
        };

    public static MacroNutrients CreateFromPercentMass(double fatPercent, double carbsPercent, double proteinPercent)
    {
        Mass mass = Mass.FromGrams(100);

        return new MacroNutrients
        {
            Fat = mass * fatPercent,
            Carbohydrates = mass * carbsPercent,
            Protein = mass * proteinPercent
        };
    }

    public static MacroNutrients CreateFromDensity(Density fatDensity, Density carbsDensity, Density proteinDensity,
        Density solutionDensity)
    {
        Mass mass = Mass.FromGrams(100);

        return new MacroNutrients
        {
            Fat = mass * (fatDensity / solutionDensity),
            Carbohydrates = mass * (carbsDensity / solutionDensity),
            Protein = mass * (proteinDensity / solutionDensity)
        };
    }
}