using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        //Arange
        List<int> input = new();
        int treshold = 5;

        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        //Assert 
        Assert.That(actual, Is.Empty);

    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        //Arrange
        List<int> input = new() { 6, 8, 12, 99, 123, 45};
        int treshold = 5;

        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        //Assert 
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        //Arrange
        List<int> input = new() { 23, 25, 18, 15, 7, 8, 10 };
        int treshold = 25;


        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        //Assert 
        Assert.That(actual, Is.EqualTo(input));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        //Arrange
        List<int> input = new() { 23, 1, 175, 15, 7, 45, 3, 26, 25, 123, 2 };
        int treshold = 25;
        List<int> expected = new() { 23, 1, 15, 7, 3, 25, 2 };


        //Act
        List<int> actual = ListRemover.RemoveElementsGreaterThan(input, treshold);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }
}
