using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROT13
{
    class Encriptador
    {
        private LinkedList<Token> Salida;
        private int a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g = 7, h = 8, i = 9, j = 10, k = 11, l = 12, m = 13, n = 14, ñ = 15, o = 16, p = 17, q = 18, r = 19, s = 20, t = 21, u = 22, v = 23, w = 24, x = 25, y = 26, z = 27;

        public LinkedList<Token> escanear(String entrada)
        {
            Char caracter;
            //Se inicia un siclo para la verificacion de la operacion sea correcta
            for (int si = 0; si < entrada.Length; si++)
            {
                caracter = entrada.ElementAt(si);

                if (caracter=='a')
                {

                }

            }
                return Salida;
        }
    }
}
