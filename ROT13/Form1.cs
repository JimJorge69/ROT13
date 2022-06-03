using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROT13
{
    public partial class ROT13 : Form
    {
        private int a = 1, b = 2, c = 3, d = 4, e = 5, f = 6, g = 7, h = 8, i = 9, j = 10, k = 11, l = 12, m = 13, n = 14, o = 15, p = 16, q = 17, r = 18, s = 19, t = 20, u = 21, v = 22, w = 23, x = 24, y = 25, z = 26;

        private void lbROT13_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public ROT13()
        {
            InitializeComponent();
            buttonIniciar.BackColor = Color.Green;//Se coloca en color rojo el boton iniciar
            textBox1.CharacterCasing = CharacterCasing.Lower;
        }
        public void SeEncripta(String entrada)
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
                        encriptar[ii] = ' ';
                        break;
                }

            }
            String primer = " ";
            Console.WriteLine("Encriptado por ROT13 \n \n");
            for (int i = 0; i < entrada.Length; i++)
            {
                primer += encriptar[i];
                Console.Write(encriptar[i]);
            }
            lbRot13.Text = primer;
            Console.WriteLine();
            Char letra;
            int[] encripto = new int[entrada.Length];
            for (int ii = 0; ii < entrada.Length; ii++)
            {
                // se declara cada elemento del string para extrar con elementAt
                letra = entrada.ElementAt(ii);
                switch (letra)
                {
                    case 'a':
                        encripto[ii] = a;
                        break;
                    case 'b':
                        encripto[ii] = b;
                        break;
                    case 'c':
                        encripto[ii] = c;
                        break;
                    case 'd':
                        encripto[ii] = d;
                        break;
                    case 'e':
                        encripto[ii] = e;
                        break;
                    case 'f':
                        encripto[ii] = f;
                        break;
                    case 'g':
                        encripto[ii] = g;
                        break;
                    case 'h':
                        encripto[ii] = h;
                        break;
                    case 'i':
                        encripto[ii] = i;
                        break;
                    case 'j':
                        encripto[ii] = j;
                        break;
                    case 'k':
                        encripto[ii] = k;
                        break;
                    case 'l':
                        encripto[ii] = l;
                        break;
                    case 'm':
                        encripto[ii] = m;
                        break;
                    case 'n':
                        encripto[ii] = n;
                        break;
                    case 'o':
                        encripto[ii] = o;
                        break;
                    case 'p':
                        encripto[ii] = p;
                        break;
                    case 'q':
                        encripto[ii] = q;
                        break;
                    case 'r':
                        encripto[ii] = r;
                        break;
                    case 's':
                        encripto[ii] = s;
                        break;
                    case 't':
                        encripto[ii] = t;
                        break;
                    case 'u':
                        encripto[ii] = u;
                        break;
                    case 'v':
                        encripto[ii] = v;
                        break;
                    case 'w':
                        encripto[ii] = w;
                        break;
                    case 'x':
                        encripto[ii] = x;
                        break;
                    case 'y':
                        encripto[ii] = y;
                        break;
                    case 'z':
                        encripto[ii] = z;
                        break;
                    default:
                        encripto[ii] = ' ';
                        break;
                }
            }
            String segundo = " ";
            Console.WriteLine("Encripta");
            for (int ii = 0; ii < entrada.Length; ii++)
            {
                segundo += encripto[ii];
                Console.WriteLine(encripto[ii]);
            }
            Console.WriteLine();
            lbvl.Text = segundo;
            int[] encriptado = new int[entrada.Length];

            int contador = 1;

            int[] p1 = new int[3];
            int[] p2 = new int[3];
            int[] p3 = new int[3];

            //Se encripta
            for (int ii = 0; ii < entrada.Length; ii++)
            {
                if (contador == 1)
                {
                    p1[0] = encripto[ii] * 1;
                    p2[0] = encripto[ii] * 2;
                    p3[0] = encripto[ii] * 1;
                }
                else if (contador == 2)
                {
                    p1[1] = encripto[ii] * 0;
                    p2[1] = encripto[ii] * (-1);
                    p3[1] = encripto[ii] * 3;
                }
                else if (contador == 3)
                {
                    p1[2] = encripto[ii] * 2;
                    p2[2] = encripto[ii] * 1;
                    p3[2] = encripto[ii] * 0;

                    encriptado[ii - 2] = p1[0] + p1[1] + p1[2];
                    encriptado[ii - 1] = p2[0] + p2[1] + p2[2];
                    encriptado[ii] = p3[0] + p3[1] + p3[2];

                    contador = 0;
                    Console.WriteLine();
                }
                contador += 1;
            }
            //Imprimo resultados encriptados
            String tercero = "";
            Console.WriteLine("Valores encriptados");
            for (int ii = 0; ii < entrada.Length; ii++)
            {
                tercero += encriptado[ii];
                Console.WriteLine(encriptado[ii]);
            }
            lbEncriptado.Text = tercero;
            //Desencriptar

            int[] Desencriptar = new int[entrada.Length];

            for (int ii = 0; ii < entrada.Length; ii++)
            {
                if (contador == 1)
                {
                    p1[0] = encriptado[ii] * 1;
                    p2[0] = encriptado[ii] * 2;
                    p3[0] = encriptado[ii] * 1;
                }
                else if (contador == 2)
                {
                    p1[1] = encriptado[ii] * 0;
                    p2[1] = encriptado[ii] * (-1);
                    p3[1] = encriptado[ii] * 3;
                }
                else if (contador == 3)
                {
                    p1[2] = encriptado[ii] * 2;
                    p2[2] = encriptado[ii] * 1;
                    p3[2] = encriptado[ii] * 0;

                    Desencriptar[ii] = p3[0] + p3[1] + p3[2];


                    contador = 0;
                    Console.WriteLine();
                }
                contador += 1;
            }
            String cuarto = "";
            //Imprimo resultados Desencriptados
            Console.WriteLine("Valores desencriptados");
            for (int ii = 0; ii < entrada.Length; ii++)
            {
                cuarto += encripto[ii];
                Console.WriteLine(encripto[ii]);
            }
            Console.WriteLine();
            lbDesencriptado.Text = cuarto;
            //Desencriptar
            char[] palabra = new char[encripto.Length];
            for (int ii = 0; ii < encripto.Length; ii++)
            {
                // se declara cada elemento del string para extrar con elementAt
                int uso = encripto[ii];

                switch (uso)
                {
                    case 1:
                        palabra[ii] = 'a';
                        break;
                    case 2:
                        palabra[ii] = 'b';
                        break;
                    case 3:
                        palabra[ii] = 'c';
                        break;
                    case 4:
                        palabra[ii] = 'd';
                        break;
                    case 5:
                        palabra[ii] = 'e';
                        break;
                    case 6:
                        palabra[ii] = 'f';
                        break;
                    case 7:
                        palabra[ii] = 'g';
                        break;
                    case 8:
                        palabra[ii] = 'h';
                        break;
                    case 9:
                        palabra[ii] = 'i';
                        break;
                    case 10:
                        palabra[ii] = 'j';
                        break;
                    case 11:
                        palabra[ii] = 'k';
                        break;
                    case 12:
                        palabra[ii] = 'l';
                        break;
                    case 13:
                        palabra[ii] = 'm';
                        break;
                    case 14:
                        palabra[ii] = 'n';
                        break;
                    case 15:
                        palabra[ii] = 'o';
                        break;
                    case 16:
                        palabra[ii] = 'p';
                        break;
                    case 17:
                        palabra[ii] = 'q';
                        break;
                    case 18:
                        palabra[ii] = 'r';
                        break;
                    case 19:
                        palabra[ii] = 's';
                        break;
                    case 20:
                        palabra[ii] = 't';
                        break;
                    case 21:
                        palabra[ii] = 'u';
                        break;
                    case 22:
                        palabra[ii] = 'v';
                        break;
                    case 23:
                        palabra[ii] = 'w';
                        break;
                    case 24:
                        palabra[ii] = 'x';
                        break;
                    case 25:
                        palabra[ii] = 'y';
                        break;
                    case 26:
                        palabra[ii] = 'z';
                        break;
                    default:
                        palabra[ii] = ' ';
                        break;
                }
            }
            String quito = "";
            //Valores desencriptados
            Console.WriteLine("Valores regresados a la normalidad");
            for (int ii = 0; ii < encripto.Length; ii++)
            {
                quito += palabra[ii];
                Console.WriteLine(palabra[ii]);
            }
            Console.WriteLine();
            lbTXTDesencriptado.Text = quito;
        }
        private void buttonIniciar_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")//Valido que el campo de texto este vacio
            {
                MessageBox.Show("Operacion Mal", "¡UPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else//si no es vacio se inicia el analizador
            {
                Console.WriteLine("- INGRESO -");
                String entrada = textBox1.Text;//Decalro el texto ingresado en un string
                SeEncripta(entrada);
                buttonIniciar.BackColor = Color.Yellow;//Se coloca en color rojo el boton iniciar
                Console.WriteLine(" - SALIO -");

                buttonIniciar.BackColor = Color.Green;//Se coloca en color rojo el boton iniciar

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
