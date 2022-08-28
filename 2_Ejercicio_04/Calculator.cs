using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ejercicio_04
{
    static class Calculator
    {
        public static string Calculate(double firstOperand, double secondOperand, string mathOperation)
        {
            string result;

            switch (mathOperation)
            {
                case "+":
                    result = (firstOperand + secondOperand).ToString();
                    break;
                case "-":
                    result = (firstOperand - secondOperand).ToString();
                    break;
                case "*":
                    result = (firstOperand * secondOperand).ToString();
                    break;
                case "/":
                    if (Validate(secondOperand))
                    {
                        result = (firstOperand / secondOperand).ToString();
                    }
                    else
                    {
                        result = "ERROR! No se puede divir por 0";
                    }
                    break;
                default:
                    result = $"ERROR! No se reconoce a {mathOperation} como una compatible operacion matematica";
                    break;
            }

            return result;
        }

        private static bool Validate(double secondOperand)
        {
            bool returnValue = false;

            if(secondOperand != 0)
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}
