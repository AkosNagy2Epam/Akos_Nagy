using NUnit.Framework;
using HomeTask5;

namespace HomeTask5Tests
{
    class Task2Tests
    {

        [TestCase("sTreSS", "T")]
        [TestCase("sTreSSst", "r")]
        [TestCase("eEeSSt", "t")]
        [TestCase("s321TreSS", "3")]        
        [TestCase("EEA ea", " ")]        
        [TestCase(" ", " ")]        
        public void FirstNonRepeatingLetter_Should_ReturnFisrtNonRepeatingLetterWithCorrectCase_When_InvokedWithStringContainingNonRepeatingChar(string input, string expected)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.First_Non_Repeating_Letter(input);
            //Assert
            Assert.AreEqual(expected, result);
        }
        //minden ismétlődik
        [TestCase("SS")]
        [TestCase("sSsSSSss")]
        [TestCase("ttEEss")]
        [TestCase("err  e")]        
        public void FirstNonRepeatingLetter_Should_ReturnEmptyString_When_InputHasOnlyRepeatingChars(string input)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.First_Non_Repeating_Letter(input);
            //Assert
            Assert.AreEqual("", result);
        }
        //empty string         
        [Test]        
        public void FirstNonRepeatingLetter_Should_ReturnEmptyString_When_InvokedWithEmptyString()
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.First_Non_Repeating_Letter("");
            //Assert
            Assert.AreEqual("", result);
        }
        //null
        [Test]        
        public void First_Non_Repeating_Letter_Should_ReturnNull_When_InvokedWithNull()
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.First_Non_Repeating_Letter(null);
            //Assert
            Assert.AreEqual("", result);
        }

       

       

       
    }
}
