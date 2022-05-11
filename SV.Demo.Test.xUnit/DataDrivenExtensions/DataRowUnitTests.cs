namespace SV.Demo.Test.xUnit.DataDrivenExtensions;

public class DataRowUnitTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 5, 7)]
    [InlineData(4, 6, 10)]
    public void DataRowAddTest(int a, int b, int expected)
    {
        int actual = Calculator.Add(a, b);
        actual.Should().Be(expected);
    }
}
