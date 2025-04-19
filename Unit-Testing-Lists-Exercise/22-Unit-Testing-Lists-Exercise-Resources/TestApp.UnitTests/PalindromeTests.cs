using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange

        List<string> words = new List<string>() { "radar", "level", "mom" };
        

        // Act
       bool actual = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(actual);
    }

    // TODO: finish test
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();
        bool expected = true;

        // Act
        bool actual = Palindrome.IsPalindrome(words);


        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "level" };
        bool expected = true;

        // Act
        bool actual = Palindrome.IsPalindrome(words);


        // Assert
        Assert.IsTrue(actual);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> words = new() { "box" };
        bool expected = false;

        // Act
        bool actual = Palindrome.IsPalindrome(words);


        // Assert
        Assert.IsFalse(actual);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> words = new() { "MaDam" };
        bool expected = true;

        // Act
        bool actual = Palindrome.IsPalindrome(words);


        // Assert
        Assert.IsTrue(actual);
    }
}
