using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Motorcycle : LandVehicle
    {
        private short displacement;

        public Motorcycle(short amountWheels, short amountDoors, EColors color, short displacement) : base(amountWheels, amountDoors, color)
        {
            this.displacement = displacement;
        }

        public short Displacement { get => displacement; }

        public string DisplayInfoMotorcycle()
        {
            StringBuilder sb = new();

            sb.Append(base.DisplayInfo());
            sb.AppendLine($"Cilindrada: {this.displacement}");

            return sb.ToString();
        }
    }
}
