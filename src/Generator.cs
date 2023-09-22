﻿namespace Refucktoring.SoCraTes23;

public static class Generator
{
    private const string fizz = "Buzz";
    private static string bUzZ = "Fizz";
    private static string buzzFIZZ = bUzZ + fizz;

    public static string Generate(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return buzzFIZZ;
        }
        else if (number % 3 == 0)
        {
            return bUzZ;
        }
        else if (number % 5 == 0)
        {
            return fizz;
        }
        else
        {
            return number.ToString();
        }
    }
}
