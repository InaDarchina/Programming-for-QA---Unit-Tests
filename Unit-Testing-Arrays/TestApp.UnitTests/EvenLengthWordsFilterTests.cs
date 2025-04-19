using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        //Arrange
        string[] inputArray = Array.Empty<string>();
        string expected = string.Empty;

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        //Arrange
        string[] inputArray = new string[] { "abc" };
        string expected = string.Empty;

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        //Arrange
        string[] inputArray = new string[] { "abc", "qrw", "abcde" };
        string expected = string.Empty;

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        //Arrange
        string[] inputArray = new string[] { "mama" };
        string expected = "mama";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        //Arrange
        string[] inputArray = new string[] { "abc", "mama", "batko", "tati" };
        string expected = "mama tati";

        //Act
        string result = EvenLengthWordsFilter.GetEvenWords(inputArray);


        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}

