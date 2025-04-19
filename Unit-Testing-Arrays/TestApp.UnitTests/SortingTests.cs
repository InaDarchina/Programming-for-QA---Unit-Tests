using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        //Arrange
        double[] inputArray = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        //Act
        double[] actual = Sorting.ShallowAscendingSort(inputArray);

        //Assert

        Assert.That(actual, Is.EqualTo(expected)); //CollectionAssert.AreEqual(actual, expected);
    }    
     
    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        //Arrange
        double[] inputArray = Array.Empty<double>();
        double[] expected = Array.Empty<double>();

        //Act
        double[] actual = Sorting.DeepAscendingSort(inputArray);

        //Assert

        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        //Arrange
        double[] inputArray = new double[] { 3, 1, 2 };
        double[] expected = new double[] { 1, 2, 3 };
        //Act
        double[] actual = Sorting.ShallowAscendingSort(inputArray);

        //Assert

        CollectionAssert.AreEqual(actual, expected);
        CollectionAssert.AreNotEqual(actual, inputArray);
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        //Arrange
        double[] inputArray = new double[] { 3, 1, 2 };
        double[] expected = new double[] { 1, 2, 3 };
        //Act
        double[] actual = Sorting.DeepAscendingSort(inputArray);

        //Assert

        CollectionAssert.AreEqual(actual, expected);
        CollectionAssert.AreEqual(actual, inputArray);

    }
}
