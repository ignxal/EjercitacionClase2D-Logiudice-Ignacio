using System;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main()
        {
            int triangleHeight;
            string newRow = "*";
            
            triangleHeight = GetInt("Ingresar altura de triagulo: ", "ERROR. ¡Reingresar altura de triagulo!");

            for (int i = 0; i < triangleHeight; i++)
            {
                Console.WriteLine($"{newRow}");

                newRow += "**";
            }
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
    }
}
