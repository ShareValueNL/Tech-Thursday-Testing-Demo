using System.Collections.Generic;

namespace SV.Demo.Test.nUnit.DataDrivenExtensions;

[TestFixture]
public class DynamicDataUnitTests
{
    [TestCaseSource(nameof(GetDataForTest))]
    public void DynamicDataTestMethod(int a, int b, int exp)
    {
        int actual = Calculator.Add(a, b);
        actual.Should().Be(exp);
    }

    static IEnumerable<object[]> GetDataForTest()
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 2, 5, 7 };
        yield return new object[] { 4, 6, 10 };
    }

    [TestCaseSource(typeof(CustomTestDataSource), nameof(CustomTestDataSource.GetDataForTest))]
    public void CustomDataTestMethod(int a, int b, int exp)
    {
        int actual = Calculator.Add(a, b);
        actual.Should().Be(exp);
    }
}
