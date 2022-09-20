using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescrito
{
    public abstract class Sobreescrito
    {
        public string nombre;
        protected string miAtributo;

        public Sobreescrito(string nombre, string miAtributo)
        {
            this.nombre = nombre;
            this.miAtributo = miAtributo;
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();

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
