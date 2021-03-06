using System;
using Core1;
namespace Homework5
{
    public class HW5
    {
        private Core _core;
        public HW5()
        {
            _core = new Core();
        }
        public void SolveTask1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Найти минимальный элемент массива");
            int a = _core.ConvertNumberFromUserInput("Введите количество строк массива");
            int b = _core.ConvertNumberFromUserInput("Введите количество столбцов массива");
            int[,] array = FillArrayOfRandom(a, b);
            PrintArray(array);
            Console.WriteLine($"\nМинимальный элемент массива: {FindMinElementOfArray(array)}");
        }
        public void SolveTask2()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine("Найти максимальный элемент массива");
            int a =_core.ConvertNumberFromUserInput("Введите количество строк массива");
            int b =_core.ConvertNumberFromUserInput("Введите количество столбцов массива");
            int[,] array = FillArrayOfRandom(a, b);
            PrintArray(array);
            Console.WriteLine($"\nМаксимальный элемент массива: {FindMaxElementOfArray(array)}");
        }
        public void SolveTask3()
        {
            Console.WriteLine("Задача 3");
            Console.WriteLine("Найти индекс минимального элемента массива");
            int a =_core.ConvertNumberFromUserInput("Введите количество строк массива");
            int b =_core.ConvertNumberFromUserInput("Введите количество столбцов массива");
            int[,] array = FillArrayOfRandom(a, b);
            PrintArray(array);                        
            Console.WriteLine();
            int[] array2 = FindIndexOfMinElementOfArray(array);
            Console.WriteLine("Индекс минимального элемента массива");
            PrintArray(array2);
        }
        public void SolveTask4()
        {
            Console.WriteLine("Задача 4");
            Console.WriteLine("Найти индекс максимального элемента массива");
            int a = _core.ConvertNumberFromUserInput("Введите количество строк массива");
            int b = _core.ConvertNumberFromUserInput("Введите количество столбцов массива");
            int[,] array = FillArrayOfRandom(a, b);
            PrintArray(array);
            Console.WriteLine();
            int[] array2 = FindIndexOfMaxElementOfArray(array);
            Console.WriteLine("Индекс максимального элемента массива");
            PrintArray(array2);
        }
        public void SolveTask5()
        {
            Console.WriteLine("Задача 5");
            Console.WriteLine("Найти количество элементов массива, которые больше всех своих соседей одновременно");
            int a = _core.ConvertNumberFromUserInput("Введите количество строк массива");
            int b = _core.ConvertNumberFromUserInput("Введите количество столбцов массива");
            int[,] array = FillArrayOfRandom(a, b);            
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine($"Кол-во элементов, которые больше своих соседей:{CountElementsThatAreBiggerThanNeighbors(array)}");
        }
        public void SolveTask6()
        {
            Console.WriteLine("Задача 6");
            Console.WriteLine("Отразить массив по диагонали");
            int a = _core.ConvertNumberFromUserInput("Введите количество строк и столбцов массива");
            int b = a;
            int[,] array = FillArrayOfRandom(a, b);
            PrintArray(array);
            Console.WriteLine();
            array=DiagonalMirrowArray(array);
            PrintArray(array);
        }        
        public int[,] FillArrayOfRandom(int numberA, int numberB)
        {
            int[,] array = new int[numberA, numberB];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 200);
                }
            }
            return array;
        }
        public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public int FindMinElementOfArray(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        public int FindMaxElementOfArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        public int[] FindIndexOfMinElementOfArray(int[,] array)
        {
            int min = array[0, 0];
            int temp = 0;
            int temp2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        temp = i;
                        temp2 = j;
                    }
                }
            }
            int[] array2 = new int [] {temp, temp2};
            return array2;
        }
        public void PrintArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]}\t");
            }
        }
        public int[] FindIndexOfMaxElementOfArray(int[,] array)
        {
            int max = array[0, 0];
            int temp = 0;
            int temp2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        temp = i;
                        temp2 = j;
                    }
                }
            }
            int[] array2 = new int[] { temp, temp2 };
            return array2;
        }
        public int CountElementsThatAreBiggerThanNeighbors(int[,] array)
        {                     
            int tmp = 0;            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j]) && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1])
                          && (j == 0 || array[i, j] > array[i, j - 1])
                          && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j]))
                    {
                        tmp++;                                              
                    }
                }
            }
            return tmp;
        }
        public int[,] DiagonalMirrowArray(int[,] array)
        {            
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < j; i++)
                {
                    _core.SwapVariables(ref array[i, j], ref array[j, i]);                   
                }               
            }
            return array;
        }
        }
}
