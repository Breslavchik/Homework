using NUnit.Framework;

namespace Homework3.Tests
{
    public class HW3Tests
    {
        private HW3 _hw3;
        [SetUp]
        public void Setup()
        {
            _hw3 = new HW3();
        }

        [TestCase(2, 5, 32.0)]
        [TestCase(-5, 3, -125.0)]
        [TestCase(3, -3, 0.04)]
        public void RaiseNumberToPowerTest(int a, int b, double expected)
        {
            //arrange          
            //act
            double actual = _hw3.RaiseNumberToPower(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(250, " 250 500 750 1000")]
        public void FindNumbersThatAreDivisibleByANumberTest(int a, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw3.FindNumbersThatAreDivisibleByANumber(a);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }

        [TestCase(5, 2)]
        public void CountNumbersWithSquareLessThanUserNumberTest(int a, int expected)
        {
            //arrange          
            //act
            int actual = _hw3.CountNumbersWithSquareLessThanUserNumber(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 1)]
        [TestCase(60, 30)]
        public void FindLargestDivisorTest(int a, int expected)
        {
            //arrange          
            //act
            int actual = _hw3.FindLargestDivisor(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 40, 98)]
        public void CalcSumOfNumbersDivisibleBySevenTest(int a, int b,int expected)
        {
            //arrange          
            //act
            int actual = _hw3.CalcSumOfNumbersDivisibleBySeven(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 13)]
        public void FindFibonacciTest(int a, int expected)
        {
            //arrange          
            //act
            int actual = _hw3.FindFibonacci(a);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(25, 60, 5)]
        public void FindLargestDivisorEuclideanAlgorithmTest(int a, int b, int expected)
        {
            //arrange          
            //act
            int actual = _hw3.FindLargestDivisorEuclideanAlgorithm(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(25, 0)]
        [TestCase(27, 3)]
        public void FindCubByHalfDivisionTest(int a, int expected)
        {
            //arrange          
            //act
            int actual = _hw3.FindCubByHalfDivision(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(25, 1)]
        [TestCase(46, 0)]
        public void CountFindSummOfEvenNumbersInvalueTest(int a, int expected)
        {
            //arrange          
            //act
            int actual = _hw3.CountFindSummOfEvenNumbersInvalue(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(46, 64)]
        public void FindMirrowNumberTest(int a, int expected)
        {
            //arrange          
            //act
            int actual = _hw3.FindMirrowNumber(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(11, " 2 4 6 8")]
        public void FindSummOfEvenNumbersInvalueTest(int a, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw3.FindSummOfEvenNumbersInvalue(a);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }

        [TestCase(11, 101, "Да")]
        [TestCase(1178, 22, "Нет")]
        [TestCase(0, 22, "Нет")]
        [TestCase(11078, 10, "Да")]
        public void FindSameNumbersTest(int a, int b, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw3.FindSameNumbers(a, b);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }
    }
}