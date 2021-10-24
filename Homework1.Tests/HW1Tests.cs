using NUnit.Framework;

namespace Homework1.Tests
{
    public class HW1Tests
    {
       private HW1 _hw1;
        [SetUp]
        public void Setup()
        {
            _hw1 = new HW1();
        }

        [TestCase(6,8,47)]       
        public void CalculateTest(int a, int b, double expected)
        {
            //arrange          
            //act
            double actual = _hw1.Calculate(a, b);          
            //assert
            Assert.AreEqual(expected, actual);  
        }
        [TestCase(11,11)]
        public void CalculateNegativeTest(int a, int b)
        {
            //arrange
            //act, assert
            Assert.Throws(typeof(System.ArgumentException), () => _hw1.Calculate(a, b));
        }
       
        [TestCase(11, 11, 1)]
       public void FindResultOfDivideCalculateTest(int a, int b, double expected)
        {
            //arrange          
            //act
            int actual = _hw1.FindResultOfDivide(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(11.5, 10.0, 1.15)]
        public void FindResultOfDivideCalculateTest(double a, double b, double expected)
        {
            //arrange          
            //act
            double actual = _hw1.FindResultOfDivide(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(11, 11, 0)]
        public void FindRemainderOfDivideTest(int a, int b, int expected)
        {
            //arrange          
            //act
            int actual = _hw1.FindRemainderOfDivide(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(11, 11, 12, 0.09)]
        public void FindSolutionToLinearEquationTest(int a, int b, int c, double expected)
        {
            //arrange          
            //act
            double actual = _hw1.FindSolutionToLinearEquation(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(15, 16, 20, 3, "y=-0,33x+16,99")]
        public void DeriveEquationOfStraightLineTest(int a, int b, int c, int d, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw1.DeriveEquationOfStraightLine(a, b, c, d);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }
    }
}