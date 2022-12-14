using NUnit.Framework;
using HomeTask5;

namespace HomeTask5Tests
{
    class Task4Tests
    {

        [TestCase(new int[] {1,3,6,2,2,0,4,5 }, 5,4)]        
        [TestCase(new int[] {1,3,6,2,2,0,4,5,1 }, 5,5)]        
        [TestCase(new int[] { 1, 1, 3, 6, 2, 2, 0, 4, 5, 1, 1 }, 12,0)]        
        [TestCase(new int[] { 1, 1, 3, 6, 2, 2, 0, 4, 5, 1, 1 }, -10,0)]        
        [TestCase(new int[] { 1, 1, 3, 6, 2, 2, 0, 4, 5,0, 1, 1 }, 0,1)]        
        [TestCase(new int[] { 1, 1, 3, 6, 2, 2, 0, int.MaxValue, 5,0, 1, 1 }, 0,1)]        
        [TestCase(new int[] { 1, 1, 3, 6, 2, 2, 0, int.MaxValue, 5,0, 1, 1 }, int.MaxValue,2)]
        [TestCase(new int[] { 1, 3, 6, -2, 2, 0, -4, 5 }, 5,2)]
        [TestCase(new int[] { 1, 3, 6, -2, -2, 0, -4, 5 }, 2,1)]
        [TestCase(new int[] { 1, -3, 6, 2, 2, 0, 4, 5, 1 }, -3,1)]
        [TestCase(new int[] { 1, 1, 3, 6, 2, 2, 0, 4, 5, 1, -1 }, 0,3)]
        [TestCase(new int[] { 1, 1, int.MinValue, 3, 6, 2, 2, 0, 4, 5, 1, 1 }, 0,0)]
        public void CntPairsWithSumOfTarget_Should_ReturnNumOfPairsWhichSumsToTarget_When_InvokedWithInts(int[] inputArr ,int target, int expected)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            int result = TestTasks.Task4_CntPairsWithSumOfTarget(inputArr,target);
            //Assert
            Assert.AreEqual(expected, result);
        }                      
        //null
        [TestCase(5)]        
        [TestCase(int.MinValue)]        
        [TestCase(12)]        
        [TestCase(-10)]        
        public void CntPairsWithSumOfTarget_Should_ReturnZero_When_InvokedWithNull(int target)
        {
            //Arrange
            Tasks TestTasks = new Tasks();
            //Act
            int result = TestTasks.Task4_CntPairsWithSumOfTarget(null,target);
            //Assert
            Assert.AreEqual(0, result);
        }

    }
}
