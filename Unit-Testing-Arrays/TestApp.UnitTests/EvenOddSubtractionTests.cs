using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] inputArray = new int[] { 2, 4, 6 };
        int expected = 12;

        // Act
        int result = EvenOddSubtraction.FindDifference(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(12));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 5, 7};
        int expected = -13;

        // Act
        int result = EvenOddSubtraction.FindDifference(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(-13));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] inputArray = new int[] {2, 4, 6, 1, 5, 7};
        int expected = -1;

        // Act
        int result = EvenOddSubtraction.FindDifference(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }
}
