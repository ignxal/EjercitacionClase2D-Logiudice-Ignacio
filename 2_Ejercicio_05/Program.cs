using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _2_Ejercicio_05
{
    internal class Program
    {
        static void Main()
        {
            int inputNumber;

            inputNumber = GetInt("Ingrese un numero: ", "ERROR. ¡Reingresar número!");
            DisplayResults(inputNumber);
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

        static void DisplayResults(int number)
        {
            string numberMultiplicationTable = BuildTable(number);

            Console.Write(numberMultiplicationTable);

        }

        static string BuildTable(int number)
        {
            int maximumNumber = 9;

            StringBuilder sb = new($"\nTabla de multiplicar del número {number}:\n", 100);
            for (int currentNumber = 1; currentNumber <= maximumNumber; currentNumber++)
            {
                sb.AppendLine($"{number} x {currentNumber} = {GetOperationResult(number, currentNumber)}");
            }

            return sb.ToString();
        }

        static int GetOperationResult(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
