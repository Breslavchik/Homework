using System;
using Core1;

namespace Homework1
{
    public class HW1
    {
        private Core _core;
        
        public HW1()
        {
            _core = new Core();
        }
        
        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");
            double result = Calculate(a, b) / (b - a);
            Console.WriteLine($"Результат первой задачи {result}");
        }       
        int Calculate(int numberA, int numberB)
        {
            int result = (numberA * 5) + ((int)Math.Pow(numberB, 2));
            return result;
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");
            Console.WriteLine($"Результат второй задачи");
            _core.SwapVariables(ref a, ref b);
            Console.WriteLine($"переменная a:{a}; переменная B:{b}");
        }
       
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");
            Console.WriteLine("Результат третьей задачи");
            int result = FindResultOfDivide(a, b);
            int remainder = FindRemainderOfDivide(a, b);
            Console.WriteLine($"Результат деления: {result}, остаток от деления:{remainder} ");

        }
        public int FindResultOfDivide(int numberA, int numberB)
        {
            int result = numberA / numberB;
            return result;
        }
        public double FindResultOfDivide(double numberA, double numberB)
        {
            double result = numberA / numberB;
            return result;
        }
        public int FindRemainderOfDivide(int numberA, int numberB)
        {
            int result = numberA % numberB;
            return result;
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите значения A,B,C, не равные 0");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");
            int c = _core.ConvertNumberFromUserInput("Введите число c:");
            Console.WriteLine("Результат четвертой задачи");
            Console.WriteLine("Уравнение A*X+B=C");                                                          
            double calculationresult = (c - b) * 1.0;
            double x = FindResultOfDivide(calculationresult, a );
            Console.WriteLine($"X = {x}");
        }
        public int SubtractTwoParams(int numberA,int numberB)
        {
            int result = numberA - numberB;
            return result;
        }
        public double SubtractTwoParams(int numberA, double numberB)
        {
            double result = numberA - numberB;
            return result;
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Уравнение прямой по двум точкам");
            int firstX = _core.ConvertNumberFromUserInput("Введите x1:");
            int firstY = _core.ConvertNumberFromUserInput("Введите y1:");
            int secondY = _core.ConvertNumberFromUserInput("Введите y2:");
            int secondX = _core.ConvertNumberFromUserInput("Введите x2:");            
            Console.WriteLine($"{DeriveEquationOfStraightLine(firstX, firstY,secondY,secondX)}");
        }
        public string DeriveEquationOfStraightLine(int numberA, int numberB,int numberC, int numberD)
        {
            double k = (numberB - numberC) / (numberA - numberD);
            double b = numberB - (k * numberD);
            string result = $"y={k}x+{b}";
            return result;
        }

    } 
}
