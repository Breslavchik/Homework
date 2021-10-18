using System;


namespace Homework2
{
    public class HW2
    {
        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, " +
                "подсчитать A*B, если A<B, подсчитать A-B.");
            int a = UserInput("Введите число а:");
            int b = UserInput("Введите число b:");
            if (a > b)
            {
                int result = SumTwoParams(a, b);
                Console.WriteLine(result);
            }
            if (a == b)
            {
                int result = MultiplicationOfParams(a, b);
                Console.WriteLine(result);
            }
            if (a < b)
            {
                int result = SubtractTwoParams(a, b);
                Console.WriteLine(result);
            }
        }
        public int SubtractTwoParams(int numberA, int numberB)
        {
            int result = numberA - numberB;
            return result;
        }
        public int SumTwoParams(int numberA, int numberB)
        {
            int result = numberA + numberB;
            return result;
        }
        public int MultiplicationOfParams(int numberA, int numberB)
        {
            int result = numberA * numberB;
            return result;
        }
        public int UserInput(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Пользователь вводит 2 числа (X и Y). " +
                "Определить какой четверти принадлежит точка с координатами (X,Y).");
            int a = UserInput("Введите значение X:");
            int b = UserInput("Введите значение Y:");
            if (a >= 0 && b >= 0)
            {
                Console.WriteLine("Первая четверть");
                return;
            }
            else
            {
                if (a >= 0 && b <= 0)
                {
                    Console.WriteLine("IV четверть");
                    return;
                }
                else
                {
                    if (a <= 0 && b <= 0)
                    {
                        Console.WriteLine("III четверть");
                        return;
                    }
                    else { Console.WriteLine("II четверть"); return; }
                }

                if (a == 0 || b == 0)
                {
                    Console.WriteLine("Точка лежит на оси координат");
                    return;
                }
            }
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Пользователь вводит 3 числа (A, B и С). " +
                "Выведите их в консоль в порядке возрастания.");
            int a = UserInput("Введите число а:");
            int b = UserInput("Введите число b:");
            int c = UserInput("Введите число c:");
            if (a > b && b > c)
            {
                Console.WriteLine($"{c} {b} {a}");
            }
            else
            {
                if (a < b && b < c)
                {
                    Console.WriteLine($"{a}{b}{c}");
                }
                else
                {
                    if (a > b && b < c)
                    {
                        if (a > c) { Console.WriteLine($"{b} {c} {a}"); }
                        else { Console.WriteLine($"{b} {a} {c}"); }
                    }
                }
            }
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Выведите в консоль решение(значения X) квадратного уравнения");
            double a = UserInput("Введите число а:");
            double b = UserInput("Введите число b:");
            double c = UserInput("Введите число c:");
            FindResultsOfQuadratic(a, b, c);
        }

        public void FindResultsOfQuadratic(double numberA, double numberB, double numberC)
        {
            double discriminant = ((int)Math.Pow(numberA, 2)) - (4 * numberB * numberC);
            if (discriminant < 0)
            {
                Console.WriteLine("Нет значений");
            }
            if (discriminant == 0)
            {
                double result = -(numberB * numberB) / (2 * numberA);
                Console.WriteLine($"x={result}");
            }
            if (discriminant > 0)
            {
                double result1 = (Math.Sqrt(discriminant) - numberB) / (2 * numberA) * 1.0;
                double result2 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA) * 1.0;
                Console.WriteLine($"[x1={result1}, x2={result2}");
            }
        }
       

        public void SolveTask5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Выведите в консоль прописную запись числа, введенного пользователем");
            Console.WriteLine("Введите двузначное число от 10 до 99");
            int a = UserInput("Введите число:");
            TransformNumberToWord(a);
        }
        public void TransformNumberToWord(int numberA)
        {
            if (numberA < 10 || numberA >= 100)
            {
                Console.WriteLine("Неподходящее число");
            }
            switch (numberA)
            {
                case 10:
                    Console.WriteLine("десять");
                    break;
                case 11:
                    Console.WriteLine("одиннадцать");
                    break;
                case 12:
                    Console.WriteLine("двенадцать");
                    break;
                case 13:
                    Console.WriteLine("тринадцать");
                    break;
                case 14:
                    Console.WriteLine("четырнадцать");
                    break;
                case 15:
                    Console.WriteLine("пятнадцать");
                    break;
                case 16:
                    Console.WriteLine("шестнадцать");
                    break;
                case 17:
                    Console.WriteLine("семнадцать");
                    break;
                case 18:
                    Console.WriteLine("восемнадцать");
                    break;
                case 19:
                    Console.WriteLine("девятнадцать");
                    break;
            }
            if (numberA > 19)
            {
                int balance = numberA / 10;
                string temp = "";
                string temp2 = "";
                switch (balance)
                {
                    case 2:
                        temp = "двадцать";
                        break;
                    case 3:
                        temp = "тридцать";
                        break;
                    case 4:
                        temp = "сорок";
                        break;
                    case 5:
                        temp = "пятьдесят";
                        break;
                    case 6:
                        temp = "шестьдесят";
                        break;
                    case 7:
                        temp = "семьдесят";
                        break;
                    case 8:
                        temp = "восемьдесят";
                        break;
                    case 9:
                        temp = "девяносто";
                        break;
                    default:
                        Console.WriteLine("Неподходящее число");
                        break;
                }
                int balance2 = numberA % 10;
                switch (balance2)
                {
                    case 0:
                        temp2 = "";
                        break;
                    case 1:
                        temp2 = "один";
                        break;
                    case 2:
                        temp2 = "два";
                        break;
                    case 3:
                        temp2 = "три";
                        break;
                    case 4:
                        temp2 = "четыре";
                        break;
                    case 5:
                        temp2 = "пять";
                        break;
                    case 6:
                        temp2 = "шесть";
                        break;
                    case 7:
                        temp2 = "семь";
                        break;
                    case 8:
                        temp2 = "восемь";
                        break;
                    case 9:
                        temp2 = "девять";
                        break;
                    default:
                        Console.WriteLine("Неподходящее число");
                        break;
                }
                Console.WriteLine(temp + " " + temp2);
            }
        }
    }
}
            
            

                
                   

            
        
    
    
    


