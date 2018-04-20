using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Form_Calculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton cerra app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Limpia todos los campos del formulario.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            comboOperador.Text = "";
            labelResultado.Text = "0";
            btnConvertirDecimal.Enabled = true;
            btnConvertirBinario.Enabled = true;
        }
        /// <summary>
        /// Boton limpiar formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Boton operar, realiza la operacion aritmética seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            Numero n1 = new Numero(txtNumero1.Text);
            Numero n2 = new Numero(txtNumero2.Text);
            string error = "No podes dividir por cero.";

            if (txtNumero2.Text=="" || txtNumero2.Text == "0" && comboOperador.Text=="/")
            {
                labelResultado.Text = error;
            }
            if(txtNumero1.Text=="" && txtNumero2.Text == "")
            {
                labelResultado.Text = "0";
            }
            else
            {
                double resultado = Calculadora.Operar(n1, n2, comboOperador.Text);
                labelResultado.Text = resultado.ToString();
            }

        }
        /// <summary>
        /// Boton convertir binario a entero.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirBinario_Click(object sender, EventArgs e)
        {
            Numero n = new Numero();

            labelResultado.Text = n.DecimalBinario(labelResultado.Text);

            if (labelResultado.Text != "0")
            {
                btnConvertirDecimal.Enabled = true;
                btnConvertirBinario.Enabled = false;
            }
            else
            {
                btnConvertirDecimal.Enabled = true;
                btnConvertirBinario.Enabled = true;
            }
        }
        /// <summary>
        /// Boton convertir decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            Numero n = new Numero();

            labelResultado.Text = n.BinarioDecimal(labelResultado.Text);
            if(labelResultado.Text!="0")
            {
                btnConvertirDecimal.Enabled = false;
                btnConvertirBinario.Enabled = true;
            }
            else
            {
                btnConvertirDecimal.Enabled = true;
                btnConvertirBinario.Enabled = true;
            }
        }
    }
}
