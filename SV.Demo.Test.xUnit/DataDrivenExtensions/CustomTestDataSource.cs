using System.Collections;
using System.Collections.Generic;

namespace SV.Demo.Test.xUnit.DataDrivenExtensions;

public class CustomTestDataSource : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 2, 5, 7 };
        yield return new object[] { 4, 6, 10 };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}