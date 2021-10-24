using NUnit.Framework;

namespace Homework2.Tests
{
    public class HW2Tests
    {
        private HW2 _hw2;
        [SetUp]
        public void Setup()
        {
            _hw2 = new HW2();
        }

        [TestCase(10, 6, 16)]
        [TestCase(6, 6, 36)]
        [TestCase(6, 7, -1)]
        public void CalculationOfOptionsOfResultTest(int a, int b, int expected)
        {
            //arrange          
            //act
            int actual = _hw2.CalculationOfOptionsOfResult(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(6, 7, 1)]
        [TestCase(6, -7, 4)]
        [TestCase(-6, 7, 2)]
        [TestCase(-6, -7, 3)]
        [TestCase(0, 7, 0)]
        public void FindCoordinateQuarterTest(int a, int b, int expected)
        {
            //arrange          
            //act
            int actual = _hw2.FindCoordinateQuarter(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestCase(0, "Точка лежит на оси координат")]
        [TestCase(1, "Первая четверть")]
        public void TranslateNumberToWordTest(int a, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw2.TranslateNumberToWord(a);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }
       
        [TestCase(15, 16, 20, "15 16 20")]
        [TestCase(0, 35, 20, "0 20 35")]
        public void ArrangeNumbersInAscendingOrderTest(int a, int b, int c, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw2.ArrangeNumbersInAscendingOrder(a, b, c);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }
       
        [TestCase(2, 1, 1, new double[1] {-0.25 })]
        [TestCase(5, 2, 3, new double[2] {-0.1, -0.3 })]
        public void FindResultsOfQuadraticTest(double a, double b, double c, double[] expected)
        {
            //arrange          
            //act
            double[] actual = _hw2.FindResultsOfQuadratic(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(new double[2] { -0.1, 0.0 }, "x1 = -0,1, x2=0")]
        [TestCase(new double[] { }, "Нет значений")]
        public void PrintResultsOfQuadraticTest(double[] array, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw2.PrintResultsOfQuadratic(array);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }
        
        [TestCase(15, "пятнадцать")]
        [TestCase(0, "Неподходящее число")]
        [TestCase(21, "двадцать один")]
        public void TransformNumberToWordTest(int a, string expectedMessage)
        {
            //arrange          
            //act
            string actual = _hw2.TransformNumberToWord(a);
            //assert
            Assert.AreEqual(expectedMessage, actual);
        }
    }
}