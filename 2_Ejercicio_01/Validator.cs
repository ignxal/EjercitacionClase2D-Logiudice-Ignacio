using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ejercicio_01
{
    static class Validator
    {
        public static bool Validate(int value, int min = -100, int max = 100)
        {
            bool returnValue = true;

            if (value > max || value < min)
            {
                returnValue = false;
            }
            return returnValue;
        }
    }
}
