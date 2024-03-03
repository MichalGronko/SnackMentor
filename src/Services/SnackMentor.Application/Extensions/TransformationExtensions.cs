namespace SnackMentor.Application.Extensions;

public static class TransformationExtensions
{
    public static decimal CaloriesToJoules(decimal calories) 
        => calories * 4.184M;

    public static decimal JoulesToCalories(decimal joules) 
        => joules * 0.239005736M;
}