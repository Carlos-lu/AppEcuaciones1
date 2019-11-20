using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcuaciones
{
    public static class Ecuaciones
    {
        public static double Ecupositiva(double a, double b, double c)
        {
            double resul = ((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
            return resul;
        }


    }
}
