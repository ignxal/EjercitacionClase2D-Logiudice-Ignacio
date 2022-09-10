using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace MaquinaExpendedora
{
    internal class Program
    {
        static void Main()
        {
            string userAnswer = "N";
            int indexProduct;
            int queueLength;
            double totalPrice = 0;
            List<Product> buffetTable = new();
            List<Product> currentClientMenu = new();

            Queue<string> clientsQueue = new();
            string[] clientsName = new[] { "Lucas", "Nacho", "Esteban", "El capitan Beto", "El pibe de los astilleros" };

            string[] chocolatesName = new[] { "Milka", "Aguila", "Tofi", "Cadbury", "Block" };
            double[] chocolatesPrice = new[] { 25.50, 30, 20, 15, 40.30 };

            string[] refreshmentsName = new[] { "Coca", "Sprite", "Fanta", "Aquarius", "Schweppes" };
            double[] refreshmentsPrice = new[] { 20.50, 20, 20, 15, 21.30 };

            string[] snacksName = new[] { "Lays", "Doritos", "Cheetos", "Pep", "3D" };
            double[] snacksPrice = new[] { 50.50, 50, 50, 45, 40.40 };

            for (int i = 0; i < clientsName.Length; i++)
            {
                clientsQueue.Enqueue(clientsName[i]);
            }

            for (int i = 0; i < chocolatesName.Length; i++)
            {
                buffetTable.Add(new Product(chocolatesName[i], chocolatesPrice[i], 10));
            }

            for (int i = 0; i < refreshmentsName.Length; i++)
            {
                buffetTable.Add(new Product(refreshmentsName[i], refreshmentsPrice[i], 10));
            }

            for (int i = 0; i < snacksName.Length; i++)
            {
                buffetTable.Add(new Product(snacksName[i], snacksPrice[i], 10));
            }

            queueLength = clientsQueue.Count;

            for (int i = 0; i < queueLength; i++)
            {
                Console.WriteLine($"\n--------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Se esta atendiendo al cliente: {clientsQueue.Peek()}\nTamaño de la fila: {clientsQueue.Count}");
                Console.WriteLine($"--------------------------------------------------------------------------------------------------\n");
                DisplayOptions(buffetTable);

                do
                {
                    indexProduct = GetInt("\nIngrese indice del producto que desea comprar: ", "ERROR! Valor ingresado invalido");

                    if (!buffetTable.Contains(buffetTable[indexProduct]))
                    {
                        Console.WriteLine("\nERROR. Clave invalida\n");
                        continue;
                    }

                    Product chosenProduct = buffetTable[indexProduct];
                    chosenProduct.Amount--;
                    currentClientMenu.Add(chosenProduct);

                    Console.WriteLine("\n************ Productos seleccionados ************");
                    foreach (var prod in currentClientMenu)
                    {
                        Console.WriteLine($"{prod.Name} - ${prod.Price}");
                        totalPrice += prod.Price;
                    }
                    Console.WriteLine($"Total a pagar: ${totalPrice}");


                    if (chosenProduct.Amount == 0)
                    {
                        buffetTable.Remove(chosenProduct);
                    }

                    userAnswer = GetAnswer("\n¿Desea agregar otro plato? (S/N)", "ERROR. ¡Reingresar respuesta!");

                    if (userAnswer == "N")
                    {
                        currentClientMenu.Clear();
                        totalPrice = 0;
                        Console.Clear();
                    }

                } while (userAnswer == "S");
                clientsQueue.Dequeue();
            }
            clientsQueue.Clear();
        }

        public static void DisplayOptions(List<Product> list)
        {
            Console.WriteLine("***** Productos *****\n");
            foreach (Product feature in list)
            {
                Console.WriteLine($"{list.IndexOf(feature)} - Nombre: {feature.Name} - Precio: ${feature.Price} - Cantidad: {feature.Amount}");
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

    }
}
