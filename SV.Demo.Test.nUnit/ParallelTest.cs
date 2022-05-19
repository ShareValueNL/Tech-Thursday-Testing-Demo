using System.Threading;

namespace SV.Demo.Test.nUnit;

[Parallelizable(ParallelScope.All)]
[TestFixture]
public class ParallelTest
{
    [Test]
    [NonParallelizable]
    public void TestMethod1()
    {
        Thread.Sleep(3000);
    }

    [Test]
    public void TestMethod2()
    {
        Thread.Sleep(3000);
    }

    [Ignore("Overslaan")]
    public void TestMethod3()
    {
        Thread.Sleep(3000);
    }

    [Test]
    public void TestMethod4()
    {
        Thread.Sleep(3000);
    }

    [Test]
    public void TestMethod5()
    {
        Thread.Sleep(3000);
    }

    [DebugOnly]
    public void TestMethod6()
    {
        Thread.Sleep(3000);
    }

#if DEBUG
    [Test]
    public void TestMethod7()
    {
        Thread.Sleep(3000);
    }
#endif
}
