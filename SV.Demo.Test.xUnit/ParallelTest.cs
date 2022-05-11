using System.Threading;

namespace SV.Demo.Test.xUnit;

public class ParallelTest
{
    [Fact]
    public void TestMethod1()
    {
        Thread.Sleep(3000);
    }

    [Fact]
    public void TestMethod2()
    {
        Thread.Sleep(3000);
    }

    [Fact]
    public void TestMethod3()
    {
        Thread.Sleep(3000);
    }

    [Fact]
    public void TestMethod4()
    {
        Thread.Sleep(3000);
    }
}
