using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string input = String.Empty;
        string expected = "Empty string";

        //Act
        string result = MiddleCharacters.GetMiddleChars(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
            
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        //Arrange
        string input = " ";
        string expected = "Empty string";

        //Act
        string result = MiddleCharacters.GetMiddleChars(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        //Arrange
        string input = "'I'";
        string expected = "I";

        //Act
        string result = MiddleCharacters.GetMiddleChars(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        //Arrange
        string input = "banana";
        string expected = "na";

        //Act
        string result = MiddleCharacters.GetMiddleChars(input);

        //Assert
        Assert.That(result, Is.EqualTo("na"));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        //Arrange
        string input = "Bye";
        string expected = "y";

        //Act
        string result = MiddleCharacters.GetMiddleChars(input);

        //Assert
        Assert.That(result, Is.EqualTo("y"));
    }
}

