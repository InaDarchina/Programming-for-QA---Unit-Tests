using NUnit.Framework;
using System.Net.Security;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        string result = string.Empty;
        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(result, actual);
    } 

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "H";
        string result = "H";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(result, actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        string input = "Hello";
        string result = "olleH";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(result, actual);
    }
}
