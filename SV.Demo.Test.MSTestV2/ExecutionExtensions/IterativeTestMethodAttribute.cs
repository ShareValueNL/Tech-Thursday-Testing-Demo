using System;
using System.Collections.Generic;

namespace SV.Demo.Test.MSTestV2.ExecutionExtensions;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class IterativeTestMethodAttribute : TestMethodAttribute
{
    private readonly int _stabilityTreshold;

    public IterativeTestMethodAttribute(int stabilityTreshold)
    {
        _stabilityTreshold = stabilityTreshold;
    }

    public override TestResult[] Execute(ITestMethod testMethod)
    {
        var results = new List<TestResult>();
        for (int counter = 0; counter < _stabilityTreshold; counter++)
        {
            var currentResults = base.Execute(testMethod);
            results.AddRange(currentResults);
        }

        return results.ToArray();
    }
}
