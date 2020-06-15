using System;
using System.Collections.Generic;
using System.Text;

namespace ExStatic1
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;
        public static double Cota;
        public static double Qtd;

        public  static double Valor()
        {
            return (Cota * Qtd) + (Cota * Qtd * Iof);
        }
    }
}
