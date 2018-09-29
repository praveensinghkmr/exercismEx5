using System;

public static class Raindrops
{
    /// <summary>
    /// If the number has 3 as a factor, output 'Pling'. 
    /// If the number has 5 as a factor, output 'Plang'.
    /// If the number has 7 as a factor, output 'Plong'.
    /// Else return the number
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static string Convert(int number)
    {
        String Output = String.Empty;
        if(number % 3 == 0)
        {
            Output = Output + "Pling";
        }
        if(number % 5 == 0)
        {
            Output = Output + "Plang";
        }
        if (number % 7 == 0)
        {
            Output = Output + "Plong";
        }
        if (String.IsNullOrEmpty(Output))
        {
            Output = number.ToString();
        }
        return Output;
    }
}