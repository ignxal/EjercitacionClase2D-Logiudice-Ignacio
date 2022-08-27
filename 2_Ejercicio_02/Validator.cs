using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ejercicio_02
{
    static class Validator
    {
        public static bool ValidateAnswer(string answer)
        {
            bool returnValue = true;

            if (answer != "S")
            {
                returnValue = false;
            }

            return returnValue;
        }
    }
}
