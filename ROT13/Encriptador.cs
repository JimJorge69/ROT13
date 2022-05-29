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
        private char[] abecedario = {'a', 'b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z'};
        public LinkedList<Token> escanear(String entrada)
        {
            Char caracter;
            //Se inicia un siclo para la verificacion de la operacion sea correcta
            char[] encriptar = new char[entrada.Length];

            for (int ii = 0; ii < entrada.Length; ii++)
            {
                caracter = entrada.ElementAt(ii);

                switch (caracter)
                {
                    case 'a':
                        encriptar[ii] = 'n';
                        break;
                    case 'b':
                        encriptar[ii] = 'o';
                        break;
                    case 'c':
                        encriptar[ii] = 'p';
                        break;
                    case 'd':
                        encriptar[ii] = 'q';
                        break;
                    case 'e':
                        encriptar[ii] = 'r';
                        break;
                    case 'f':
                        encriptar[ii] = 's';
                        break;
                    case 'g':
                        encriptar[ii] = 't';
                        break;
                    case 'h':
                        encriptar[ii] = 'u';
                        break;
                    case 'i':
                        encriptar[ii] = 'v';
                        break;
                    case 'j':
                        encriptar[ii] = 'w';
                        break;
                    case 'k':
                        encriptar[ii] = 'x';
                        break;
                    case 'l':
                        encriptar[ii] = 'y';
                        break;
                    case 'm':
                        encriptar[ii] = 'z';
                        break;
                    case 'n':
                        encriptar[ii] = 'a';
                        break;
                    case 'o':
                        encriptar[ii] = 'b';
                        break;
                    case 'p':
                        encriptar[ii] = 'c';
                        break;
                    case 'q':
                        encriptar[ii] = 'd';
                        break;
                    case 'r':
                        encriptar[ii] = 'e';
                        break;
                    case 's':
                        encriptar[ii] = 'f';
                        break;
                    case 't':
                        encriptar[ii] = 'g';
                        break;
                    case 'u':
                        encriptar[ii] = 'h';
                        break;
                    case 'v':
                        encriptar[ii] = 'i';
                        break;
                    case 'w':
                        encriptar[ii] = 'j';
                        break;
                    case 'x':
                        encriptar[ii] = 'k';
                        break;
                    case 'y':
                        encriptar[ii] = 'l';
                        break;
                    case 'z':
                        encriptar[ii] = 'm';
                        break;
                    default:
                        // ningun valor recibido
                        break;
                }

            }

            for (int i=0;i<entrada.Length;i++)
            {
                Console.Write(encriptar[i]);
            }
            Console.WriteLine();
                return Salida;
        }
    }
}
