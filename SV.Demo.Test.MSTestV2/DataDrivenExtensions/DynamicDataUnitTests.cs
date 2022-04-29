using System.Collections.Generic;

namespace SV.Demo.Test.MSTestV2.DataDrivenExtensions;

[TestClass]
public class DynamicDataUnitTests
{

    [TestMethod]
    [DynamicData(nameof(GetDataForTest), DynamicDataSourceType.Method)]
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

    [TestMethod]
    [CustomTestDataSource]
    public void CustomDataTestMethod(int a, int b, int exp)
    {
        int actual = Calculator.Add(a, b);
        actual.Should().Be(exp);
    }
}
