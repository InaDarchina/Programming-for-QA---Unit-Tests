using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        //Arrange
        List<int> first = new();
        List<int> second = new() { 5, 8, 12, 5, 7, 32 };
        List<int> expected = new();

        //Act
        List<int> actual = SameValues.FindSameValues(first, second);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        //Arrange
        List<int> first = new() { 34, 18, 18, 39, 28, 5, 6 };
        List<int> second = new();
        List<int> expected = new();

        //Act
        List<int> actual = SameValues.FindSameValues(first, second);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        //Arrange
        List<int> first = new() { 34, 18, 18, 39, 28, 5, 6 };
        List<int> second = new() { 1, 3, 12, 22, 23, 4, 8};
        List<int> expected = new();

        //Act
        List<int> actual = SameValues.FindSameValues(first, second);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        //Arrange
        List<int> first = new() { 3, 6, 8, 12, 34, 65, 79 };
        List<int> second = new() { 3, 6, 8, 12, 34, 65, 79 };
        List<int> expected = new() { 3, 6, 8, 12, 34, 65, 79 };

        //Act
        List<int> actual = SameValues.FindSameValues(first, second);

        //Assert 
        Assert.That(actual, Is.EqualTo(expected));
    }
}
