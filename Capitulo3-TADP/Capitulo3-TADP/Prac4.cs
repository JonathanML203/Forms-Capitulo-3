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
    public partial class Prac4 : Form
    {
        public Prac4()
        {
            InitializeComponent();
        }

        private void btnObtenerDia_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                string dia = ObtenerDiaSemana(numero);
                if (dia != null)
                {
                    lblResultado.Text = $"El día correspondiente al número {numero} es {dia}";
                }
                else
                {
                    lblResultado.Text = "Número de día inválido. Debe estar entre 1 y 7.";
                }
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, introduce un número válido.";
            }
        }

        static string ObtenerDiaSemana(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Domingo";
                case 2:
                    return "Lunes";
                case 3:
                    return "Martes";
                case 4:
                    return "Miércoles";
                case 5:
                    return "Jueves";
                case 6:
                    return "Viernes";
                case 7:
                    return "Sábado";
                default:
                    return null;
            }
        }

    }
}
