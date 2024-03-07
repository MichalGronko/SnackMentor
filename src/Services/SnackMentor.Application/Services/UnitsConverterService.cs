namespace SnackMentor.Application.Services;

public sealed class UnitsConverterService
{
    public double ConvertGramsToOunces(double grams) 
        => grams * 0.03527396;

    public double ConvertOuncesToGrams(double ounces) 
        => ounces / 0.03527396;

    public double ConvertCupsToGrams(double cups) 
        => cups * 236.588;

    public double ConvertGramsToCups(double grams) 
        => grams / 236.588;

    public double ConvertTeaspoonsToTablespoons(double teaspoons) 
        => teaspoons / 3;

    public double ConvertTablespoonsToTeaspoons(double tablespoons) 
        => tablespoons * 3;
}