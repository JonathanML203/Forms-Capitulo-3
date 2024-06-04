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
    public partial class Prac3 : Form
    {
        public Prac3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                double porcentajeImpuesto = 0;

                if (rbtnMedicina.Checked)
                {
                    porcentajeImpuesto = 0;
                }
                else if (rbtnOtro.Checked)
                {
                    porcentajeImpuesto = 16;
                }

                double impuesto = (precio * porcentajeImpuesto) / 100;
                double precioTotal = precio + impuesto;

                lblResultado.Text = $"Impuesto: {impuesto:C} - Precio Total: {precioTotal:C}";
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, introduce un precio válido.";
            }
        }
    }
}
