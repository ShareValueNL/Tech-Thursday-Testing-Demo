namespace SV.Demo.Test.nUnit.RangeTest;

[TestFixture]
public class IterativeTest
{
    private static int counter;

    [Test]
    public void SlechteTest([Range(1, 3)] int threshold)
    {
        counter++;
        if (counter > 2)
        {
            Assert.Fail();
        }
    }
}
