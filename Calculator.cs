using System;

namespace PrimulProiect
{
    class Calculator
    {
        public static int SUMA(int firstNumber, int secondNumber)
        {
             return firstNumber + secondNumber;
        }
        public static int DIF(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int MULTIPLY(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double DIVIDE(int firstNumber, int secondNumber)
        {
            try
            {
                return (double) firstNumber / secondNumber;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Diviziunea nu a fost posibila, secondNumber a fost ZERO");
                return 0;
            }
            return firstNumber / secondNumber;
        }

        public static double UP(int firstNumber)
        {
            return firstNumber * firstNumber;
        }
    }
}