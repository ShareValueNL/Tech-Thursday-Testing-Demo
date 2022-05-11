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
