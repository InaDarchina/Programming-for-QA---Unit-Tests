using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
      //Arrange

      List<int> numbers = new();

      //Act
      List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

      //Assert
      Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        //Arrange

        List<int> numbers = new() { -2, -5, -23, -7, -14 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        //Arrange

        List<int> numbers = new() { 5 };
        List<int> expected = new() { 5 }; 

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        List<int> numbers = new() { 5, 8, 78, 23, 96, 4 };
        List<int> expected = new() { 4, 96, 23, 78, 8, 5 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        List<int> numbers = new() { 32, -3, -4, 2, 18, 28, -2, -76 };
        List<int> expected = new() { 28, 18, 2, 32 };

        //Act
        List<int> result = ListManipulation.RemoveNegativesAndReverse(numbers);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
