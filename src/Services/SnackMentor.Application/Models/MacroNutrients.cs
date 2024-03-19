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
        Volume fatVolume = fatDensity / solutionDensity * Volume.FromMilliliters(100);
        Mass fatMass = fatDensity * fatVolume;
        
        Volume carbsVolume = carbsDensity / solutionDensity * Volume.FromMilliliters(100);
        Mass carbsMass = carbsDensity * carbsVolume;
        
        Volume proteinVolume = proteinDensity / solutionDensity * Volume.FromMilliliters(100);
        Mass proteinMass = proteinDensity * proteinVolume;
        
        Mass solutionMass = solutionDensity * Volume.FromMilliliters(100);

        Mass fatPer100Grams = Mass.FromGrams(100) * fatMass.Grams / solutionMass.Grams;
        Mass carbsPer100Grams = Mass.FromGrams(100) * carbsMass.Grams / solutionMass.Grams;
        Mass proteinPer100Grams = Mass.FromGrams(100) * proteinMass.Grams / solutionMass.Grams;

        // Volume volumeIn100g = Volume.FromLiters(0.1);
        //
        // Volume fatVolume = fatDensity / solutionDensity * volumeIn100g;
        // Volume proteinVolume = proteinDensity / solutionDensity * volumeIn100g;
        // Volume carbsVolume = carbsDensity / solutionDensity * volumeIn100g;
        //
        // Mass fatPer100g = fatVolume
        // Mass proteinPer100g = proteinVolume.Mass;
        // Mass carbsPer100g = carbsVolume.Mass;

        return new MacroNutrients
        {
            Fat = fatPer100Grams,
            Carbohydrates = carbsPer100Grams,
            Protein = proteinPer100Grams
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