using System;
using System.Drawing;
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
                parsedHourValue = GetDouble("Ingresar valor de hora: ", "ERROR. ¡Reingresar valor hora!");
                name = GetString("Ingresar nombre: ", "ERROR. ¡Reingresar nombre!");
                parsedAntiquity = GetInt("Ingresar antigüedad (años): ", "ERROR. ¡Reingresar antigüedad (años)!");
                parsedWorkedHours = GetInt("Ingresar horas trabajadas: ", "ERROR. ¡Reingresar horas trabajadas!");

                totalGrossSalary = GetTotalGrossSalary(parsedHourValue, parsedWorkedHours, parsedAntiquity);
                discount = GetDiscount(totalGrossSalary);
                totalNetSalary = GetTotalNetSalary(totalGrossSalary, discount); 

                DisplayPaycheck(name, parsedAntiquity, parsedHourValue, totalGrossSalary, totalNetSalary);

                userAnswer = GetAnswer("Desea calcular otro recibo? (si/no): ", "ERROR. ¡Reingresar respuesta!");

            } while (userAnswer != "no");
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

            while (string.IsNullOrEmpty(userInput) || userInput.Any(char.IsDigit))
            {
                userInput = GetUserInput(consoleMessage, consoleMessageError);
            }

            return userInput;
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

        static string GetAnswer(string consoleMessage, string consoleMessageError)
        {
            string userInput;
            userInput = GetUserInput(consoleMessage);

            while (userInput != "si" && userInput != "no")
            {
                userInput = GetUserInput(consoleMessage, consoleMessageError);
            }

            return userInput;
        }

        static void DisplayPaycheck(string name, int antiquity, double hourValue, double totalGrossSalary, double totalNetSalary)
        {
            Console.WriteLine("\n\n##### Recibo de sueldo #####\n");
            Console.WriteLine($"Nombre: {name}");
            Console.WriteLine($"Antigüedad: {antiquity}");
            Console.WriteLine($"Valor hora: {hourValue}");
            Console.WriteLine($"Total a cobrar bruto: {totalGrossSalary}");
            Console.WriteLine($"Total a cobrar neto: {totalNetSalary}");
            Console.WriteLine("\n############################\n");
        }
    }
}
