using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace SV.Demo.Test.MSTestV2.DataDrivenExtensions;

public class CustomTestDataSourceAttribute : Attribute, ITestDataSource
{
    public IEnumerable<object[]> GetData(MethodInfo methodInfo)
    {
        yield return new object[] { 1, 2, 3 };
        yield return new object[] { 2, 5, 7 };
        yield return new object[] { 4, 6, 10 };
    }

    public string GetDisplayName(MethodInfo methodInfo, object[] data)
    {
        if (data != null)
        {
            return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", methodInfo.Name, string.Join(",", data));
        }

        return null;
    }
}