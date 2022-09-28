using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitacionClase10
{
    public class Axe : Weapon
    {
        protected int bladeAmount;
        public Axe(int danio, int bladeAmount) : base(danio)
        {
            this.bladeAmount = bladeAmount;
        }

        public int BladeLength { get { return this.bladeAmount; } }

        public override string Attacking()
        {
            return $"zaaaaaaaaaaaaazzzz -{danio}"; ;
        }
    }
}
