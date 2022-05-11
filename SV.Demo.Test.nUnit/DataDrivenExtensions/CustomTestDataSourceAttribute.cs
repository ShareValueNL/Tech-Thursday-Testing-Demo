using System.Collections.Generic;

namespace SV.Demo.Test.nUnit.DataDrivenExtensions;

public class CustomTestDataSource
{
    public static IEnumerable<object[]> GetDataForTest()
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 2, 5, 7 };
        yield return new object[] { 4, 6, 10 };
    }
}