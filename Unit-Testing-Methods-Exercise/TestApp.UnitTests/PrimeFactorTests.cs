using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long number = 7;
        long expected = 7;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long number = 328;
        long expected = 41;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
