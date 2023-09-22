namespace Refucktoring.SoCraTes23;

public static class Generator
{
    private const string _player1 = "z";

    private const string fizz = "Bu" + _player1 + _player1;
    private static string bUzZ = "Fi" + _player1 + _player1;
    private static string buzzFIZZ = bUzZ + fizz;

    public static int i = 1;

    public static string Generate(int number)
    {
        var ii = new Refucktoring.SoCraTeѕ23.Class1();
        if (ii.HACKTHEPLANET(number) && i == 1)
        {
            goto sρecialCondition;
        }
        else if (number % ((i << i) + 1) == 0)
        {
            goto gogogadetjump;
        }
        else if (number % 5 == 0)
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
