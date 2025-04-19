using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [Test]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage()
    {
        //Arrange
        string inputNumber = "brum";
        string expected = "The input is not an integer!";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(inputNumber);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        //Arrange
        string inputNumber = "0";
        string expected = $"The number 0 is zero.";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(inputNumber);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger()
    {
        string inputNumber = "-19";
        string expected = $"The number -19 is negative.";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(inputNumber);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger()
    {
        string inputNumber = "23";
        string expected = $"The number 23 is positive.";

        //Act
        string result = SignOfIntegerNumbers.CheckSign(inputNumber);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
