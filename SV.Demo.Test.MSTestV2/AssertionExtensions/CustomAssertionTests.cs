using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SV.Demo.Test.MSTestV2.AssertionExtensions;

[TestClass]
public class CustomAssertionTests
{

    [TestMethod]
    public void TestMethodWithCustomAssertion()
    {
        AssertFailedException ex = Assert.ThrowsException<AssertFailedException>(() =>
        {
            Assert.That.IsOfType<int>("Hello World");
        });

        ex.Message.Should().Be("Type komt niet overeen.");
    }
}
