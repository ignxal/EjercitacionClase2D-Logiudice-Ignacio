using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public abstract class LandVehicle
    {
        protected short amountWheels;
        protected short amountDoors;
        protected EColors color;

        protected LandVehicle(short amountWheels, short amountDoors, EColors color)
        {
            this.amountWheels = amountWheels;
            this.amountDoors = amountDoors;
            this.color = color;
        }

        public short AmountWheels{ get => amountWheels; }
        public short AmountDoors { get => amountDoors; }
        public EColors Color{ get => color; }

        protected string DisplayInfo()
        {
            StringBuilder sb = new();

            sb.AppendLine($"Cantidad ruedas: {this.amountWheels}");
            sb.AppendLine($"Cantidad puertas: {this.amountDoors}");
            sb.AppendLine($"Color:{this.color}");

            return sb.ToString();
        }
        
        
    }
}