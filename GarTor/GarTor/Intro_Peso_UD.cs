using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarTor
{
    /// <summary>
    /// Formulario para introducir cantidades
    /// </summary>
    public partial class Intro_Peso_UD : Form
    {
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Intro_Peso_UD()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo onClick que llama al metodo introducir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void intro_Peso_UD(object sender, EventArgs e)
        {
            introducir();
        }
        /// <summary>
        /// Metodo que comprueba la cantidad introducida, para añadirla a la cesta
        /// </summary>
        private void introducir()
        {
            string peso_UD = tbPeso_UD.Text.ToString();
            if(Convert.ToDouble(peso_UD) > 1000)
            {
                MessageBox.Show("La cantidad máxima a introducir es: 1000");
                tbPeso_UD.Text = "";
                tbPeso_UD.Select();
            }
            else
            {
                Constantes.PESO_UD_PRODUCTO = peso_UD;
                this.Close();
            }
        }
        /// <summary>
        /// Metodo para controlar lo que se introduce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    && tbPeso_UD.Text.Contains('.')) || e.KeyChar =='\b' || char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Metodo para que al pulsar "enter" llame al metodo introducir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPeso_UD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                introducir();
            }
        }
    }
}
