namespace Refucktoring.SoCraTes23;

public static class Generator
{
    private const string fizz = "Buzz";
    private static string bUzZ = "Fizz";
    private static string buzzFIZZ = bUzZ + fizz;

    public static int i = 1;

    public static string Generate(int number)
    {
        if (HACKTHEPLANET(number) && i == 1)
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

    private static bool HACKTHEPLANET(int number)
    {
        return number % ((i << 1) + i) == 0 && number % 5 == 0;
    }
}
