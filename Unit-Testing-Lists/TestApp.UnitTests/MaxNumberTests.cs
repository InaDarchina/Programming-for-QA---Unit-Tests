using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> inputList = new List<int>() { 23 };
        int expected = 23; 
        // Act
       int result = MaxNumber.FindMax(inputList);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    } 

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> inputList = new List<int>() { 1, 4, 24, 18, 32 };
        int expected = 32;
        // Act
        int result = MaxNumber.FindMax(inputList);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> inputList = new List<int>() { -1, -4, -24, -18, -32 };
        int expected = -1;
        // Act
        int result = MaxNumber.FindMax(inputList);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> inputList = new List<int>() { 1, -2, 16, -18, 34, -3, -26 };
        int expected = 34;
        // Act
        int result = MaxNumber.FindMax(inputList);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> inputList = new List<int>() { 1, 5, 123, 24, 123, 112 };
        int expected = 123;
        // Act
        int result = MaxNumber.FindMax(inputList);
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
