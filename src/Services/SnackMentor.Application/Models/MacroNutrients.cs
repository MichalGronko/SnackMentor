using UnitsNet;

namespace SnackMentor.Application.Models;

public sealed class MacroNutrients
{
    // public Measurement Fat { get; set; }
    // public Measurement Carbohydrates { get; set; }
    // public Measurement Protein { get; set; }
    // public Measurement Fiber { get; set; }
    
    public Mass Fat { get; private set; }
    public Mass Carbohydrates { get; private set; }
    public Mass Protein { get; private set; }

    public void Create(Mass fat, Mass carbohydrates, Mass protein, NutrientStrategy strategy)
    {
        if (strategy == NutrientStrategy.Per100Gram)
        {
            Fat = fat;
            Carbohydrates = carbohydrates;
            Protein = protein;
        }
        
        // if(strategy == )
        
        
    }

    public static MacroNutrients CreateNew(Density fatDensity, Density carbsDensity, Density proteinDensity, Density solutionDensity)
    {
        Mass mass = Mass.FromGrams(100);

        return new MacroNutrients
        {
            Fat = mass * (fatDensity / solutionDensity),
            Carbohydrates = mass * (carbsDensity / solutionDensity),
            Protein = mass * (proteinDensity / solutionDensity)
        };
    }
    
    public void Create(Mass fat, Mass carbohydrates, Mass protein, Density substanceDensity)
    {
        // Volume volume = Volume.FromMilliliters(100);
        //
        // Mass fat = Mass.FromGrams(fatInGrams) / volume;
        // Mass carbs = Mass.FromGrams(carbsInGrams) / volume;
        // Mass protein = Mass.FromGrams(proteinInGrams) / volume;
        //
        // // Calculate mass per 100g using density
        // Mass fatPer100g = fat * density;
        // Mass carbsPer100g = carbs * density;
        // Mass proteinPer100g = protein * density;
        //
        // return (fatPer100g, carbsPer100g, proteinPer100g);

        // Density x = fat / Volume.FromMilliliters(100);
        // var y = x.Value * fat.Value
        // Fat = (fat / Volume.FromMilliliters(100)) * density
    }
    
    
    // public static double ConvertTeaspoonsToGrams(double teaspoons)
    // {
    //     Volume volumeInTeaspoons = Volume.FromMetricTeaspoons(teaspoons);
    //     var massInGrams = volumeInTeaspoons.ToUnit();
    //
    //     return massInGrams.Grams;
    // }
}

public enum NutrientStrategy
{
    Per100Gram,
    Per100Milliliters
}