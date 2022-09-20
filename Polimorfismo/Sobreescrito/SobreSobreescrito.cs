using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescrito
{
    public class SobreSobreescrito : Sobreescrito
    {
        public SobreSobreescrito(string nombre, string miAtributo) : base(nombre, miAtributo)
        {
        }

        public override string MiPropiedad => throw new NotImplementedException();

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
