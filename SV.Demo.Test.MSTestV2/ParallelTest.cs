using System.Threading;

namespace SV.Demo.Test.MSTestV2
{
    [TestClass]
    public class ParallelTest
    {
        [TestMethod]
        [DoNotParallelize]
        public void TestMethod1()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Thread.Sleep(3000);
        }

        [Ignore]
        public void TestMethod3()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Thread.Sleep(3000);
        }

    }
}