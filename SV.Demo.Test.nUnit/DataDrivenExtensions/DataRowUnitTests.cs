using NUnit.Framework;

namespace SV.Demo.Test.MSTestV2.DataDrivenExtensions;

[TestFixture]
public class DataRowUnitTests
{
	[Test]
	[TestCase(1, 2, 3)]
	[TestCase(2, 5, 7)]
	[TestCase(4, 6, 10)]
	public void DataRowAddTest(int a, int b, int expected)
	{
		int actual = Calculator.Add(a, b);
		actual.Should().Be(expected);
	}
}
