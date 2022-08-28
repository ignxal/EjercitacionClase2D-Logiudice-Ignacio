using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _2_Ejercicio_04
{
    internal class Program
    {
        static void Main()
        {
            double firstOperand;
            double secondOperand;
            string mathOperation;
            string operationResult;
            string userAnswer;

            do
            {
                Console.Clear();
                firstOperand = GetDouble("Ingrese primer operando: ", "ERROR. ¡Reingresar numero!");
                secondOperand = GetDouble("Ingrese segundo operando: ", "ERROR. ¡Reingresar numero!");
                mathOperation = GetString("Ingrese operacion a realizar (+ - * /): ", "ERROR. ¡Reingresar operacion a realizar!");
                operationResult = Calculator.Calculate(firstOperand, secondOperand, mathOperation);
                DisplayResult(operationResult);

                userAnswer = GetAnswer("¿Desea continuar? (S/N)", "ERROR. ¡Reingresar respuesta!");
            } while (ValidateAnswer(userAnswer));

            
        }

        static double GetDouble(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = double.TryParse(userInput, out double parsedDouble);

            while (!inputWasParsed)
            {
                userInput = GetUserInput(consoleMessage, consoleMessageError);
                inputWasParsed = double.TryParse(userInput, out parsedDouble);
            }

            return parsedDouble;
        }

        static string GetString(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            userInput = GetUserInput(consoleMessage);

            while (string.IsNullOrEmpty(userInput) || (userInput != "+" && userInput != "-" && userInput != "*" && userInput != "/"))
            {
                userInput = GetUserInput(consoleMessage, consoleMessageError);
            }

            return userInput;
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

        public static bool ValidateAnswer(string answer)
        {
            bool returnValue = true;

            if (answer != "S")
            {
                returnValue = false;
            }

            return returnValue;
        }

        static void DisplayResult(string result)
        {
            Console.WriteLine("\n\n######################\n");
            Console.WriteLine($"Resultado: {result}");
            Console.WriteLine("\n######################\n");
        }
    }
}
