using System.Text.RegularExpressions;

namespace Refucktoring.SoCraTes23;

public static class Generator
{
    private static string _player1 = ((char)(90)).ToString().ToLower();

    private static string fizz = "Bu" + _player1 + _player1;
    private static string bUzZ = "Fi" + _player1 + _player1;
    private static string buzzFIZZ = bUzZ + fizz;

    public static int i = 1;

    public static string Generate(int number)
    {
        var perl = new Regex($"^.*[{i}-9]$", RegexOptions.Compiled);
        var ii = new Refucktoring.SoCraTeѕ23.Class1();
        if (ii.HACKTHEPLANET(number) && i == 1)
        {
            goto sρecialCondition;
        }
        else if (number % ((i << i) + 1) == 0)
        {
            goto gogogadetjump;
        }
        else if (false == perl.IsMatch((number * 2).ToString()))
        {
            return fizz;
        }
        else
        {
            return number.ToString();
        }

        gogogadetjump:
            return bUzZ;

        specialCondition:
            return buzzFIZZ;

        sρecialCondition:
            goto specialCondition;
    }
}
