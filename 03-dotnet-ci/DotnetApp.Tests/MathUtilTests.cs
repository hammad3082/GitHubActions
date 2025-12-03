using Xunit;

public class MathUtilTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        int result = MathUtil.Add(2, 3);
        Console.WriteLine($"TestAddition: 2 + 3 = {result}");
        Assert.Equal(5, result);
    }
}
