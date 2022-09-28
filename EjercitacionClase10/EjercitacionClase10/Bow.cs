using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitacionClase10
{
    public class Bow : Weapon
    {
        protected int maxRange;
        public Bow(int danio, int maxRange) : base(danio)
        {
            this.maxRange = maxRange;
        }

        public int BladeLength { get { return this.maxRange; } }

        public override string Attacking()
        {
            return $"piiiiuuu piuuuu piuuuuu -{danio}";
        }
    }
}
