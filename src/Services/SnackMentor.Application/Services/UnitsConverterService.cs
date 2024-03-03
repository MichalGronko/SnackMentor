namespace SnackMentor.Application.Services;

public sealed class UnitsConverterService
{
    public double ConvertGramsToOunces(double grams)
    {
        return grams * 0.03527396;
    }

    public double ConvertOuncesToGrams(double ounces)
    {
        return ounces / 0.03527396;
    }

    public double ConvertCupsToGrams(double cups)
    {
        return cups * 236.588;
    }

    public double ConvertGramsToCups(double grams)
    {
        return grams / 236.588;
    }

    public double ConvertTeaspoonsToTablespoons(double teaspoons)
    {
        return teaspoons / 3;
    }

    public double ConvertTablespoonsToTeaspoons(double tablespoons)
    {
        return tablespoons * 3;
    }
}