using System;
using Core1;

namespace Homework3
{
    public class HW3
    {
        private Core _core;
        public HW3()
        {
            _core = new Core();
        }       
        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Возвести число A в степень B");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");
            double temp = a * 1.0;
            Console.WriteLine($"{RaiseNumberToPower(b, temp, a)}");
        }
        public double RaiseNumberToPower(int numberB, double temp, int numberA)
        {
            if (numberB > 0)
            {
                for (int index = 1; index < numberB; index++)
                {
                    temp = temp * numberA;

                }
                return temp;
            }
            else
            {
                for (int index = numberB; index <= 0; index++)
                {
                    temp = temp / numberA;

                }
                return temp;
            }
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Вывести все числа от 1 до 1000, которые делятся на A");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            Console.WriteLine($"{FindNumbersThatAreDivisibleByANumber(a)}");
        }
        public string FindNumbersThatAreDivisibleByANumber(int numberA)
        {
            int numberB = 0;
            string result = "";
            while (numberB > 0) ;
            {
                for (int index = 1; index <= 1000; index++)
                {
                    numberB = index % numberA;
                    if (numberB == 0)
                    {
                        result=$"{result} {index}";
                        
                    }                    
                }                
            }
            return result;
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Найте количество положительных целых чисел, квадрат которых меньше A");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            Console.WriteLine($"{CountNumbersWithSquareLessThanUserNumber(a)}");
        }
        public int CountNumbersWithSquareLessThanUserNumber(int numberA)
        {
            int result = 0;
            for (int index = 1; index >= 1; index++)
            {
                int possiblenumber = index * index;
                if (possiblenumber >= numberA)
                {
                    result = index - 1;
                    break;
                }
            }
            return result;
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Вывести наибольший делитель числа A");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            Console.WriteLine($"{FindLargestDivisor(a)}");
        }
        public int FindLargestDivisor(int numberA)
        {
            int numeric = numberA - 1;
            int result = 0;
            for (int index = numeric; index > 1; index--)
            {
                int possiblenumber = numberA % index;
                if (possiblenumber == 0)
                {
                    result = index;
                    break;
                }
            }
            return result;
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");            
            Console.WriteLine($"{CalcSumOfNumbersDivisibleBySeven(a, b)}");
        }
        public int CalcSumOfNumbersDivisibleBySeven(int numberA, int numberB)
        {
            if (numberA > numberB)
            {
                _core.SwapVariables(ref numberA, ref numberB);
            }
            int sum = 0;
            for (int i = numberA; i <= numberB; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public void SolveTask6()
        {
            Console.WriteLine("Задача 6");
            Console.WriteLine("Выведите N-ое число ряда фибоначчи");
            int a = _core.ConvertNumberFromUserInput("Введите положительное число N:");
            Console.WriteLine($"{FindFibonacci(a)}");
        }
        public int FindFibonacci(int numberA)
        {
            int prev = 1;
            int cur = 1;
            int fib = 0;
            for (int i = 2; i <= numberA; i++)
            {
                fib = cur + prev;
                prev = cur;
                cur = fib;
            }
            return fib;
        }
        public void SolveTask7()
        {
            Console.WriteLine("Задача 7");
            Console.WriteLine("Найти наибольший общий делитель двух чисел, используя алгоритм Евклида");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");           
            Console.WriteLine($"{FindLargestDivisorEuclideanAlgorithm(a, b)}");
        }
        public int FindLargestDivisorEuclideanAlgorithm(int numberA, int numberB)
        {
            if (numberA < numberB)
            {
                _core.SwapVariables(ref numberA, ref numberB);
            }
            int tmp = 0;
            do
            {
                tmp = numberA % numberB;
                numberA = numberB;
                numberB = tmp;
            }
            while (tmp != 0);
            return numberA;
        }
        public void SolveTask8()
        {
            Console.WriteLine("Задача 8");
            Console.WriteLine("Пользователь вводит целое положительное число, которое является кубом целого числа N. " +
                "Найдите число N методом половинного деления");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            Console.WriteLine($"{a} является кубом числа {FindCubByHalfDivision(a)}");
        }
        public int FindCubByHalfDivision(int numberA)
        {
            int possibleResult = 0;
            int range = numberA;
            int mid = 0;
            do
            {
                mid = range / 2;
                possibleResult = mid * mid * mid;
                range = mid;
            }
            while (possibleResult != numberA);
            return mid;
        }
        public void SolveTask9()
        {
            Console.WriteLine("Задача 9");
            Console.WriteLine("Найти количество нечетных цифр числа");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            Console.WriteLine($"{CountFindSummOfEvenNumbersInvalue(a)}");
        }
        public int CountFindSummOfEvenNumbersInvalue(int numberA)
        {
            int possibleResult = 0;
            int range = numberA;
            do
            {
                int temp = range % 10;
                range = range / 10;
                if (temp % 2 != 0)
                {
                    possibleResult += 1;
                }
            }
            while (range > 0);
            return possibleResult;
        }
        public void SolveTask10()
        {
            Console.WriteLine("Задача 10");
            Console.WriteLine("Найти зеркальное число");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            Console.WriteLine($"{FindMirrowNumber(a)}");
        }
        public int FindMirrowNumber(int numberA)
        {
            int result = 0;
            while (numberA > 0)
            {
                result = result * 10;
                result = result + (numberA % 10);
                numberA = numberA / 10;
            }
            return result;
        }
        public void SolveTask11()
        {
            Console.WriteLine("Задача 11");
            Console.WriteLine("Вывести числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных");
            int a = _core.ConvertNumberFromUserInput("Введите положительное число:");
            Console.WriteLine($"{FindSummOfEvenNumbersInvalue(a)}");
        }
        public string FindSummOfEvenNumbersInvalue(int numberA)
        {
            int sumchet = 0;
            int sumnechet = 0;
            string result = "";
            int tempA = 0;
            int tempB = 0;
            for (int i = 1; i <= numberA; i++)
            {
                tempA = i;
                while (tempA > 0)
                {
                    tempB = tempA % 10;
                    if (tempB % 2 == 0)
                    {
                        sumchet = sumchet + tempB;
                    }
                    else
                    {
                        sumnechet = sumnechet + tempA;
                    }
                    tempA = tempA / 10;
                }
                if (sumchet > sumnechet)
                {
                    result=$"{result} {i}";
                    sumchet = 0;
                    sumnechet = 0;
                }
                else
                {
                    sumchet = 0;
                    sumnechet = 0;
                }
            }
            return result;
        }
        public void SolveTask12()
        {
            Console.WriteLine("Задача 12");
            Console.WriteLine("Сообщить, есть ли в написании двух чисел одинаковые цифры");
            int a = _core.ConvertNumberFromUserInput("Введите число а:");
            int b = _core.ConvertNumberFromUserInput("Введите число b:");
            Console.WriteLine($"{FindSameNumbers(a, b)}"  );
        }
        public string FindSameNumbers(int numberA, int numberB)
        {
            int tmp = 0;
            string temp = "";
            int b = numberB;
            
            while (numberA > 0)
            {
                while (numberB > 0)
                {
                    if (numberA % 10 == numberB % 10)
                    {
                     tmp=tmp+1;
                    }
                    numberB = numberB / 10;
                }
                numberA = numberA / 10;
                numberB = b;
            }
            if (tmp > 0)
            {
                temp = "Да";
            }
            else
            {
                temp = "Нет";
            }
            return temp;
        }
    }
}

