using NUnit.Framework;
using HomeTask5;

namespace HomeTask5Tests
{
    class Task5Tests
    {

        [TestCase(  "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill",
                    "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        [TestCase("Fired:;:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill",
                    "(, FIRED)(CORWILL, )(CORWILL, ALFRED)(CORWILL, RAPHAEL)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")] 
        [TestCase(":Cor;:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;George:",
                    "(, GEORGE)(COR, )(CORWILL, )(CORWILL, RAPHAEL)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)")]
        [TestCase("Ab:Kacsa;1:Kacsa","(KACSA, 1)(KACSA, AB)")]
        [TestCase("Ab:Kacsa  ;1:Kacsa","(KACSA, 1)(KACSA  , AB)")]
        [TestCase(":;:","(, )(, )")]        
        public void Meeting_Should_ReturnNamesInCorrectOrderAndFormat_When_InvokedWithStringContainingFullNamesWithColonSeparatedBySemiColon(string input,string expected)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.Meeting(input);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(":;;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;:")]
        [TestCase("::;;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;:")] 
        [TestCase(":Cor;:Corwill;Barney:TornBull;Bet:ty:Tornbull;Bjon:Tornbull;Raphael:Corwill;George:")]     
        [TestCase(" ")]     
        public void Meeting_Should_ReturnNull_When_InvokedWithStringContainingImproperNameSeparation(string input)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.Meeting(input);
            //Assert
            Assert.IsNull(result);
        }
        
        [Test]     
        public void Meeting_Should_ReturnNull_When_InvokedWithEmptyString()
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.Meeting("");
            //Assert
            Assert.IsNull(result);
        }

        [Test]     
        public void Meeting_Should_ReturnNull_When_InvokedWithNull()
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            string result = TestTasks.Meeting(null);
            //Assert
            Assert.IsNull(result);
        }


    }
}
