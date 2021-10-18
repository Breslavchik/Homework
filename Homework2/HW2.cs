using System;
using Core1;


namespace Homework2
{
    public class HW2
    {
        private Core _core;
        public HW2()
        {
            _core = new Core();
        }
        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, " +
                "подсчитать A*B, если A<B, подсчитать A-B.");
            int a =_core.ConvertNumberFromUserInput("Введите число а:");
            int b =_core.ConvertNumberFromUserInput("Введите число b:");
            int result = CalculationOfOptionsOfResult(a, b);
            Console.WriteLine(result);
        }
        public int CalculationOfOptionsOfResult(int numberA, int numberB)
        {
            int result = 0;
            if (numberA > numberB)
            {
               result = numberA+numberB;                
            }
            if (numberA == numberB)
            {
                 result = numberA * numberB;
            }
            if (numberA < numberB)
            {
                result = numberA - numberB;
            }
            return result;
        }        

        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Пользователь вводит 2 числа (X и Y). " +
                "Определить какой четверти принадлежит точка с координатами (X,Y).");
            int a =_core.ConvertNumberFromUserInput("Введите значение X:");
            int b =_core.ConvertNumberFromUserInput("Введите значение Y:");
            int result = FindCoordinateQuarter(a, b);
            Console.WriteLine($"{TranslateNumberToWord(result)}");
            
        }
        public int FindCoordinateQuarter(int numberA, int numberB)
        {
            int result = 0;
            if (numberA >= 0 && numberB >= 0)
            {
                result = 1;
            }
            else
            {
                if (numberA >= 0 && numberB <= 0)
                {
                    result = 4;                    
                }
                else
                {
                    if (numberA <= 0 && numberB <= 0)
                    {
                        result = 3; 
                    }
                    else { result = 2; }
                }
                if (numberA == 0 || numberB == 0)
                {
                    result = 0;
                }               
            }
            return result;
        }
        public string TranslateNumberToWord(int numberA)
        {
            string result = "";

            switch (numberA)
            {
                case 0:
                    result = "Точка лежит на оси координат";
                    break;
                case 1:
                    result = "Первая четверть";
                    break;
                case 2:
                    result = "Вторая четверть";
                    break;
                case 3:
                    result = "Третья четверть";
                    break;
                case 4:
                    result = "Четвертая четверть";
                    break;
            }
            return result;
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Пользователь вводит 3 числа (A, B и С). " +
                "Выведите их в консоль в порядке возрастания.");
            int a =_core.ConvertNumberFromUserInput("Введите число а:");
            int b =_core.ConvertNumberFromUserInput("Введите число b:");
            int c =_core.ConvertNumberFromUserInput("Введите число c:");
            string result = ArrangeNumbersInAscendingOrder(a, b, c);
            Console.WriteLine(result);
        }
        public string ArrangeNumbersInAscendingOrder(int numberA, int numberB, int numberC)
        {
            string result = "";
            if (numberA > numberB && numberB > numberC)
            {
                result=$"{numberC} {numberB} {numberA}";
            }
            else
            {
                if (numberA < numberB && numberB < numberC)
                {
                    result = $"{numberA}{numberB}{numberC}";
                }
                else
                {
                    if (numberA > numberB && numberB < numberC)
                    {
                        if (numberA > numberC) { result = $"{numberB} {numberC} {numberA}"; }
                        else { result = $"{numberB} {numberA} {numberC}"; }
                    }
                }
            }
            return result;
        }
       /* public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Выведите в консоль решение(значения X) квадратного уравнения");
            double a =_core.ConvertNumberFromUserInput("Введите число а:");
            double b =_core.ConvertNumberFromUserInput("Введите число b:");
            double c =_core.ConvertNumberFromUserInput("Введите число c:");
            double[] array = FindResultsOfQuadratic(a, b, c);
            Console.WriteLine($"{BlaBla(array)}");
        }

        public double[] FindResultsOfQuadratic(double numberA, double numberB, double numberC)
        {        
            double[] array = new double[0];
            double discriminant = ((int)Math.Pow(numberA, 2)) - (4 * numberB * numberC);
            if (discriminant < 0)
            {
                array = new double[] { };
                //Console.WriteLine("Нет значений");
            }
            if (discriminant == 0)
            {
                double result = -(numberB * numberB) / (2 * numberA);               
                array =new double[] { result };
                //Console.WriteLine($"x={result}");
            }
            if (discriminant > 0)
            {
                double result1 = (Math.Sqrt(discriminant) - numberB) / (2 * numberA) * 1.0;
                double result2 = (-numberB - Math.Sqrt(discriminant)) / (2 * numberA) * 1.0;
                array = new double[] { result1, result2 };
                //Console.WriteLine($"[x1={result1}, x2={result2}");
            }
            return array;
        }
        public string GiveHandsomeResult(double[] array)
        {
            string result = "";
            if (array { })
            {
                result = "Нет значений";
            }
            if (array == new double[1])
            {
                result = $"x = {array[0]}";
            }
            if (array == new double[2])
            {
                result = $"x1 = {array[0]}, x2={array[1]}";
            }
            return result;
        }*/
       

        public void SolveTask5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Выведите в консоль прописную запись числа, введенного пользователем");
            Console.WriteLine("Введите двузначное число от 10 до 99");
            int a =_core.ConvertNumberFromUserInput("Введите число:");
            string word=TransformNumberToWord(a);
            Console.WriteLine(word);
        }
        public string TransformNumberToWord(int numberA)
        {
            string result = "";
            if (numberA < 10 || numberA >= 100)
            {
                result="Неподходящее число";
            }
            switch (numberA)
            {
                case 10:
                    result="десять";
                    break;
                case 11:
                    result = "одиннадцать";
                    break;
                case 12:
                    result = "двенадцать";
                    break;
                case 13:
                    result = "тринадцать";
                    break;
                case 14:
                    result = "четырнадцать";
                    break;
                case 15:
                    result = "пятнадцать";
                    break;
                case 16:
                    result = "шестнадцать";
                    break;
                case 17:
                    result = "семнадцать";
                    break;
                case 18:
                    result = "восемнадцать";
                    break;
                case 19:
                    result = "девятнадцать";
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
                        result = "Неподходящее число";
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
                        result = "Неподходящее число";
                        break;
                }
                result = $"{temp} {temp2}";
            }
            return result;
        }
    }
}
            
            

                
                   

            
        
    
    
    


