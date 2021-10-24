using System;
using Core1;

namespace Homework4
{
    public class HW4
    {
        private Core _core;
        public HW4()
        {
            _core = new Core();
        }
        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Найти минимальный элемент массива");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            Console.WriteLine($"\nМинимальный элемент массива:{FindMinElementOfArray(array)}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Найти максимальный элемент массива");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            Console.WriteLine($"\nМаксимальный элемент массива:{FindMaxElementOfArray(array)}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Найти индекс минимального элемента массива");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            Console.WriteLine($"\nИндекс минимального элемента массива:{FindIndexOfMinElementOfArray(array)}");
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Найти индекс максимального элемента массива");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            Console.WriteLine($"\nИндекс максимального элемента массива:{FindIndexOfMaxElementOfArray(array)}");
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Посчитать сумму элементов массива с нечетными индексами");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            Console.WriteLine($"\nСумма элементов с нечетными индексами: {SumElementsOfOddIndex(array)}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Задача 6");
            Console.WriteLine("Сделать реверс массива");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            array=ReverseArray(array);
            Console.WriteLine();
            PrintArray(array);
        }
        public void SolveTask7()
        {
            Console.WriteLine("Задача 7");
            Console.WriteLine("Посчитать количество нечетных элементов массива");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            Console.WriteLine($"\nКоличество нечетных элементов массива:{SumOfOddNumbersOfArray(array)}");
        }
        public void SolveTask8()
        {
            Console.WriteLine("Задача 8");
            Console.WriteLine("Поменять местами первую и вторую половину массива");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            array=SwapHalvesOfAnArray(array);
            Console.WriteLine();
            PrintArray(array);
        }
            public void SolveTask9()
        {
            Console.WriteLine("Задача 9");
            Console.WriteLine("Отсортировать массив по возрастанию");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            array=DoBubbleSort(array);
            Console.WriteLine();
            PrintArray(array);
        }
        public void SolveTask10()
        {
            Console.WriteLine("Задача 10");
            Console.WriteLine("Отсортировать массив по убыванию");
            int length = _core.ConvertNumberFromUserInput("Введите длину массива");
            int[] array = FillArrayRandom(length);
            PrintArray(array);
            array=DoSelectSort(array);
            Console.WriteLine();
            PrintArray(array);
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
        public int FindMinElementOfArray(int[] array)
        {
            int min = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }
            return min;
        }
        public void PrintArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]}\t");
            }
        }
        public int FindMaxElementOfArray(int[] array)
        {
            int max = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }
            return max;
        }
        public int FindIndexOfMinElementOfArray(int[] array)
        {
            int min = array[0];
            int temp = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                    temp = index;
                }
            }
            return temp;
        }
        public int FindIndexOfMaxElementOfArray(int[] array)
        {
            int max = array[0];
            int temp = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                    temp = index;
                }
            }
            return temp;
        }
        public int SumElementsOfOddIndex(int[] array)
        {
            int sum = 0;
            for (int index = 1; index < array.Length; index += 2)
            {
                sum += array[index];
            }
            return sum;
        }
        public int[] ReverseArray(int[] array)
        {
            int half = array.Length / 2;
            for (int index = 0; index < half; index++)
            {
                _core.SwapVariables(ref array[index], ref array[array.Length - 1 - index]);                
            }
            return array;
        }
        public int[] SwapHalvesOfAnArray(int[] array)
        {
            int tmp = array.Length / 2;
            for (int i = 0; i < tmp; i++)
            {
                _core.SwapVariables(ref array[i], ref array[i + array.Length - tmp]);               
            }
            return array;
        }
        public int SumOfOddNumbersOfArray(int[] array)
        {
            int sum = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] % 2 != 0)
                {
                    sum++;
                }
            }
            return sum;
        }
        public int[] DoBubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        _core.SwapVariables(ref array[j], ref array[i]);                       
                    }
                }
            }
            return array;
        }
        public int[] DoSelectSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int temp = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[temp])
                    {
                        temp = j;
                    }
                }
                _core.SwapVariables(ref array[temp], ref array[i]);                
            }
            return array;
        }
    }
}
