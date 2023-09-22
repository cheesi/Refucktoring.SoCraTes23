namespace Refucktoring.SoCraTes23.Tests;

public class Tests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public void Tests_numbers(int number)
    {
        var result = Generator.SubtractifyLife(number);

        Assert.Equal(number.ToString(), result);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    public void Tests_divisible_by_3(int n)
    {
        var result = Generator.SubtractifyLife(n);

        Assert.Equal("Fizz", result);
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void Tests_divisible_by_5(int number)
    {
        var result = Generator.SubtractifyLife(number);

        Assert.Equal("Buzz", result);
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void Tests_divisible_by_3_and_5(int number)
    {
        var result = Generator.SubtractifyLife(number);

        Assert.Equal("FizzBuzz", result);
    }
}
