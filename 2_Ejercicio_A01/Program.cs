using System;
using System.Text;

namespace _2_Ejercicio_A01
{
    internal class Program
    {
        static void Main()
        {
            int inputNumber;
            int factorial;

            inputNumber = GetInt("Ingrese número a calcular el factorial: ", "ERROR. ¡Reingresar número!");
            factorial = GetFactorial(inputNumber);

            DisplayResult(factorial);
        }

        static int GetInt(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = int.TryParse(userInput, out int parsedInt);

            while (!inputWasParsed || parsedInt < 0)
            {
                userInput = GetUserInput(consoleMessage, consoleMessageError);
                inputWasParsed = int.TryParse(userInput, out parsedInt);
            }

            return parsedInt;
        }

        static string GetUserInput(string consoleMessage, string consoleMessageError = "false")
        {
            if (consoleMessageError != "false")
            {
                Console.WriteLine($"\n{consoleMessageError}\n");
            }
            Console.Write($"{consoleMessage}");

            return Console.ReadLine();
        }

        static void DisplayResult(int number)
        {
            Console.WriteLine("\n\n######################\n");
            Console.Write($"Resultado: {number}");
            Console.WriteLine("\n\n######################\n");
        }


        static int GetFactorial(int number)
        {
            int operationResult = 1;

            for (int i = number; i > 0; i--)
            {
                operationResult *= i;
            }

            return operationResult;
        }
    }
}
