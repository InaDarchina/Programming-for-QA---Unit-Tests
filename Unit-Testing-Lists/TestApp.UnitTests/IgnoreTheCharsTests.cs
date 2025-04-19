using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        //Arrange
        string sentence = String.Empty;
        List<char> ignoredChars = new() { 'a', 'b' };

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.That(result, Is.EqualTo(sentence));
    }  

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        string sentence = "Waiting for the summer";
        List<char> ignoredChars = new();

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.That(result, Is.EqualTo(sentence));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        string sentence = "A";
        List<char> ignoredChars = new() { 'A' };
        string expected = String.Empty;

        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
       //Arrange
        string sentence = "Waiting for the summer";
        List<char> ignoredChars = new() { 'a', 'm', 'r'};
        string expected = "Witing fo the sue";


        //Act
        string result = IgnoreTheChars.IgnoreChars(sentence, ignoredChars);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
