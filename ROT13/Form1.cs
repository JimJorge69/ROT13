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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonIniciar.BackColor = Color.Green;//Se coloca en color rojo el boton iniciar
            textBox1.CharacterCasing = CharacterCasing.Lower;
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
                Encriptador lex = new Encriptador();//Se manda a llamar el objeto
                LinkedList<Token> ltokens = lex.escanear(entrada);//Se crea una lista con TOKEN y se ingresa en el objeto
                Console.WriteLine(" - SALIO -");

                buttonIniciar.BackColor = Color.Yellow;//Se coloca en color rojo el boton iniciar

            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
