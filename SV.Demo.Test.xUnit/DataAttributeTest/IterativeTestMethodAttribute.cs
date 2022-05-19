using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit.Sdk;

namespace SV.Demo.Test.xUnit.DataAttributeTest;

public sealed class IterativeTestMethodAttribute : DataAttribute
{
    private readonly int count;

    public IterativeTestMethodAttribute(int count)
    {
        if (count < 1)
        {
            throw new System.ArgumentOutOfRangeException(
                paramName: nameof(count),
                message: "Repeat count must be greater than 0.");
        }
        this.count = count;
    }

    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        foreach (var iterationNumber in Enumerable.Range(start: 1, count: this.count))
        {
            yield return new object[] { iterationNumber };
        }
    }
}