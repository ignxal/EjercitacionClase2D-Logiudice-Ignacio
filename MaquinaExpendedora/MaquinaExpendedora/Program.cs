using System;
using System.Collections;
using System.Collections.Generic;

namespace MaquinaExpendedora
{
    internal class Program
    {
        static void Main()
        {
            string userAnswer;
            int keyProduct;
            bool productRemoved = false;
            Dictionary<int, Stack<Product>> vendingMachine = new();

            Stack<Product> chocolates = new();
            string[] chocolatesName = new[] { "Milka", "Aguila", "Tofi", "Cadbury", "Block"};
            double[] chocolatesPrice = new[] { 25.50, 30, 20, 15, 40.30 };

            for (int i = 0; i < chocolatesName.Length; i++)
            {
                chocolates.Push(new Product(chocolatesName[i], chocolatesPrice[i]));
            }

            Stack<Product> refreshments = new();
            string[] refreshmentsName = new[] { "Coca", "Sprite", "Fanta", "Aquarius", "Schweppes" };
            double[] refreshmentsPrice = new[] { 20.50, 20, 20, 15, 21.30 };

            for (int i = 0; i < refreshmentsName.Length; i++)
            {
                refreshments.Push(new Product(refreshmentsName[i], refreshmentsPrice[i]));
            }

            Stack<Product> snacks = new();
            string[] snacksName = new[] { "Lays", "Doritos", "Cheetos", "Pep", "3D" };
            double[] snacksPrice = new[] { 50.50, 50, 50, 45, 40.40 };

            for (int i = 0; i < snacksName.Length; i++)
            {
                snacks.Push(new Product(snacksName[i], snacksPrice[i]));
            }

            vendingMachine.Add(1, chocolates);
            vendingMachine.Add(2, refreshments);
            vendingMachine.Add(3, snacks);

            do
            {
                Console.Clear();
                DisplayOptions(vendingMachine);

                do
                {
                    keyProduct = GetInt("Ingrese clave del producto que desea retirar: ", "ERROR! Valor ingresado invalido");
                    if (!vendingMachine.ContainsKey(keyProduct))
                    {
                        Console.WriteLine("\nERROR. Clave invalida\n");
                        continue;
                    }

                    Product chosenProduct = vendingMachine[keyProduct].Pop();
                    Console.WriteLine($"Se selecciono el producto: {chosenProduct.Name} - {chosenProduct.Price} | Codigo: {chosenProduct.Code}");
                    productRemoved = true;

                    if(vendingMachine[keyProduct].Count == 0)
                    {
                        vendingMachine.Remove(keyProduct);
                    }

                } while (!productRemoved);
                userAnswer = GetAnswer("¿Desea salir? (S/N)", "ERROR. ¡Reingresar respuesta!");
            } while (userAnswer != "S");

        }

        public static void DisplayOptions(Dictionary<int, Stack<Product>> dict)
        {
            Console.Write("***** Maquina Expendedora *****\n");
            foreach (KeyValuePair<int, Stack<Product>> feature in dict)
            {
                Console.WriteLine($"Clave: {feature.Key} - Codigo: {feature.Value.Peek().Code} - Nombre: {feature.Value.Peek().Name} - Precio: {feature.Value.Peek().Price} - Cantidad: {feature.Value.Count}");
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

    }
}
