using System;

namespace Core1
{
    public class Core
    {
        public int ConvertNumberFromUserInput(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public void SwapVariables(ref int numberA, ref int numberB)
        {
            int temp = numberA;
            numberA = numberB;
            numberB = temp;
        }
    }
}
