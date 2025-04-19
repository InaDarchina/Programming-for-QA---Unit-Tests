using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";
        bool expected = true;

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.True);
    } 

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string invalidEmail = "test@";
        bool expected = false;

        // Act
        bool result = Email.IsValidEmail(invalidEmail);

        // Assert
        Assert.That(result, Is.False);
    }

    [TestCase(null)]
    [TestCase("")]
    public void Test_IsValidEmail_NullInput(string mail)
    {
        // Arrange
        

        // Act
        bool result = Email.IsValidEmail(mail);

        // Assert
        Assert.That(result, Is.False);
    }
}
