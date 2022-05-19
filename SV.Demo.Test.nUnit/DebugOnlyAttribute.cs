
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System.Diagnostics;

namespace SV.Demo.Test.nUnit;

/// <summary>
/// Zou moeten werken, maar gedraagt zich als een [Ignore] in Visual Studio.
/// </summary>
public class DebugOnlyAttribute : NUnitAttribute, IApplyToTest
{
    private const string _reason = "Debug only";

    public void ApplyToTest(NUnit.Framework.Internal.Test test)
    {
        if (!Debugger.IsAttached)
        {
            test.RunState = RunState.Ignored;
            test.Properties.Set(PropertyNames.SkipReason, _reason);
        }
    }
}

