namespace SV.Demo.Test.MSTestV2.AssertionExtensions;

public static class AssertionExtensions
{
    public static void IsOfType<T>(this Assert assert, object obj)
    {
        if (obj is T)
        {
            return;
        }
        throw new AssertFailedException("Type komt niet overeen.");
    }
}
