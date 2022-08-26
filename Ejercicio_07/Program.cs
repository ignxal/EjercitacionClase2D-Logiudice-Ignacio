using System;
using System.Linq;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main()
        {
            string nombre;
            bool inputWasParsed;
            double totalGrossSalary;
            double discount;
            double totalNetSalary;
            string userInput;
            string userAnswer;

            Console.WriteLine("##### SISTEMA RECIBOS #####\n\n");

            do
            {
                Console.Write("Ingrese valor hora: ");
                userInput = Console.ReadLine();
                inputWasParsed = double.TryParse(userInput, out double parsedHora);

                while (!inputWasParsed)
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar valor hora!\n\n");
                    Console.Write("Ingrese valor hora: ");
                    userInput = Console.ReadLine();
                    inputWasParsed = double.TryParse(userInput, out parsedHora);
                }

                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();

                while (string.IsNullOrEmpty(nombre) || nombre.Any(char.IsDigit))
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar nombre!\n\n");
                    Console.Write("Ingrese nombre: ");
                    nombre = Console.ReadLine();
                }

                Console.Write("Ingrese antigüedad (años): ");
                userInput = Console.ReadLine();
                inputWasParsed = int.TryParse(userInput, out int parsedAntigüedad);

                while (!inputWasParsed)
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar antigüedad (años)!\n\n");
                    Console.Write("Ingrese antigüedad (años): ");
                    userInput = Console.ReadLine();
                    inputWasParsed = int.TryParse(userInput, out parsedAntigüedad);
                }

                Console.Write("Ingrese cantidad horas trabajadas: ");
                userInput = Console.ReadLine();
                inputWasParsed = float.TryParse(userInput, out float parsedHorasTrabajadas);

                while (!inputWasParsed)
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar cantidad horas trabajadas!\n\n");
                    Console.Write("Ingrese cantidad horas trabajadas: ");
                    userInput = Console.ReadLine();
                    inputWasParsed = float.TryParse(userInput, out parsedHorasTrabajadas);
                }





                totalGrossSalary = (parsedHora * parsedHorasTrabajadas) + (parsedAntigüedad * 150);
                discount = totalGrossSalary * 0.13;
                totalNetSalary = totalGrossSalary - discount;

                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Antigüedad: {parsedAntigüedad}");
                Console.WriteLine($"Valor hora: {parsedHora}");
                Console.WriteLine($"Total a cobrar bruto: {totalGrossSalary}");
                Console.WriteLine($"Total a cobrar neto: {totalNetSalary}");


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
    }
}
