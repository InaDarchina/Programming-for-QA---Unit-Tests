using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        //Arrange
        List<int> input= new();

        //Act
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(input);

        //Assert 
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        //Arrange
        List<int> input = new() { 23, 34, 27, 123, 345, 98};

        //Act
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(input);

        //Assert 
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> input = new() { 2, 5, 7, 9, 1, 3, };
        List<int> expected = new() { 2, 5, 7, 9, 1, 3 };

        //Act
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(input);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        //Arrange
        List<int> input = new() { 22, 11, 101, 999, 1001, 343 };
        List<int> expected = new() { 22, 11, 101, 999, 1001, 343 };

        //Act
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(input);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        //Arrange
        List<int> input = new() { 22, 34, 404, 45, 2002, 78 };
        List<int> expected = new() { 22, 404, 2002 };

        //Act
        PalindromeIntegers pi = new PalindromeIntegers();

        List<int> result = pi.FindPalindromes(input);

        //Assert 
        Assert.That(result, Is.EqualTo(expected));
    }
}
