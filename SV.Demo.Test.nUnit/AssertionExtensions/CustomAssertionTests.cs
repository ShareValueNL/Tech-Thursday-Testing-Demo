namespace SV.Demo.Test.nUnit.AssertionExtensions;

[TestFixture]
public class CustomAssertionTests
{
    [Test]
    public void TestMethodWithCustomAssertion()
    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        AssertionException ex = Assert.Throws<AssertionException>(() =>
        {
            AssertionExtensions.IsOfType<int>("Hello World");
        });
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        ex.Message.Should().Be("Type komt niet overeen.");
    }
}
