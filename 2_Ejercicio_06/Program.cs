using System;

namespace _2_Ejercicio_06
{
    internal class Program
    {
        static void Main()
        {
            double squareSideLength;
            double triangleBase;
            double triangleHeight;
            double circleRadio;
            double squareArea;
            double triangleArea;
            double circleArea;
            string userAnswer;

            do
            {
                Console.Clear();

                Console.WriteLine("###### Cuadrado ######\n");
                squareSideLength = GetDouble("Ingrese longitud del lado: ", "ERROR. ¡Reingresar valor!");

                Console.WriteLine("\n###### Triangulo ######\n");
                triangleBase = GetDouble("Ingrese base: ", "ERROR. ¡Reingresar valor!");
                triangleHeight = GetDouble("Ingrese altura: ", "ERROR. ¡Reingresar valor!");

                Console.WriteLine("\n###### Circulo ######\n");
                circleRadio = GetDouble("Ingrese radio: ", "ERROR. ¡Reingresar valor!");

                squareArea = AreaCalculator.CalculateSquareArea(squareSideLength);
                triangleArea = AreaCalculator.CalculateTriangleArea(triangleBase, triangleHeight);
                circleArea = AreaCalculator.CalculateCircleArea(circleRadio);
                DisplayResults(squareArea, triangleArea, circleArea);

                userAnswer = GetAnswer("¿Desea realizar otro calculo? (S/N)", "ERROR. ¡Reingresar respuesta!");
            } while (ValidateAnswer(userAnswer));


        }

        static double GetDouble(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = double.TryParse(userInput, out double parsedDouble);

            while (!inputWasParsed || parsedDouble < 0)
            {
                userInput = GetUserInput(consoleMessage, consoleMessageError);
                inputWasParsed = double.TryParse(userInput, out parsedDouble);
            }

            return parsedDouble;
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

        static void DisplayResults(double squareArea, double triangleArea, double circleArea)
        {
            Console.WriteLine("\n\n######################\n");
            Console.WriteLine($"Area del cuadrado: {squareArea}");
            Console.WriteLine($"Area del triangulo: {triangleArea}");
            Console.WriteLine($"Area del circulo: {circleArea}");
            Console.WriteLine("\n######################\n");
        }
    }
}
