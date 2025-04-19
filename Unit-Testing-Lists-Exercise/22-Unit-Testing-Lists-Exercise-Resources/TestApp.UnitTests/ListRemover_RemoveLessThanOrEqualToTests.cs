using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        //Arrange
        List<int> input = new();
        int treshold = 15;

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        //Assert 
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {

        //Arrange
        List<int> input = new() { 1, 3, 14, 15, 12, 3, 6, 10, 20 };
        int treshold = 20;
        List<int> expected = new();

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {

        //Arrange
        List<int> input = new() { 22, 34, 56, 123, 30, 50 };
        int treshold = 20;
        List<int> expected = new() { 22, 34, 56, 123, 30, 50 }; 

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));

    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        //Arrange
        List<int> input = new() { 22, 3, 5, 34, 56, 123, 18, 19, 20 };
        int treshold = 20;
        List<int> expected = new() { 22, 34, 56, 123 };

        //Act
        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(input, treshold);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }
}
