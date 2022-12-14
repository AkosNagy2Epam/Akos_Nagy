using NUnit.Framework;
using System.Collections.Generic;
using HomeTask5;

namespace HomeTask5Tests
{
    public class Task1Tests
    {      

        [TestCase( new int[] { 1, 2 }, new object[] { 1, 2, "a", "b" })]
        [TestCase( new int[] { 1, 2, 0, 15 } , new object[] { 1, 2, "a", "b", 0, 15 })]
        [TestCase( new int[] { 1, 2, 231 }, new object[] { 1, 2, "a", "b", "aasf", "1", "123", 231 })]
        [TestCase( new int[] { 1, 2, 15 }, new object[] { 1, 2, "a", "", "0", 15 })]
        [TestCase( new int[] {  }, new object[] { })]
        public void GetIntegersFromList_Should_ReturnInputListWithStringsFilteredOut_When_InvokedWithObjectsOfNonNegativeIntegersAndOrStrings(int[] expected, object[] input)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            List<int> result = TestTasks.GetIntegersFromList(new List<object>(input));
            //Assert
            CollectionAssert.AreEquivalent( new List<int>(expected), result);
        }

        [TestCase( new object[] { 1, -2, "a", "b" })]
        [TestCase( new object[] { -1, 2, "a", "b", -0, -15 })]
        [TestCase( new object[] { 1, 2, 'a', 'b', "aasf", '1', "123", -231 })]
        [TestCase( new object[] { 1, 2, 'a', 'b', '0', int.MinValue })]        
        public void GetIntegersFromList_Should_ReturnNull_When_InvokedWithObjectsOfNegativeIntegers(object[] input)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            List<int> result = TestTasks.GetIntegersFromList(new List<object>(input));
            //Assert
            Assert.IsNull(result);
        }

        [TestCase( new object[] { 1, 2, 'a', "b" })]
        [TestCase( new object[] { 1, 2, null, "b", -0, -15 })]
        [TestCase( new object[] { 1, 2, 'a', 'b', "aasf", '1', "123", 231.0 })]
        [TestCase( new object[] { 1, 2, 'a', 'b', '0', 3.5 })]
        public void GetIntegersFromList_Should_ReturnNull_When_InvokedWithObjectsOtherThanIntOrString(object[] input)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            List<int> result = TestTasks.GetIntegersFromList(new List<object>(input));
            //Assert
            Assert.IsNull(result);
        }        

        [Test]
        public void GetIntegersFromList_Should_ReturnNull_When_InvokedWithNull()
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            List<int> result = TestTasks.GetIntegersFromList(null);
            //Assert
            Assert.IsNull(result);
        }
        
    }
}