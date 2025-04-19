using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int fibonacci = 0;
        int expected = 0;

        // Act
        int result = Fibonacci.CalculateFibonacci(fibonacci);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(6, 8)]
    [TestCase(13, 233)]
    [TestCase(19, 4181)]
    public void Test_CalculateFibonacci_PositiveInput(int fibonacci, int expected)
    {
        // Arrange
       

        // Act
        int result = Fibonacci.CalculateFibonacci(fibonacci);

        // Assert 
        Assert.That(result, Is.EqualTo(expected));
    }
}