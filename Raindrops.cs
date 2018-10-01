using System;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string output = string.Empty;
        if(number % 3 == 0)
            output += "Pling";
        
        if(number % 5 == 0)      
            output += "Plang";
        
        if (number % 7 == 0)
            output += "Plong";
    
        if (string.IsNullOrEmpty(output))        
            output = number.ToString();
        
        return output;
    }
}