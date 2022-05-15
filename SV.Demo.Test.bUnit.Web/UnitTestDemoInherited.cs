using SV.Demo.Blazor.Pages;
using FluentAssertions.BUnit;

namespace SV.Demo.Test.bUnit.Web;

public class UnitTestDemoInherited : TestContext
{
    [Fact]
    public void CounterShouldIncrementWhenClicked()
    {
        // Arrange: render the Counter.razor component
        var cut = RenderComponent<Counter>();

        // Act: find and click the <button> element to increment
        // the counter in the <p> element
        cut.Find("button").Click();

        // Assert: first find the <p> element, then verify its content
        cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");

        cut.Find("button").Click();
        cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 2</p>");

    }


}
