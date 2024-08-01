using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    public static class Calculo
    {
        public static double somar(double x, double y)
        {
            return x + y;
        }

        public static double subtrair(double x, double y)
        {
            return x - y;
        }

        public static double multiplicar(double x, double y)
        {
            return x * y;
        }

        public static double dividir(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("O divisor não pode ser zero.");
            }
            return x / y;
        }
    }
}
