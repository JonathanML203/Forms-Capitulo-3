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
    public partial class Prac5 : Form
    {
        public Prac5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numLados = Convert.ToInt32(txtNumLados.Text);
                double longitudLado = Convert.ToDouble(txtLongitudLado.Text);

                if (rbtnPerimetro.Checked)
                {
                    double perimetro = numLados * longitudLado;
                    lblResultado.Text = $"El perímetro del polígono regular es {perimetro}";
                }
                else if (rbtnArea.Checked)
                {
                    double apotema = Convert.ToDouble(txtApotema.Text);
                    double perimetro = numLados * longitudLado;
                    double area = (perimetro * apotema) / 2;
                    lblResultado.Text = $"El área del polígono regular es {area}";
                }
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, introduce valores válidos.";
            }
        }

        private void rbtnArea_CheckedChanged(object sender, EventArgs e)
        {
            lblApotema.Visible = rbtnArea.Checked;
            txtApotema.Visible = rbtnArea.Checked;
        }

        private void rbtnPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            lblApotema.Visible = !rbtnPerimetro.Checked;
            txtApotema.Visible = !rbtnPerimetro.Checked;
        }

    }
}
