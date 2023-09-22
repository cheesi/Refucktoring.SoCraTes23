using Refucktoring.SoCraTes23;

namespace Refucktoring.SoCraTeѕ23;

public class Class1
{
    public Task<bool> HACKTHEPLANET(int number)
    {
        return Task.FromResult(number % ((Generator.i << 1) + Generator.i) == 0 && number % (((int)Math.PI)+2) == 0);
    }
}
