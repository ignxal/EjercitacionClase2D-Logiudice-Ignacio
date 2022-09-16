using System.Text;

namespace ClassLibrary
{
    public class Car : LandVehicle
    {
        private short revsAmount;
        private int passengersAmount;

        public Car(short amountWheels, short amountDoors, EColors color, short revsAmount, int passengersAmount): base(amountWheels, amountDoors, color)
        {
            this.revsAmount = revsAmount;
            this.passengersAmount = passengersAmount;
        }
        public short RevsAmount { get => revsAmount; }
        public int PassengersAmount { get => passengersAmount; }

        public string DisplayInfoCar()
        {
            StringBuilder sb = new();

            sb.Append(base.DisplayInfo());
            sb.AppendLine($"Cantidad revoluciones: {this.revsAmount}");
            sb.AppendLine($"Cantidad pasajeros: {this.passengersAmount}");

            return sb.ToString();
        }
    }
}