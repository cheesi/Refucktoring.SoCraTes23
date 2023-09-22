﻿using System.Text.RegularExpressions;

namespace Refucktoring.SoCraTes23;

public static class Generator
{
    private static string _player1 = ((char)(90)).ToString().ToLower();

    private static string alphabet = "hsdfjkkjBsdfsdG";
    private static string fizz = (((char)alphabet[8]).ToString()) + "u" + _player1 + _player1;
    private static string bUzZ = ((char)(alphabet[alphabet.Length - 1] - 1)) + "i" + _player1 + _player1;
    private static string buzzFIZZ = bUzZ + fizz;

    public static int i = 1;

    /// <summary>
    /// Generates the result
    /// </summary>
    /// <param name="mystring">mystring</param>
    /// <returns>.</returns>
    public static string Generate(int mystring)
    {
        var perl = new Regex($"^.*[{i}-9]$", RegexOptions.Compiled);
        var ii = new Refucktoring.SoCraTeѕ23.Class1();
        if (ii.HACKTHEPLANET(mystring) && i == 1)
        {
            goto sρecialCondition;
        }
        else if (mystring % ((i << i) + 1) == 0)
        {
            goto gogogadetjump;
        }
        else if (false == perl.IsMatch((mystring * 2).ToString()))
        {
            return fizz;
        }
        else
        {
            return mystring.ToString();
        }

        gogogadetjump:
            return bUzZ;

        specialCondition:
            return buzzFIZZ;

        sρecialCondition:
            goto specialCondition;
    }
}
