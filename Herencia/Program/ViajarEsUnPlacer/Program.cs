// See https://aka.ms/new-console-template for more information
using ClassLibrary;
using System.Collections.Generic;

internal class Program
{
    private static void Main()
    {
        List<LandVehicle> list = new(10);
        Car redCar = new Car(4, 5, EColors.Rojo, 6, 2);
        Car blueCar = new Car(4, 3, EColors.Azul, 6, 1);
        Motorcycle blackMotorcycle = new Motorcycle(2, 0, EColors.Negro, 4);
        Truck whiteTruck = new Truck(6, 2, EColors.Blanco, 200);
        Truck greyTruck = new Truck(6, 2, EColors.Gris, 500);

        list.Add(redCar);
        list.Add(blueCar);
        list.Add(blackMotorcycle);
        list.Add(whiteTruck);

        foreach (LandVehicle v in list)
        {
            if (v is Car)
            {
                Console.WriteLine(((Car)v).DisplayInfoCar());
            }
            else if (v is Motorcycle)
            {
                Console.WriteLine(((Motorcycle)v).DisplayInfoMotorcycle());
            }
            else
            {
                Console.WriteLine(((Truck)v).DisplayInfoTruck());
            }
            Console.WriteLine($"*************************************************************************************");

        }
    }
}