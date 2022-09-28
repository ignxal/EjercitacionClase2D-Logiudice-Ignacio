using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercitacionClase10
{
    public abstract class Weapon
    {
        protected int danio;

        public Weapon(int danio)
        {
            this.danio = danio;
        }

        public int Danio { get { return danio; } }

        public abstract string Attacking();
    }
}
