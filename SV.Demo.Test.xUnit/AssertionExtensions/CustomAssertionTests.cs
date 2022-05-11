using System;

namespace SV.Demo.Test.xUnit.AssertionExtensions;

public class CustomAssertionTests
{
    [Fact]
    public void TestMethodWithCustomAssertion()
    {
        Exception ex = Assert.Throws<Exception>(() =>
        {
            AssertionExtensions.IsOfType<int>("Hello World");
        });

        ex.Message.Should().Be("Type komt niet overeen.");
    }
}
