using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_Addition()
    {
        // Arrange
        Calculate calculator = new Calculate();
        int a = 5;
        int b = 2;
        int expected = 7;

        // Act
        int actual = calculator.Addition(a, b);

        // Assert
        Assert.AreEqual(expected, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_Subtraction()
    {
        // Arrange
        Calculate calculator = new Calculate();
        int a = 6;
        int b = 2;
        int expected = 4;

        // Act
        int actual = calculator.Subtraction(a, b);

        // Assert
        Assert.AreEqual(expected, actual, "Subtraction did not work properly.");
    }
}
