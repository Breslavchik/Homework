using System;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            int a = UserInput("Введите число а:");
            int b = UserInput("Введите число b:");
            double result = Calculate(a, b) / (b - a);
            Console.WriteLine($"Результат первой задачи {result}");
        }

        public int UserInput(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        int Calculate(int numberA, int numberB)
        {
            int result = (numberA * 5) + ((int)Math.Pow(numberB, 2));
            return result;
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            int a = UserInput("Введите число а:");
            int b = UserInput("Введите число b:");
            Console.WriteLine($"Результат второй задачи");
            Console.WriteLine($"переменная a:{SwapVariables(a, b)}; переменная B:{SwapVariables(b, a)}");
        }
        public int SwapVariables(int numberA, int numberB)
        {
            int temp = numberA;
            numberA = numberB;
            numberB = temp;
            return numberA;           
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            int a = UserInput("Введите число а:");
            int b = UserInput("Введите число b:");
            Console.WriteLine("Результат третьей задачи");
            int result = DivideResult(a, b);
            int remainder = DivideModulo(a, b);
            Console.WriteLine($"Результат деления: {result}, остаток от деления:{remainder} ");

        }
        public int DivideResult(int numberA, int numberB)
        {
            int result = numberA / numberB;
            return result;
        }
        public double DivideResult(double numberA, double numberB)
        {
            double result = numberA / numberB;
            return result;
        }
        public int DivideModulo(int numberA, int numberB)
        {
            int result = numberA % numberB;
            return result;
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Введите значения A,B,C, не равные 0");
            int a = UserInput("Введите число а:");
            int b = UserInput("Введите число b:");
            int c = UserInput("Введите число c:");
            Console.WriteLine("Результат четвертой задачи");
            Console.WriteLine("Уравнение A*X+B=C");                                                          
            double calculationresult = (c - b) * 1.0;
            double unknown = DivideResult(calculationresult, a );
            Console.WriteLine($"X = {unknown}");
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
            int firstX = UserInput("Введите x1:");
            int secondX = UserInput("Введите x2:");
            int firstY = UserInput("Введите y1:");
            int secondY = UserInput("Введите y2:");
            double k = DivideResult(SubtractTwoParams(firstY, secondY), (SubtractTwoParams(firstX, firstY) * 1.0));
            Console.WriteLine($"Коэффициент k={k}");
            double b = SubtractTwoParams(firstY, (k * secondX));
            Console.WriteLine($"Коэффициент b={b}");
            Console.WriteLine($"Уравнение прямой вида y={k}x+{b}");
        }
    } 
}
