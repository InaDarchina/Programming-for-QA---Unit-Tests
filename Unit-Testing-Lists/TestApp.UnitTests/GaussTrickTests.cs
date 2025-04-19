using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> inputList = new List<int>() { 1 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(inputList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputList = new List<int>() {1, 4, 3, 8 };
        List<int> expected = new List<int>() { 9, 7 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expected, result);

    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputList = new List<int>() { 2, 7, 9, 8, 10 };
        List<int> expected = new List<int>() { 12, 15, 9 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> inputList = new List<int>() { 1, 4, 3, 8, 7, 2, 14, 23, 9, 5 };
        List<int> expected = new List<int>() { 6, 13, 26, 22, 9 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> inputList = new List<int>() { 2, 7, 9, 8, 10, 11, 3, 1, 6 };
        List<int> expected = new List<int>() { 8, 8, 12, 19, 10 };

        // Act
        List<int> result = GaussTrick.SumPairs(inputList);

        // Assert
        CollectionAssert.AreEqual(expected, result);
    }
}
