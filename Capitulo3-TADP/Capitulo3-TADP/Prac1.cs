using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo3_TADP
{
    public partial class Prac1 : Form
    {
        public Prac1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer la entrada del TextBox
            string input = TbNum.Text;
            int numero;

            // Validar si la entrada es un número válido
            if (int.TryParse(input, out numero))
            {
                // Verificar si el número es par o impar
                if (numero % 2 == 0)
                {
                    lbNum.Text = "El número " + numero + " es par.";
                }
                else
                {
                    lbNum.Text = "El número " + numero + " es impar.";
                }
            }
            else
            {
                lbNum.Text = "Entrada no válida. Por favor, introduce un número entero.";
            }
        }
    }
}
