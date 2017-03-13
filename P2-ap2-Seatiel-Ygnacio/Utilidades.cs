using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P2_ap2_Seatiel_Ygnacio
{
    public class Utilidades
    {
        public static int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }
    }
}
