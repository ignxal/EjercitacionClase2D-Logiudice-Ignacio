using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitacionClase10
{
    public class Sword : Weapon
    {
        protected int bladeLength;
        public Sword(int danio, int bladeLength) : base(danio)
        {
            this.bladeLength = bladeLength;
        }

        public int BladeLength { get { return this.bladeLength; } }

        public override string Attacking()
        {
            return $"espadazooooo -{danio}";
        }
    }
}
