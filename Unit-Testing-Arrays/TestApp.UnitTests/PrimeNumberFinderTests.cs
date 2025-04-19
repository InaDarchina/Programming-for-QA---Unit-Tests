using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 0 };
        int[] expected = Array.Empty<int>();


        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(numbers);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = new int[] { 12 };
        int[] expected = Array.Empty<int>();


        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(numbers);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = new int[] { 12, 4, 6, 10, 120, 300 };
        int[] expected = Array.Empty<int>();


        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(numbers);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        // Arrange
        int[] numbers = new int[] { 4, 3, 6, 8, 10 };
        int[] expected = { 3 };


        // Act
        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(numbers);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        // Arrange
        int[] numbers = new int[] { 3, 2, 4, 12, 7 };
        int[] expected = new int[] { 3, 2, 7 };


        // Act
        int[] actual = PrimeNumberFinder.GetAllPrimeNumbers(numbers);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
