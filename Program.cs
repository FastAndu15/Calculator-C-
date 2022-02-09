using System;

namespace PrimulProiect
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Selectati operatia!");
                Console.WriteLine("1.Adunare");
                Console.WriteLine("2.Scadere");
                Console.WriteLine("3.Impartire");
                Console.WriteLine("4.Inmultire");
                Console.WriteLine("5.Ridicare la putere");
                Console.WriteLine("6.IESIRE");

                int firstNumber, secondNumber, operatie;

                string input = Console.ReadLine();

                int.TryParse(input, out operatie);
                
                double result = 0;

                if (operatie == 5)
                {
                    Console.WriteLine("Primul numar ridicat la putere este:");
                    result = Calculator.UP(firstNumber);
                }

                if (operatie == 6)
                {
                    Console.WriteLine("Calculatorul a fost oprit!");
                    return;
                }
                
                Console.WriteLine("Va rog sa introduceti primul numar:");
                int.TryParse(Console.ReadLine(), out firstNumber);

                Console.WriteLine("Va rog sa introduceti al doilea numar:");
                int.TryParse(Console.ReadLine(), out secondNumber);

                switch (operatie)
                {
                    case 1:
                        result = Calculator.SUMA(firstNumber, secondNumber);
                        break;

                    case 2:
                        result = Calculator.DIF(firstNumber, secondNumber);
                        break;

                    case 3:
                        result = Calculator.DIVIDE(firstNumber, secondNumber);
                        break;

                    case 4:
                        result = Calculator.MULTIPLY(firstNumber, secondNumber);
                        break;
                }

  
                Console.WriteLine(result);
            }
        }
    }
}