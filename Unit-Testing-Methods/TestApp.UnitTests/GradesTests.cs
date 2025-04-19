using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [TestCase(2.50, "Fail")]
    [TestCase(2.80, "Fail")]
    [TestCase(3.20, "Average")]
    [TestCase(3.40, "Average")]
    [TestCase(3.60, "Good")]
    [TestCase(4.20, "Good")]
    [TestCase(5.70, "Excellent")]
    [TestCase(5.90, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
    [TestCase(1.00, "Invalid!")]
    [TestCase(1.99, "Invalid!")]
    [TestCase(2.00, "Fail")]
    [TestCase(3.00, "Average")]
    [TestCase(4.99, "Very Good")]
    [TestCase(5.59, "Excellent")]
    [TestCase(6.00, "Excellent")]
    [TestCase(6.01, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
