using NUnit.Framework;
using HomeTask5;

namespace HomeTask5Tests
{
    class Task3Tests
    {
        [TestCase(16,7)]
        [TestCase(942,6)]
        [TestCase(132189,6)]
        [TestCase(493193,2)]        
        [TestCase(5,5)]        
        [TestCase(0,0)]        
        public void DigitalRoot_Should_ReturnRecursiveSumOfInputDigits_When_InvokedWithNonNegativeInt(int input, int expected)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            int result = TestTasks.Digital_Root(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(-16)]
        [TestCase(-942)]
        [TestCase(-132189)]
        [TestCase(-493193)]        
        [TestCase(-5)]        
        [TestCase(int.MinValue)]        
        public void DigitalRoot_Should_ReturnMinus1_When_InvokedWithNegativeInt(int input)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            int result = TestTasks.Digital_Root(input);
            //Assert
            Assert.AreEqual(-1, result);
        }


    }
}
