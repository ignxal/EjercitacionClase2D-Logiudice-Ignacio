using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Truck : LandVehicle
    {
        protected int loadWeight;
        public Truck(short amountWheels, short amountDoors, EColors color, int loadWeight) : base(amountWheels, amountDoors, color)
        {
            this.loadWeight = loadWeight;
        }
        public int LoadWeight { get => loadWeight; }

        public string DisplayInfoTruck()
        {
            StringBuilder sb = new();

            sb.Append(base.DisplayInfo());
            sb.AppendLine($"Peso de carga: {this.loadWeight}");

            return sb.ToString();
        }
    }
}
