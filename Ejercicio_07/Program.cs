using System;
using System.Linq;
using System.Xml.Linq;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main()
        {
            double parsedHourValue;
            string name;
            int parsedAntiquity;
            int parsedWorkedHours;
            double totalGrossSalary;
            double discount;
            double totalNetSalary;
            string userAnswer;

            Console.WriteLine("##### SISTEMA RECIBOS #####\n\n");

            do
            {
                parsedHourValue = GetDouble("valor hora");
                name = GetString("nombre");
                parsedAntiquity = GetInt("antigüedad (años)");
                parsedWorkedHours = GetInt("horas trabajadas");

                totalGrossSalary = GetTotalGrossSalary(parsedHourValue, parsedWorkedHours, parsedAntiquity);
                discount = GetDiscount(totalGrossSalary);
                totalNetSalary = GetTotalNetSalary(totalGrossSalary, discount); 

                DisplayPaycheck(name, parsedAntiquity, parsedHourValue, totalGrossSalary, totalNetSalary);

                Console.Write("\n\nDesea calcular otro recibo? (si/no): ");
                userAnswer = Console.ReadLine();

                while (userAnswer != "si" && userAnswer != "no")
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar respuesta!\n\n");
                    Console.Write("Desear volver a operar? (si/no): ");
                    userAnswer = Console.ReadLine();
                }

            } while (userAnswer != "no");
        }

        static string GetString(string consoleMessage)
        {
            string userInput;
            userInput = GetUserInput(consoleMessage);

            while (string.IsNullOrEmpty(userInput) || userInput.Any(char.IsDigit))
            {
                userInput = GetUserInput(consoleMessage, true);
            }

            return userInput;
        }

        static int GetInt(string consoleMessage)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = int.TryParse(userInput, out int parsedInt);

            while (!inputWasParsed)
            {
                userInput = GetUserInput(consoleMessage, true);
                inputWasParsed = int.TryParse(userInput, out parsedInt);
            }

            return parsedInt;
        }

        static double GetDouble(string consoleMessage)
        {
            string userInput;
            bool inputWasParsed;

            userInput = GetUserInput(consoleMessage);
            inputWasParsed = double.TryParse(userInput, out double parsedDouble);

            while (!inputWasParsed)
            {
                userInput = GetUserInput(consoleMessage, true);
                inputWasParsed = double.TryParse(userInput, out parsedDouble);
            }

            return parsedDouble;
        }

        static string GetUserInput(string consoleMessage, bool wasAnError = false)
        {
            if (wasAnError)
            {
                Console.WriteLine($"\nERROR. ¡Reingresar {consoleMessage}!\n");
            }
            Console.Write($"Ingrese {consoleMessage}: ");

            return Console.ReadLine();
        }
        static double GetTotalGrossSalary(double hourValue, int workedHours, int antiquity)
        {
            return (hourValue * workedHours) + (antiquity * 150);
        }

        static double GetDiscount(double totalGrossSalary)
        {
            return totalGrossSalary * 0.13;
        }

        static double GetTotalNetSalary(double totalGrossSalary, double discount)
        {
            return totalGrossSalary - discount;
        }

        static void DisplayPaycheck(string name, int antiquity, double hourValue, double totalGrossSalary, double totalNetSalary)
        {
            Console.WriteLine("\n\n##### Recibo de sueldo #####\n");
            Console.WriteLine($"Nombre: {name}");
            Console.WriteLine($"Antigüedad: {antiquity}");
            Console.WriteLine($"Valor hora: {hourValue}");
            Console.WriteLine($"Total a cobrar bruto: {totalGrossSalary}");
            Console.WriteLine($"Total a cobrar neto: {totalNetSalary}");
            Console.WriteLine("\n################################");
        }
    }
}
