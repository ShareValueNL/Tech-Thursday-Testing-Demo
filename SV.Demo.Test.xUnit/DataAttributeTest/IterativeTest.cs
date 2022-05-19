namespace SV.Demo.Test.xUnit.DataAttributeTest;

[Collection("Non-Parallel Collection")]
public class IterativeTest
{
    private static int counter;

    [Theory]
    [IterativeTestMethod(3)]
    public void SlechteTest(int iterationNumber)
    {
        counter++;
        if (counter > 2)
        {
            Assert.True(false);
        }
    }
}
