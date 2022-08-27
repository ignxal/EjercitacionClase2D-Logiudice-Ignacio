using System;
using System.Xml.Linq;

namespace _2_Ejercicio_01
{
    internal class Program
    {
        static void Main()
        {
            int inputNumber;
            int maxValue = -100;
            int minValue = 100;
            int totalNumbers = 10;
            int totalAcum = 0;
            double average;

            for (int i = 0; i < totalNumbers; i++)
            {
                inputNumber = GetInt("Ingrese un numero: ", "ERROR. ¡Reingresar número!");

                if (inputNumber > maxValue)
                {
                    maxValue = inputNumber;
                }
                if (inputNumber < minValue)
                {
                    minValue = inputNumber;
                }

                totalAcum += inputNumber;
            }
            average = GetAverage(totalAcum, totalNumbers);
            DisplayResults(minValue, maxValue, average);
        }

        static int GetInt(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = int.TryParse(userInput, out int parsedInt);

            while (!inputWasParsed || !Validator.Validate(parsedInt))
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

        static double GetAverage(int accumulated, int totalNumbers)
        {
            return accumulated / totalNumbers;
        }

        static void DisplayResults(int minimumNumber, int maximumNumber, double average)
        {
            Console.WriteLine("\n\n##### Resultados #####\n");
            Console.WriteLine($"Menor numero ingresado: {minimumNumber}");
            Console.WriteLine($"Maximo numero ingresado: {maximumNumber}");
            Console.WriteLine($"Promedio: {average}");
        }
    }
}
