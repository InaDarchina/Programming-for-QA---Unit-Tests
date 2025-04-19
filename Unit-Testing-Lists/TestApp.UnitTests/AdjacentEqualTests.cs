using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);
        // Assert
        Assert.That(result, Is.EqualTo(emptyList)); //Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 1, 2, 2, 4, 4, 5 };
        string expected = "1 4 8 5";
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("1 4 8 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> numbers = new List<int>() { 4, 4, 4, 4 };
        string expected = "16";
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("16"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 4, 4, 5, 7, 9, 34, 78 };
        string expected = "8 5 7 9 34 78";
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("8 5 7 9 34 78"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 5, 7, 9, 34, 34 };
        string expected = "2 4 5 7 9 68";
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("2 4 5 7 9 68"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int>() { 2, 4, 5, 7, 7, 34, 9 };
        string expected = "2 4 5 14 34 9";
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
