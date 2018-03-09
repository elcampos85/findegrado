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
    /// Clase que muestra una ventana para introducir un extra o un descuento a la cesta
    /// </summary>
    public partial class DescuentoExtra : Form
    {
        public DescuentoExtra()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que introduce el extra o el descuento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void intro(object sender, EventArgs e)
        {
            introducirExtra();
        }

        /// <summary>
        /// Metodo que calcula el precio introducido y evalua si es valido y lo introduce a la cesta
        /// </summary>
        private void introducirExtra()
        {
            string precio = tbPrecio.Text.ToString();
            try
            {
                if (Convert.ToDouble(precio) > 9999 || precio.Equals(""))
                {
                    MessageBox.Show("La cantidad máxima a introducir es: 9999");
                    tbPrecio.Select();
                }
                else
                {
                    Constantes.PRECIO_ESTRELLA = precio;//Guardamos el precio en una constante para pasarlo a la cesta
                    this.Close();//Cerramos esta ventana
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Debes rellenar el precio correctamente");
            }
        }

        /// <summary>
        /// Metodo que evalua las teclas presionadas y que solo te permite introducir numeros con decimales y borrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (((e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
                    && tbPrecio.Text.Contains('.')) || e.KeyChar =='\b' || e.KeyChar == '-' || char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}