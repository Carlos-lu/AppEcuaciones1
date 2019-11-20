using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcuaciones
{
    public static class Ecuaciones
    {
        /// <summary>
        /// Calcula la ecuacion por la parte positiva
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static double Ecupositiva(double A, double B, double C)
        {
            double resul = ((-B + Math.Sqrt(B * B - 4 * A * C)) / (2 * A));
            return resul;
        }
        /// <summary>
        /// Calcula la ecuacion por la parte negativa
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <returns></returns>
        public static double Ecunegativa(double A, double B, double C)
        {
            double resul = ((-B - Math.Sqrt(B * B - 4 * A * C)) / (2 * A));
            return resul;
        }

    }
}
