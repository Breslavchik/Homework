using NUnit.Framework;

namespace Homework4.Tests
{
    public class HW4Tests
    {
        private HW4 _hw4;
        [SetUp]
        public void Setup()
        {
            _hw4 = new HW4();
        }

        [TestCase(new int[] { 56, 89, 1 }, 1)]
        [TestCase(new int[] { 0, 23, -5 }, -5)]
        public void FindMinElementOfArrayTest(int[] array, int expected)
        {
            //arrange          
            //act
            int actual = _hw4.FindMinElementOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1 }, 89)]
        [TestCase(new int[] { 0, 23, -5 }, 23)]
        public void FindMaxElementOfArrayTest(int[] array, int expected)
        {
            //arrange          
            //act
            int actual = _hw4.FindMaxElementOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1 }, 2)]
        [TestCase(new int[] { 0, 23, 5 }, 0)]
        public void FindIndexOfMinElementOfArrayTest(int[] array, int expected)
        {
            //arrange          
            //act
            int actual = _hw4.FindIndexOfMinElementOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1 }, 1)]
        [TestCase(new int[] { 0, 23, 555 }, 2)]
        public void FindIndexOfMaxElementOfArrayTest(int[] array, int expected)
        {
            //arrange          
            //act
            int actual = _hw4.FindIndexOfMaxElementOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1, 5, 3 }, 94)]
        [TestCase(new int[] { 0, 23, 5 }, 23)]
        public void SumElementsOfOddIndexTest(int[] array, int expected)
        {
            //arrange          
            //act
            int actual = _hw4.SumElementsOfOddIndex(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1, 5, 3 }, new int[]{3, 5, 1, 89, 56})]
        [TestCase(new int[] { 0, 23, 5, 7, 14, 45 }, new int[] {45, 14, 7, 5, 23, 0 })]
        public void ReverseArrayTest(int[] array, int[] expected)
        {
            //arrange          
            //act
            int[] actual = _hw4.ReverseArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1, 5, 3 }, 4)]
        [TestCase(new int[] { 0, 23, 5, 7, 14, 45 },4)]
        public void SumOfOddNumbersOfArrayTest(int[] array, int expected)
        {
            //arrange          
            //act
            int actual = _hw4.SumOfOddNumbersOfArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1, 5, 3 }, new int[] {5, 3, 1, 56, 89 })]
        [TestCase(new int[] { 0, 23, 5, 7, 14, 45 }, new int[] {7,14, 45, 0, 23, 5})]
        public void SwapHalvesOfAnArrayTest(int[] array, int[] expected)
        {
            //arrange          
            //act
            int[] actual = _hw4.SwapHalvesOfAnArray(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1, 5, 3 }, new int[] { 1,3,5,56,89})]
        [TestCase(new int[] { 0, 23, 5, 7, 14, 45 }, new int[] { 0,5,7,14,23,45 })]
        public void DoBubbleSortTest(int[] array, int[] expected)
        {
            //arrange          
            //act
            int[] actual = _hw4.DoBubbleSort(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 56, 89, 1, 5, 3 }, new int[] { 89,56,5,3,1 })]
        [TestCase(new int[] { 0, 23, 5, 7, 14, 45 }, new int[] { 45,23,14,7,5,0 })]
        public void DoSelectSortTest(int[] array, int[] expected)
        {
            //arrange          
            //act
            int[] actual = _hw4.DoSelectSort(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}