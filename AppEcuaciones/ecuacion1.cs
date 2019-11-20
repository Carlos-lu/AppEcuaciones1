using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcuaciones
{
    public static class ecuacion1
    {
        public static double x1(double a, double b,double c,out string msg)
        {
            double x1;
            msg = "";
            if (a == 0)
            {
                msg = "Error, division por cero...";
                return 0;//retorno abandonar
            }
            double d = (b * b) - (4*a * c);
            if (d > 0)
            {
                msg = "La ecuacion tiene solucion imaginaria....";
                return 0;
            }
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;

        }
        /// <summary>
        /// SACA X2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static double x2(double a, double b, double c, out string msg)
        {
            double x2 ;
            msg = "";
            if (a == 0)
            {
                msg = "Error, division por cero...";
                return 0;//retorno abandonar
            }
            double d = (b * b) - (4 * a * c);
            if (d > 0)
            {
                msg = "La ecuacion tiene solucion imaginaria....";
                return 0;
            }
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;

        }
    }
}
