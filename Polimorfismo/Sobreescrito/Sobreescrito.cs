using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescrito
{
    public class Sobreescrito
    {
        public string nombre;

        public Sobreescrito(string nombre)
        {
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            Sobreescrito sobreescrito = obj as Sobreescrito;

            return sobreescrito is not null && this.nombre == sobreescrito.nombre;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }

    
}
