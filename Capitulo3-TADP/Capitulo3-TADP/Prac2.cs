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
    public partial class Prac2 : Form
    {
        public Prac2()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(txtValor.Text);

                if (rbtnGradosARadianes.Checked)
                {
                    double radianes = valor * (Math.PI / 180);
                    lblResultado.Text = $"{valor} grados equivalen a {radianes} radianes.";
                }
                else if (rbtnRadianesAGrados.Checked)
                {
                    double grados = valor * (180 / Math.PI);
                    lblResultado.Text = $"{valor} radianes equivalen a {grados} grados.";
                }
                else
                {
                    lblResultado.Text = "Por favor, selecciona un tipo de conversión.";
                }
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, introduce un valor numérico válido.";
            }
        }
    }
}
