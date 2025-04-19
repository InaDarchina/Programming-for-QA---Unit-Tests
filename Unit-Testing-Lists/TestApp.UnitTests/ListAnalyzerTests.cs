using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        // Arrange
        List<int> emptyList = new();
        string expected = "No elements!";

        // Act
        string result = ListAnalyzer.Analyze(emptyList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        List<int> oneElementList = new() { 56 };
        string expected = "Element count: 1, Min value: 56, Max value: 56, Avg: 56.00.";

        // Act
        string result = ListAnalyzer.Analyze(oneElementList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        List<int> inputList = new() { 2, 2, 2, 2 };
        string expected = "Element count: 4, Min value: 2, Max value: 2, Avg: 2.00.";

        // Act
        string result = ListAnalyzer.Analyze(inputList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        List<int> inputList = new() { 2, 3, 6, 8 };
        string expected = "Element count: 4, Min value: 2, Max value: 8, Avg: 4.75.";

        // Act
        string result = ListAnalyzer.Analyze(inputList);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
