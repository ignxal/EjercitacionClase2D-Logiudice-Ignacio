using System;

namespace _2_Ejercicio_02
{
    internal class Program
    {
        static void Main()
        {

            int parsedNumber;
            int totalSum = 0;
            string userAnswer;

            do
            {
                parsedNumber = GetInt("Ingrese un numero: ", "ERROR. ¡Reingresar numero!");
                totalSum += parsedNumber;

                userAnswer = GetAnswer("¿Desea continuar? (S/N)", "ERROR. ¡Reingresar respuesta!");

            } while (Validator.ValidateAnswer(userAnswer));

            DisplayResults(totalSum);
        }

        static int GetInt(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = int.TryParse(userInput, out int parsedInt);

            while (!inputWasParsed)
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

        static string GetAnswer(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            userInput = GetUserInput(consoleMessage);

            while (userInput != "S" && userInput != "N")
            {
                userInput = GetUserInput(consoleMessage, consoleMessageError);
            }

            return userInput;
        }

        static void DisplayResults(int number)
        {
            Console.WriteLine("\n\n##### Resultado #####\n");
            Console.WriteLine($"Suma total: {number}");
        }
    }
}
