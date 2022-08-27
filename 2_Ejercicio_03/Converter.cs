using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ejercicio_03
{
    static class Converter
    {
        public static string ConvertDecimalToBinary(int number)
        {
            string result = string.Empty;
            int rem;

            while (number > 0 || string.IsNullOrEmpty(result))
            {
                rem = number % 2;
                number /= 2;
                result = rem.ToString() + result;
            }

            return result;
        }

        public static string ConvertBinaryToDecimal(int number)
        {
            int baseVal = 1, rem;
            int result = 0;


            while (number > 0)
            {
                rem = number % 10;
                result += rem * baseVal;
                number /= 10;
                baseVal *= 2;
            }

            return result.ToString();
        }

    }
}
