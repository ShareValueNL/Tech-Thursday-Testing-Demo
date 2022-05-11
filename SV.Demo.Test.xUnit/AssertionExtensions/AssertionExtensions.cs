namespace SV.Demo.Test.xUnit.AssertionExtensions;

public static class AssertionExtensions
{
    public static void IsOfType<T>(object obj)
    {
        if (obj is T)
        {
            return;
        }
        throw new System.Exception("Type komt niet overeen.");
    }
}
