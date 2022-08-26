using System;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main()
        {
            int triangleHeight;

            triangleHeight = GetInt("Ingresar altura de triagulo: ", "ERROR. ¡Reingresar altura de triagulo!");

            for (int i = 1; i <= triangleHeight * 2; i += 2)
            {

                for (int k = triangleHeight * 2; k > i; k -= 2)
                { 
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static int GetInt(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = int.TryParse(userInput, out int parsedInt);

            while (!inputWasParsed || parsedInt < 1)
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
