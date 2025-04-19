using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] inputArray = new int[] {1};
        string expected = "1";
        // Act
        string result = Reverse.ReverseArray(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo("1"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 5, 34, 26, 12, 98, 123 };
        string expected = "123 98 12 26 34 5 1";
        // Act
        string result = Reverse.ReverseArray(inputArray);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
