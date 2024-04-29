namespace CICDTest.Tests;

public class MathTests
{
    private int a;
    private int b;

    [SetUp]
    public void SetUp()
    {
        a = 10;
        b = 2;
    }

    [Test]
    public void SumTest()
    {
        var result = a + b;

        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void DifferenceTest()
    {
        var result = a - b;

        Assert.That(result, Is.EqualTo(8));
    }

    [Test]
    public void DivisionTest()
    {
        var result = a / b;

        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void MultiplyTest()
    {
        var result = a / b;

        Assert.That(result, Is.EqualTo(20));
    }
}