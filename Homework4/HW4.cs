using System;

namespace Homework4
{
    public class HW4
    {

        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Найти минимальный элемент массива");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            Console.WriteLine($"\nМинимальный элемент массива:{FindMinElementOfArray(length, array)}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Найти максимальный элемент массива");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            Console.WriteLine($"\nМаксимальный элемент массива:{FindMaxElementOfArray(length, array)}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Найти индекс минимального элемента массива");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            Console.WriteLine($"\nИндекс минимального элемента массива:{FindIndexOfMinElementOfArray(length, array)}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Найти индекс максимального элемента массива");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            Console.WriteLine($"\nИндекс максимального элемента массива:{FindIndexOfMaxElementOfArray(length, array)}");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Посчитать сумму элементов массива с нечетными индексами");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            Console.WriteLine($"\nСумма элементов с нечетными индексами: {SumElementsOfOddIndex(length, array)}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Задача 6");
            Console.WriteLine("Сделать реверс массива");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            array = ReversArray(length, array);
            Console.WriteLine();
            OutputArray(array, length);
        }
        public void SolveTask7()
        {
            Console.WriteLine("Задача 7");
            Console.WriteLine("Посчитать количество нечетных элементов массива");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            Console.WriteLine($"\nКоличество нечетныхэлементов массива:{SumOfOddNumbersOfArray(length, array)}");
        }
        public void SolveTask8()
        {
            Console.WriteLine("Задача 8");
            Console.WriteLine("Поменять местами первую и вторую половину массива");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            array = ChangeHfsOfArray(length, array);
            Console.WriteLine();
            OutputArray(array, length);
        }
        public void SolveTask9()
        {
            Console.WriteLine("Задача 9");
            Console.WriteLine("Отсортировать массив по возрастанию");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            array = SortingBubble(length, array);
            Console.WriteLine();
            OutputArray(array, length);
        }
        public void SolveTask10()
        {
            Console.WriteLine("Задача 10");
            Console.WriteLine("Отсортировать массив по убыванию");
            int length = UserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            OutputArray(array, length);
            array = SortingSelect(length, array);
            Console.WriteLine();
            OutputArray(array, length);
        }
            public int UserInput(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int[] FillArrayRandom(int length)
        {
            int[] array = new int[length];
            Random rnd = new Random();
            for (int index = 0; index < length; index++)
            {
                array[index] = rnd.Next(0, 89);
            }
            return array;
        }
        public int FindMinElementOfArray(int length, int[] array)
        {
            int min = array[0];
            for (int index = 0; index < length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }
            return min;
        }
        public void OutputArray(int[] array, int length)
        {
            for (int index = 0; index < length; index++)
            {
                Console.Write($"{array[index]}\t");
            }
        }
        public int FindMaxElementOfArray(int length, int[] array)
        {
            int max = array[0];
            for (int index = 0; index < length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }
            return max;
        }
        public int FindIndexOfMinElementOfArray(int length, int[] array)
        {
            int min = array[0];
            int temp = 0;
            for (int index = 0; index < length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                    temp = index;
                }
            }
            return temp;
        }
        public int FindIndexOfMaxElementOfArray(int length, int[] array)
        {
            int max = array[0];
            int temp = 0;
            for (int index = 0; index < length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                    temp = index;
                }
            }
            return temp;
        }
        public int SumElementsOfOddIndex(int length, int[] array)
        {
            int sum = 0;
            for (int index = 1; index < length; index += 2)
            {
                sum += array[index];
            }
            return sum;
        }
        public int[] ReversArray(int length, int[] array)
        {
            int half = length / 2;
            for (int index = 0; index < half; index++)
            {
                int t = array[index];
                array[index] = array[length - 1 - index];
                array[length - 1 - index] = t;
            }
            return array;
        }
        public int[] ChangeHfsOfArray(int length, int[] array)
        {
            int tmp = length / 2;
            for (int i = 0; i < tmp; i++)
            {
                int a = array[i];
                array[i] = array[i + length - tmp];
                array[i + length - tmp] = a;
            }
            return array;
        }
        public int SumOfOddNumbersOfArray(int length, int[] array)
        {
            int sum = 0;
            for (int index = 0; index < length; index++)
            {
                if (array[index] % 2 != 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        public int[] SortingBubble(int length, int[] array)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        public int[] SortingSelect(int length, int[] array)
        {
            for (int i = 0; i < length; i++)
            {
                int temp = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (array[j] > array[temp])
                    {
                        temp = j;
                    }
                }
                int temp2 = array[temp];
                array[temp] = array[i];
                array[i] = temp2;
            }
            return array;
        }
    }
}
