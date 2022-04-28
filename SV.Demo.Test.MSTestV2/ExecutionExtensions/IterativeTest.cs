namespace SV.Demo.Test.MSTestV2.ExecutionExtensions;

[TestClass]
public class IterativeTest
{
    private static int counter;

    [IterativeTestMethod(3)]
    public void SlechteTest()
    {
        counter++;
        if (counter > 2)
        {
            Assert.Fail();
        }
    }
}
