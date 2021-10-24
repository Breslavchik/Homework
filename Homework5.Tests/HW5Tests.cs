using NUnit.Framework;

namespace Homework5.Tests
{
    public class HW5Tests
    {
        private HW5 _hw5;
        [SetUp]
        public void Setup()
        {
            _hw5 = new HW5();
        }

        [TestCase(0, 1)]
        [TestCase(1, -8)]
        public void FindMinElementOfArrayTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindMinElementOfArrayTest(index);
            //act
            int actual = _hw5.FindMinElementOfArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 0)]
        [TestCase(2, 43)]
        public void FindMaxElementOfArrayTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindMaxElementOfArrayTest(index);
            //act
            int actual = _hw5.FindMaxElementOfArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]       
        public void FindIndexOfMinElementOfArrayTest(int index)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindIndexOfMinElementOfArrayTest(index);
            int [] expected= TestData.GetExpectedArrayForFindIndexOfMinElementOfArrayTest(index);
            //act
            int[] actual = _hw5.FindIndexOfMinElementOfArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        public void FindIndexOfMaxElementOfArrayTest(int index)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFindIndexOfMinElementOfArrayTest(index);
            int[] expected = TestData.GetExpectedArrayForFindIndexOfMaxElementOfArrayTest(index);
            //act
            int[] actual = _hw5.FindIndexOfMaxElementOfArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0,2)]
        [TestCase(1,1)]
        public void CountElementsThatAreBiggerThanNeighborsTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForCountElementsThatAreBiggerThanNeighborsTest(index);           
            //act
            int  actual = _hw5.CountElementsThatAreBiggerThanNeighbors(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void DiagonalMirrowArrayTest(int index)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForDiagonalMirrowArrayTest(index);
            int[,] expected = TestData.GetExpectedArrayForDiagonalMirrowArrayTest(index);
            //act
            int[,] actual = _hw5.DiagonalMirrowArray(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}