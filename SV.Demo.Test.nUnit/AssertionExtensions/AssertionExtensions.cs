namespace SV.Demo.Test.nUnit.AssertionExtensions;

public static class AssertionExtensions
{
    public static void IsOfType<T>(object obj)
    {
        if (obj is T)
        {
            return;
        }

        throw new AssertionException("Type komt niet overeen.");
    }
}
