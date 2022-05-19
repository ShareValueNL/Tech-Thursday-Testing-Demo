using System.Threading;

namespace SV.Demo.Test.xUnit;

[CollectionDefinition("Papallel Collection", DisableParallelization = false)]
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

    [RunnableInDebugOnly]
    public void TestMethod3()
    {
        Thread.Sleep(3000);
    }

    [Fact]
    public void TestMethod4()
    {
        Thread.Sleep(3000);
    }

    [Fact]
    public void TestMethod5()
    {
        Thread.Sleep(3000);
    }

    [Fact]
    public void TestMethod6()
    {
        Thread.Sleep(3000);
    }

}

public class ParallelTest2
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

public class ParallelTest3
{
    [Fact]
    public void TestMethod1()
    {
        Thread.Sleep(2000);
    }

    [Fact]
    public void TestMethod2()
    {
        Thread.Sleep(2000);
    }

    [Fact]
    public void TestMethod3()
    {
        Thread.Sleep(2000);
    }

    [Fact]
    public void TestMethod4()
    {
        Thread.Sleep(2000);
    }

}

public class ParallelTest4
{
    [Fact]
    public void TestMethod1()
    {
        Thread.Sleep(2000);
    }

    [Fact]
    public void TestMethod2()
    {
        Thread.Sleep(2000);
    }

    [Fact]
    public void TestMethod3()
    {
        Thread.Sleep(2000);
    }

    [Fact]
    public void TestMethod4()
    {
        Thread.Sleep(2000);
    }

}
