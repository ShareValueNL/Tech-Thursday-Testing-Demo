using System.Diagnostics;

namespace SV.Demo.Test.xUnit;

public class RunnableInDebugOnlyAttribute : FactAttribute
{
	public RunnableInDebugOnlyAttribute()
	{
		if (!Debugger.IsAttached)
		{
			Skip = "Only running in interactive mode.";
		}
	}
}
