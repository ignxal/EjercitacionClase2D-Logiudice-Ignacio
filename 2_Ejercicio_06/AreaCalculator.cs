using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Ejercicio_06
{
    static class AreaCalculator
    {
        public static double CalculateSquareArea(double sideLength) {
            return sideLength * sideLength;
        }

        public static double CalculateTriangleArea(double baseValue, double height) {
            return (baseValue * height) / 2;
        }

        public static double CalculateCircleArea(double radio) {
            return Math.PI * (radio * radio);
        }
    }
}
